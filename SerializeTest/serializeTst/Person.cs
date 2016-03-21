using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializeTst
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public Person() { }
        public List<Course> Courses { get; set; }
    }
    [Serializable]
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Course() { }
    }
    public static class XmlTest
    {

        public static void XmlSerialize()
        {
            Person c = new Person() {Name="kimi" };
            c.Courses = new List<Course>();
            c.Courses[0] = new Course { Name = "英语", Description = "交流工具" };
            c.Courses[1] = new Course { Name = "数学", Description = "自然科学" };
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream stream = new FileStream(@"E:\C#2016\XmlSerialize\SerializeTest\serializeTst\cyj.XML", FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, c);
            stream.Close();
        }
        public static Person XmlDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream stream = new FileStream(@"E:\C#2016\XmlSerialize\SerializeTest\serializeTst\cyj.XML", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person p = xs.Deserialize(stream) as Person;
            stream.Close();
            return p;
        }
    }
}
