namespace OldVersionEventEditor.CodeGenerate.CodeBlock
{
    /// <summary>
    /// 代码块
    /// </summary>
    public interface ICodeBlock
    {
        /// <summary>
        /// 
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; set; }
    }
}
