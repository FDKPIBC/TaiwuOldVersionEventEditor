using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock.Operation
{
    /// <summary>
    /// 变量操作
    /// </summary>
    public class Variable : OperationBlock
    {
        /// <summary>
        /// 目标变量id（CustomValue）
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// 目标值
        /// </summary>
        public object TargetValue { get; set; }
    }
}
