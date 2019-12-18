using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock.Operation
{
    /// <summary>
    /// 方法调用
    /// </summary>
    public class MethodCall : OperationBlock
    {
        /// <summary>
        /// 参数
        /// </summary>
        public object[] Parameters { get; set; }

        /// <summary>
        /// 目标Id
        /// </summary>
        public string TargetId { get; set; }



    }
}
