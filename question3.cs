using System;
using System.IO;
using System.Xml.Serialization;

namespace XML
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }

        public override string ToString()
        {
            return string.Format($"The name: {Name} from {Address} is available at {Phone}");
        }
    }
    class SerializationXML
    {
        static void Main(string[] args)
        {
            xmlExample();
        }

        private static void xmlExample()
        {
            Console.WriteLine("What do You want to do today: Read or Write (R/W)");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "r")
                deserializingXml();
            else
                serializingXml();
        }

        private static void deserializingXml()
        {
            try
            {
                XmlSerializer sl = new XmlSerializer(typeof(Student));
                FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
                Student s = (Student)sl.Deserialize(fs);
                Console.WriteLine(s);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void serializingXml()
        {
            Student s = new Student();
            Console.WriteLine("Enter the name");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            s.Address = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            s.Phone = long.Parse(Console.ReadLine());
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sl = new XmlSerializer(typeof(Student));
            sl.Serialize(fs, s);
            fs.Flush();
            fs.Close();
        }
    }
}
