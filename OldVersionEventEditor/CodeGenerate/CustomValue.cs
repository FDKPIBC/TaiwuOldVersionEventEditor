﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldVersionEventEditor.CodeGenerate
{
    public class CustomValue
    {
        public string Id { get; set; }

        public string Name { get; set; }

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
                if (value.GetType() == ValueType || ValueType.IsSubclassOf(value.GetType()) || ValueType.GetType().IsSubclassOf(ValueType))
                {
                    
                }
            }
        }

        public CustomValue(Type valueType)
        {
            ValueType = valueType;
        }
    }
}