using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldVersionEventEditor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            saveTsmi.Enabled =
               eventTC.Enabled = false;
            EventDataManager.Instance.OnFileLoaded += OnFileLoaded;
        }

        public void OnFileLoaded()
        {
            eventTC.Enabled = true;
            saveTsmi.Enabled = true;
            RefreshEventList();
            RefreshChoiceList();
        }

        private void newTsmi_Click(object sender, EventArgs e)
        {
            EventDataManager.Instance.CreateNew();
        }

        private void loadTsmi_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                EventDataManager.Instance.LoadFile(ofd.FileName);
            }
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {
            EventDataManager.Instance.OutPutData();
        }

        private void tbxSearchEvent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchEvent.Text))
            {
                RefreshEventList(tbxSearchEvent.Text);
            }
            else
            {
                RefreshEventList();
            }
        }

        private void tbxSearchChoice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchChoice.Text))
            {
                RefreshChoiceList(tbxSearchChoice.Text);
            }
            else
            {
                RefreshChoiceList();
            }
        }

        private void btnRemoveChoice_Click(object sender, EventArgs e)
        {
            if (lbChoice.SelectedIndex < 0) return;
            var eventData = ChoicePG.SelectedObject as EventData;
            EventDataManager.Instance.ChoiceDatas.Remove(eventData);
            EventPG.SelectedObject = null;
            lbChoice.SelectedIndex = -1;
            RefreshChoiceList();
        }
        
        private void btnAddChoice_Click(object sender, EventArgs e)
        {
            var newEventData = new EventData();
            EventDataManager.Instance.ChoiceDatas.Add(newEventData);
            RefreshChoiceList();
            lbChoice.SelectedIndex = (lbChoice.DataSource as List<EventData>).IndexOf(newEventData);
        }
        
        private void lbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChoice.SelectedIndex < 0) return;
            ChoicePG.Enabled = true;
            ChoicePG.SelectedObject = lbChoice.SelectedItem;
            choiceIndex = lbChoice.SelectedIndex;
        }

        public void RefreshChoiceList(string name = "")
        {
            lbChoice.DataSource = null;
            var data = EventDataManager.Instance.ChoiceDatas;
            if (!string.IsNullOrEmpty(name))
            {
                data = data.FindAll(t => t.Id.Contains(name) || t.Name.Contains(name));
            }
            lbChoice.DataSource = data;
            //lbChoice.DisplayMember = "Name";
        }
        
        public void RefreshEventList(string name = "")
        {
            lbEvent.DataSource = null;
            var data = EventDataManager.Instance.EventDatas;
            if (!string.IsNullOrEmpty(name))
            {
                data = data.FindAll(t => t.Id.Contains(name) || t.Name.Contains(name));
            }
            lbEvent.DataSource = data;
            //lbEvent.DisplayMember = "Name";
        }

        private int eventIndex = -1;

        private int choiceIndex = -1;

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            var newEventData = new EventData();
            EventDataManager.Instance.EventDatas.Add(newEventData);
            RefreshEventList();
            lbEvent.SelectedIndex = EventDataManager.Instance.ChoiceDatas.IndexOf(newEventData);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbEvent.SelectedIndex < 0) return;
            var eventData = EventPG.SelectedObject as EventData;
            EventDataManager.Instance.EventDatas.Remove(eventData);
            EventPG.SelectedObject = null;
            EventPG.Enabled = false;
            lbEvent.SelectedIndex = -1;
            RefreshEventList();
        }

        private void lbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChoice.SelectedIndex < 0) return;
            EventPG.Enabled = true;
            EventPG.SelectedObject = lbEvent.SelectedItem;
            eventIndex = lbEvent.SelectedIndex;
        }

        private void btnRefreshEvent_Click(object sender, EventArgs e)
        {
            RefreshEventList(tbxSearchEvent.Text);
            //lbEvent.SelectedIndex = -1;
            lbEvent.SelectedIndex = eventIndex;
            //EventPG.SelectedObject = null;
        }

        private void btnRefreshChoice_Click(object sender, EventArgs e)
        {
            RefreshChoiceList(tbxSearchChoice.Text);
            //lbChoice.SelectedIndex = -1;
            lbChoice.SelectedIndex = choiceIndex;
            //ChoicePG.SelectedObject = null;
        }

        private void tsmiAboutEditor_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void tsmiAboutConfig_Click(object sender, EventArgs e)
        {
            new AboutConfig().Show();
        }
    }
}
