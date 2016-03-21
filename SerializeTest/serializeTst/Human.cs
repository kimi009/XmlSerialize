using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializeTst
{
    [Serializable]
    public class Human
    {
        public Human() { }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        [XmlIgnore]
        public DateTime Birthday { get; set; }
        [XmlElement("Birthday")]
        public String BirthdayTemp
        {
            get
            {
                return Birthday.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Birthday = DateTime.Today;
                }
                else
                {
                    Birthday = DateTime.Parse(value);
                }
            }
        }

        public List<Food> Chinese { get; set; }

        public List<AiHao> American { get; set; }
    }
    [Serializable]
    public class Food
    {
        public Food() { }
        public string Apple { get; set; }
        public int Price { get; set; }
        [XmlIgnore]
        public decimal Quilty { get; set; }
        [XmlElement("Quilty")]
        public string QuiltyTemp
        {
            get {  
                return Quilty.ToString("n"); 
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Quilty = 0m;
                }
                else
                {
                    Quilty = decimal.Parse(value);
                }
            }
        }
    }
    [Serializable]
    public class AiHao
    {
        public AiHao() { }
        public string HuNei { get; set; }
        public string HuWai { get; set; }
    }
}
