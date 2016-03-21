using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializeTst
{
    class Program
    {
        static void Main(string[] args)
        {
            //var str1 = Process.GetCurrentProcess().MainModule.FileName;
            //var str2 = Environment.CurrentDirectory;
            //var str3 = Directory.GetCurrentDirectory();
            //var str4 = AppDomain.CurrentDomain.BaseDirectory;
            //var str5 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            //SerializeTest.SerializeNow();

            var res = SerializeTest.DeserializeNow();

            //XmlTest.XmlSerialize();

            //var res=XmlTest.XmlDeserialize();
            var s = res.Birthday;
            var t = res.Chinese[0].Quilty;
        }
    }
}
