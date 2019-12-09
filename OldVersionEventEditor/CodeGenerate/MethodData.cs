using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor.CodeGenerate
{
    public class MethodData
    {
        public Type[] RequireParameters { get; set; }

        public Type Return { get; set; }

        public string Name { get; set; }
    }
}
