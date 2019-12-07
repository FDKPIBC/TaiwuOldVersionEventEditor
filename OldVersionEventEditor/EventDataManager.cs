using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldVersionEventEditor
{
    public class EventDataManager
    {
        private static EventDataManager _instance;
        public static EventDataManager Instance => _instance ?? (_instance = new EventDataManager());

        public List<EventData> EventDatas;

        public List<EventData> ChoiceDatas;

        private static string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"OutPut");

        private static string outputFile = Path.Combine(outputPath,"Event_Data.txt");

        private string _fileHeader = "#,0,1,2,3,4,5,6,7,8,9,10,11";

        public Action OnFileLoaded;

        public EventDataManager()
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
        }

        public void LoadFile(string path)
        {
            try
            {
                var allLines = File.ReadAllLines(path);
                EventDatas = new List<EventData>();
                ChoiceDatas = new List<EventData>();
                foreach (var line in allLines)
                {
                    if (!line.StartsWith("#"))
                    {
                        var newData = new EventData(line.Split(','));
                        if (!string.IsNullOrEmpty(newData.BackgroundImageType))
                        {
                            EventDatas.Add(newData);
                        }
                        else
                        {
                            ChoiceDatas.Add(newData);
                        }
                    }
                }
                OnFileLoaded?.Invoke();
            }
            catch (Exception e)
            {
                MessageBox.Show(@"打开文件失败!");
            }
        }

        public void CreateNew()
        {
            EventDatas = new List<EventData>();
            ChoiceDatas = new List<EventData>();
            OnFileLoaded?.Invoke();
        }

        /// <summary>
        /// 输出编辑的数据
        /// </summary>
        public void OutPutData()
        {
            var sb = new StringBuilder();
            sb.AppendLine(_fileHeader);
            foreach (var eventData in EventDatas)
            {
                sb.AppendLine(eventData.ToLine());
            }
            foreach (var eventData in ChoiceDatas)
            {
                sb.AppendLine(eventData.ToLine());
            }
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            File.WriteAllText(outputFile,sb.ToString(),Encoding.UTF8);
            Process.Start(outputFile);
        }
    }
}
