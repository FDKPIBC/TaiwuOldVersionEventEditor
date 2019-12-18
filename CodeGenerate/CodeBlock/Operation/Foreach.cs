using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock.Operation
{
    /// <summary>
    /// 遍历操作
    /// </summary>
    public class Foreach : OperationBlock
    {
        /// <summary>
        /// 遍历范围
        /// </summary>
        public List<ConditionBlock> ConditionBlocks { get; set; }

        /// <summary>
        /// 遍历执行的操作
        /// </summary>
        public List<OperationBlock> OperationBlocks { get; set; }

        public override string Output()
        {
            return string.Empty;
        }

        public override void OnOperation(params object[] args)
        {

        }
    }
}
