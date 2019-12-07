using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldVersionEventEditor
{
    public static class StringExtension 
    {
        public static string ReplaceToChineseFormat(this string content)
        {
            content = content.Replace(',', '，').Replace('.','。');
            return content;
        }
    }
}
