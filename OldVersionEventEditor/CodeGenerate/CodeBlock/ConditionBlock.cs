using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock
{
    public class ConditionBlock : ICodeBlock
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<ICodeBlock> CodeBlocks { get; set; }
    }
}
