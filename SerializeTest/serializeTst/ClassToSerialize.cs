using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializeTst
{
    public static class SerializeTest
    {
        public static void SerializeNow()
        {
            //Human c = new Human()
            //{
            //    Name = "kimi",
            //    Age = 24,
            //    Sex = "male",
            //    Birthday = new DateTime().ToLocalTime(),
            //    Chinese = new List<Food>{
            //        new Food{Apple="apple",Price=3,Quilty=(decimal)9.99},
            //    },
            //    American = new List<AiHao>{
            //        new AiHao{HuNei="qi",HuWai="py"},
            //        new AiHao{HuNei="rr",HuWai="rew"},
            //    }
            //};
            //FileStream fileStream = new FileStream(@"E:\C#2016\XmlSerialize\SerializeTest\serializeTst\4.xml", FileMode.Create);
            //BinaryFormatter binaryFormat = new BinaryFormatter();
            //binaryFormat.Serialize(fileStream, c);
            //fileStream.Close();
        }
        public static Human DeserializeNow()
        {
            FileStream filestream = new FileStream(@"E:\C#2016\XmlSerialize\SerializeTest\serializeTst\1.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            //BinaryFormatter b = new BinaryFormatter();
            //c = b.Deserialize(filestream) as Human;
            XmlSerializer xmlformat = new XmlSerializer(typeof(Human));
            var res =(Human) xmlformat.Deserialize(filestream);
            filestream.Close();
            return res;
        }
        
    }
}
