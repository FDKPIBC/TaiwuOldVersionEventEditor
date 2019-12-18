using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldVersionEventEditor.CodeGenerate.CodeBlock;

namespace OldVersionEventEditor.CodeGenerate
{
    public class CustomValue : ICodeBlock
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public readonly Type ValueType;

        private object _value;

        public object Value
        {
            get => _value;
            set
            {
                if (ValueType == null)
                {
                    throw new Exception("数据无效,类型为空!");
                }
                if (value.GetType() == ValueType && ( value.GetType().IsValueType || value.GetType().IsArray ))
                {
                    _value = value;
                }
            }
        }

        public CustomValue(Type valueType)
        {
            ValueType = valueType;
        }
    }
}
