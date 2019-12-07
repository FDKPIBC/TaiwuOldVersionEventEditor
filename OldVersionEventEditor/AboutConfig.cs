using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldVersionEventEditor
{
    public partial class AboutConfig : Form
    {
        public AboutConfig()
        {
            InitializeComponent();
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Config.txt");
            if (File.Exists(filePath))
            {
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }
    }
}
