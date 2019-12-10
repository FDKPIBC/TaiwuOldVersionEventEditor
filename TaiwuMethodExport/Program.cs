using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldVersionEventEditor.CodeGenerate;

namespace TaiwuMethodExport
{
    class Program
    {
        private static string[] _searchList = new[]
        {
            "DateFile",
        };

        static void Main(string[] args)
        {
            var flag = true;
            while (flag)
            {
                //Console.WriteLine("请选择游戏主目录!");
                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                var dataPath = Path.Combine(@"E:\SteamLibrary\steamapps\common\The Scroll Of Taiwu");
                    var outPutPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"methods.dat");
                    var assPath = @"E:\SteamLibrary\steamapps\common\The Scroll Of Taiwu\The Scroll Of Taiwu Alpha V1.0_Data\Managed\Assembly-CSharp.dll";//Path.Combine(dataPath, "The Scroll Of Taiwu Alpha V1.0_Data", "Managed", "Assembly-CSharp.dll");
                    var monoPath = @"E:\SteamLibrary\steamapps\common\The Scroll Of Taiwu\MonoBleedingEdge\EmbedRuntime\mono-2.0-bdwgc.dll";//Path.Combine(dataPath, "MonoBleedingEdge", "EmbedRuntime", "mono-2.0-bdwgc.dll");
                    Console.WriteLine(@"读取成功开始导出描述文件!");
                    var decodeAss = XXTEA.Decrypt(File.ReadAllBytes(assPath), nhelper.dd("B0F575250D7D35F4BE1A0B4627C732FEAB43F5FB102C637C0D0FA2311913C8E36812DDFAC9CB0F65112461542A5DFE9BFEC59B6C3890E5296BBCBE4858E3AE687FECC73963D06BD1043DDEB4AE5B6037"));
                var methods = GetMethodDatas(Assembly.Load(decodeAss));
                    File.WriteAllBytes(outPutPath,Serialize(methods));
                    flag = false;
                //}

                Console.WriteLine(@"是否退出?(y/n)");
                var input = Console.ReadLine();
                if (input != null && input.ToUpper() == "Y")
                {
                    flag = false;
                }

                Console.ReadKey();
            }
        }

        static List<MethodData> GetMethodDatas(Assembly assembly)
        {
            var methods = new List<MethodData>();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (_searchList.Contains(type.Name))
                {
                    foreach (var methodInfo in type.GetMethods(BindingFlags.DeclaredOnly))
                    {
                        methods.Add(new MethodData(methodInfo));
                    }
                }
            }

            return methods;
        }



        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] Serialize(object obj)
        {
            if (obj == null) return null;
            using (var ms = new MemoryStream())
            {
                var bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                return ms.GetBuffer();
            }
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static object Deserialize(byte[] bytes)
        {
            try
            {
                using (var ms = new MemoryStream(bytes))
                {
                    var bf = new BinaryFormatter();
                    return bf.Deserialize(ms);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
