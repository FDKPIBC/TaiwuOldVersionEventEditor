using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock
{
    public class EventMethod : ICodeBlock
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 所有目标Id
        /// </summary>
        public List<string> Targets { get; set; }

        /// <summary>
        /// 包含的所有代码逻辑
        /// </summary>
        public List<ICodeBlock> CodeBlocks { get; set; }
    }
}
