using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate
{
    public class ModInfo
    {
        /// <summary>
        /// Id(对应模板里的nameSpace)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// mod显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// mod功能描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 程序集名称(英语或拼音)
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// 执行入口
        /// </summary>
        public string EntryMethod { get; set; }
    }
}
