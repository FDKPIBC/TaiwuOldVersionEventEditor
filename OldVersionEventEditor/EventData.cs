using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
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
        [Description("备注性质,方便文本编辑时区分内容,在游戏中不会有任何的显示关联")]
        public string Name { get; set; }

        /// <summary>
        /// 事件人物id
        /// </summary>
        [DisplayName("触发者Id")]
        [Category("公用")]
        [Description("事件人物Id(0:当前触发者,-1:当前主角,-99:不显示人物头像;亦可填写人物模板中对应的id,参照Actor_Date)")]
        [DefaultValue(-1)]
        public string EventActorId { get; set; }

        /// <summary>
        /// 事件文本
        /// </summary>
        [DisplayName("文本")]
        [Category("公用")]
        [Description("事件或选项中显示的文本(其中D0-Dn为动态的文本显示,对应事件数据数组从第4位开始往后依次累加的值)")]
        public string Text { get; set; }

        /// <summary>
        /// 文本占位符指示的类型
        /// </summary>
        [DisplayName("文本占位符类型")]
        [Category("公用")]
        [Description("当前事件或选项文本中D0-Dn的显示内容(D0对应第一个,往后依次累加)\n具体配置项请在“关于->关于配置”中查看")]
        public string[] DataTypes { get; set; }

        #region 事件部分

        /// <summary>
        /// 背景图片类型
        /// </summary>
        [DisplayName("背景图片类型")]
        [Category("事件")]
        [Description("事件的背景图像,此处填写图片对应的id即可(若填写-1则为当前位置对应的图像)")]
        public string BackgroundImageType { get; set; }

        /// <summary>
        /// 显示遮罩
        /// </summary>
        [DisplayName("背景黑屏显示")]
        [Category("事件")]
        [Description("延迟显示黑屏时间(不输入值时则不显示黑屏背景,具体效果参照传剑事件)")]
        public int ShowMask { get; set; }

        /// <summary>
        /// 是否是输入事件
        /// </summary>
        [DisplayName("是否显示输入框")]
        [Category("事件")]
        [Description("当前为输入框事件")]
        public bool IsInput { get; set; }

        /// <summary>
        /// 选项
        /// </summary>
        [DisplayName("事件选项")]
        [Category("事件")]
        [Description("事件所包含的选项.\n每行填写一个与\"选项\"选项卡中对应配置的Id.\n例如:\n100001\n100002")]
        public string[] Choices { get; set; }

        #endregion

        #region 选项部分

        /// <summary>
        /// 选项创建时的规则
        /// </summary>
        [DisplayName("创建规则")]
        [Category("选项")]
        [Description("事件选项创建时是否显示的通用判断")]
        public string[] CreateCondition { get; set; }

        /// <summary>
        /// 下一个事件Id
        /// </summary>
        [DisplayName("下一个事件Id")]
        [Category("选项")]
        [Description("当前事件结束的后续事件,若无分支事件可使用本配置(注:如果当前选项为选人或选物则本配置无效)")]
        public string NextEventId { get; set; }

        /// <summary>
        /// 选项点击触发
        /// </summary>
        [DisplayName("选项点击")]
        [Category("选项")]
        [Description("事件点击后的触发逻辑(自控逻辑或使用内置配置)")]
        public string[] ChoiceClick { get; set; }

        /// <summary>
        /// 结束遮罩
        /// </summary>
        [DisplayName("结束背景黑屏")]
        [Category("选项")]
        [Description("事件结束遮罩时间延迟")]
        public string EndMask { get; set; }

        #endregion

        [Browsable(false)]
        public DataType DataType { get; set; }

        public override string ToString()
        {
            return $"{Id}.{Name}";
        }

        public string ToLine()
        {
            if (!int.TryParse(Id,out var id)) throw new Exception($"[{Id}.{Name}]Id不能超过int最大值上限!");
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
            stringArray[10] = ShowMask.ToString();
            stringArray[11] = EndMask;
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
            Text = stringArray[4];
            DataTypes = stringArray[5].Split('|');
            Choices = stringArray[6].Split('|');
            CreateCondition = stringArray[7].Split('|');
            NextEventId = stringArray[8];
            ChoiceClick = stringArray[9].Split('|');
            ShowMask = stringArray[10].ToInt32();
            EndMask = stringArray[11];
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
