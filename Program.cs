/*using System;
using System.Xml;
using System.IO;

namespace AddingAndEditingXML_Files
{
    class Passport
    {
        public string Series { get; set; }
        public string Sex { get; set; }
        public string Name { get; set;}
        public string Surname { get; set; }
        public string Fathername { get; set; }
    }

    class Program
    {
        private static void ConvertToXml(Passport pass)
        {
            File.WriteAllText("Passport.xml", "");
            File.AppendAllText("Passport.xml","<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"<passport series=\" {pass.Series} \">" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"<sex> {pass.Sex} </sex>" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"<name> {pass.Name} </name>" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"<surname> {pass.Surname} </surname>" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"<fathername> {pass.Fathername} </fathername>" + Environment.NewLine);
            File.AppendAllText("Passport.xml", $"</passport>" + Environment.NewLine);
        }

        static void Main(string[] args)
        {
            Passport passport = new Passport();

            Console.Write("Enter series: ");
            passport.Series = Console.ReadLine();
            Console.Write("Enter Sex: ");
            passport.Sex = Console.ReadLine();
            Console.Write("Enter Name: ");
            passport.Name = Console.ReadLine();
            Console.Write("Enter Surname: ");
            passport.Surname = Console.ReadLine();
            Console.Write("Enter Fathername: ");
            passport.Fathername = Console.ReadLine();

            ConvertToXml(passport);
            XmlDocument pass = new XmlDocument();
            pass.Load("Passport.xml");
            XmlElement jorik = pass.DocumentElement;
            if (jorik.HasAttributes)
            {
                Console.WriteLine(jorik.Attributes.GetNamedItem("series").InnerText);
                foreach (XmlNode item in jorik.ChildNodes)
                {
                    Console.WriteLine(item.InnerText);
                }
            }
            Console.Read();
        }
    }
}*/

/*using System;
using System.Xml;
using System.IO;

namespace AddingAndEditingXML_Files
{
    class Program
    {
        private static void Edit(string toEdit)
        {
            int index = 0;
            string[] file = File.ReadAllLines("Passport.xml");
            foreach (string item in File.ReadAllLines("Passport.xml"))
            {
                string[] tmp = item.Split(' ');
                if (tmp.Length > 2)
                {
                    if (tmp[0] == $"<{toEdit}>")
                    {
                        tmp[1] = Console.ReadLine();
                        file[index] = item.Replace(item, String.Format("{0} {1} {2}", tmp[0], tmp[1], tmp[2]));
                    }
                }
                index++;
            }
            File.WriteAllText("Passport.xml", "");
            File.WriteAllLines("Passport.xml", file);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Sex: ");
            Edit("sex");
            Console.Write("Enter Name: ");
            Edit("name");
            Console.Write("Enter Surname: ");
            Edit("surname");
            Console.Write("Enter Fathername: ");
            Edit("fathername");

            XmlDocument pass = new XmlDocument();
            pass.Load("Passport.xml");
            XmlElement xmlelement = pass.DocumentElement;
            if (xmlelement.HasAttributes)
            {
                Console.WriteLine("Отредактирован пасспорт серии" + xmlelement.Attributes.GetNamedItem("series").InnerText + ":");
                foreach (XmlNode item in xmlelement.ChildNodes)
                {
                    Console.WriteLine(item.InnerText);
                }
            }
            Console.Read();
        }
    }
}*/