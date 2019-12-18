using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldVersionEventEditor.CodeGenerate.CodeBlock;

namespace OldVersionEventEditor.CodeGenerate
{
    public class CodeManager
    {
        /// <summary>
        /// 当前mod信息
        /// </summary>
        public ModInfo CurrentModInfo { get; set; }

        /// <summary>
        /// 可处理事件id
        /// </summary>
        public List<string> HookEventIds { get; set; }

        public List<string> HookChoiceIds { get; set; }
    }
}
