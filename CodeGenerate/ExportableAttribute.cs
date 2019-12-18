using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate
{
    /// <summary>
    /// 不可导出
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class ExportDisableAttribute : Attribute
    {

    }
}
