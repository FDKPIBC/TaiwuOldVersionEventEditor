using System;

namespace OldVersionEventEditor.CodeGenerate.CodeBlock.Operation
{
    /// <summary>
    /// 操作块
    /// </summary>
    public abstract class OperationBlock : ICodeBlock
    {
        public string Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual void OnInit(params object[] args)
        {
            throw new InvalidOperationException("无效实现!");
        }

        public virtual void OnOperation(params object[] args)
        {
            throw new InvalidOperationException("无效实现!");
        }

        public virtual string Output()
        {
            throw new InvalidOperationException("无效实现!");
        }
    }
}
