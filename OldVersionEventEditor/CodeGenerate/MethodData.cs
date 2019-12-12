using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate
{
    /// <summary>
    /// 系统内置方法
    /// </summary>
    public class MethodData
    {
        /// <summary>
        /// 请求参数类型数组(AssemblyQualifiedName)
        /// </summary>
        public string[] RequireParameters { get; set; }

        /// <summary>
        /// 返回类型(AssemblyQualifiedName)
        /// </summary>
        public string Return { get; set; }

        /// <summary>
        /// 方法名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get; set; }

        /// <summary>
        /// 所属类名
        /// </summary>
        public string ClassName { get; set; }

        public MethodData()
        {

        }

        public MethodData(MethodInfo info)
        {
            Return = info.ReturnType.AssemblyQualifiedName;
            RequireParameters = info.GetParameters().Select(t=>t.ParameterType.AssemblyQualifiedName).ToArray();
            Name = info.Name;
            if (info.DeclaringType != null)
            {
                NameSpace = info.DeclaringType.Namespace;
                ClassName = info.DeclaringType.Name;
            }
            else
            {
                Console.WriteLine($"{info.Name}未获取到所属类型信息!");
            }
        }
    }
}
