using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OldVersionEventEditor
{
    public class EventData
    {
        /// <summary>
        /// id
        /// </summary>
        [DisplayName("ID")]
        [Category("公用")]
        [DefaultValue(60000)]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        [Category("公用")]
        public string Name { get; set; }

        /// <summary>
        /// 背景图片类型
        /// </summary>
        [DisplayName("背景图片类型")]
        [Category("公用")]
        [DefaultValue(-1)]
        public string BackgroundImageType { get; set; }

        /// <summary>
        /// 事件人物id
        /// </summary>
        [DisplayName("触发者Id")]
        [Category("公用")]
        [DefaultValue(-1)]
        public string EventActorId { get; set; }

        /// <summary>
        /// 事件文本
        /// </summary>
        [DisplayName("文本")]
        [Category("公用")]
        public string Text { get; set; }

        /// <summary>
        /// 文本占位符指示的类型
        /// </summary>
        [DisplayName("占位符类型")]
        [Category("公用")]
        public string[] DataTypes { get; set; }

        #region 事件部分

        /// <summary>
        /// 选项
        /// </summary>
        [DisplayName("选项")]
        [Category("事件")]
        public string[] Choices { get; set; }

        /// <summary>
        /// 显示遮罩
        /// </summary>
        [DisplayName("是否开始遮罩")]
        [Category("事件")]
        public bool ShowMask { get; set; }

        /// <summary>
        /// 结束遮罩
        /// </summary>
        [DisplayName("是否结束遮罩")]
        [Category("事件")]
        public bool EndMask { get; set; }

        /// <summary>
        /// 是否是输入事件
        /// </summary>
        [DisplayName("是否显示输入框")]
        [Category("事件")]
        public bool IsInput { get; set; }

        #endregion

        #region 选项部分

        /// <summary>
        /// 选项创建时的规则
        /// </summary>
        [DisplayName("创建规则")]
        [Category("选项")]
        public string[] CreateCondition { get; set; }

        /// <summary>
        /// 下一个事件Id
        /// </summary>
        [DisplayName("下一个事件Id")]
        [Category("选项")]
        public string NextEventId { get; set; }

        /// <summary>
        /// 选项点击触发
        /// </summary>
        [DisplayName("选项点击")]
        [Category("选项")]
        public string[] ChoiceClick { get; set; }

        #endregion

        [Browsable(false)]
        public DataType DataType { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name}";
        }

        public string ToLine()
        {
            var stringArray = new string[13];
            stringArray[0] = Id.ToString();
            stringArray[1] = Name;
            stringArray[2] = BackgroundImageType.ToString();
            stringArray[3] = EventActorId.ToString();
            stringArray[4] = Text;
            stringArray[5] = string.Join("|", DataTypes);
            stringArray[6] = string.Join("|", Choices);
            stringArray[7] = string.Join("|", CreateCondition);
            stringArray[8] = NextEventId.ToString();
            stringArray[9] = string.Join("|", ChoiceClick);
            stringArray[10] = ShowMask ? "1" : "0";
            stringArray[11] = EndMask ? "1" : "0";
            stringArray[12] = IsInput ? "1" : "0";
            return string.Join(",", stringArray);
        }

        public EventData()
        {

        }

        public EventData(string[] stringArray)
        {
            Id = stringArray[0];
            Name = stringArray[1];
            BackgroundImageType = stringArray[2];
            EventActorId = stringArray[3];
            Text =stringArray[4];
            DataTypes = stringArray[5].Split('|');
            Choices = stringArray[6].Split('|');
            CreateCondition = stringArray[7].Split('|');
            NextEventId = stringArray[8];
            ChoiceClick = stringArray[9].Split('|');
            ShowMask = stringArray[10] == "1";
            EndMask = stringArray[11] == "1";
            IsInput = stringArray[12] == "1";
        }
    }

    public enum DataType
    {
        Unknown = -1,
        Event = 0,
        Choice = 1,
    }
}
