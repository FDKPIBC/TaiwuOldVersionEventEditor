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

        public VariableOperationType VOType { get; set; }

        /// <summary>
        /// 变量块操作类型
        /// </summary>
        public enum VariableOperationType
        {
            /// <summary>
            /// 定义
            /// </summary>
            Declare = 0,
            /// <summary>
            /// 赋值
            /// </summary>
            Assignment = 1,
        }
    }
}
