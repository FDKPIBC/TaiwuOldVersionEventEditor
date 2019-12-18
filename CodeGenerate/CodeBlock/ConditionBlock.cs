using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock
{
    /// <summary>
    /// 判断块
    /// </summary>
    public class ConditionBlock : ICodeBlock
    {
        public string Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public List<ICodeBlock> CodeBlocks { get; set; }

        public BlockType ConditionBlockType { get; set; }

        public enum BlockType
        {
            Simple = 0,
            Group = 1,
        }
    }
}
