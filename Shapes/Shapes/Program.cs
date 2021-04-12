using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>
            {
                new Circle { Colour = "Red", Radius = 2.5 },
                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Colour = "Green", Radius = 8 },
                new Circle { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
            };

            ToXml(listOfShapes, "listOfShapes.xml");

            List<Shape> loadedShapesXml = FromXml<List<Shape>>("listOfShapes.xml");

            Console.WriteLine("Loading shapes from XML:\n");

            foreach (var item in loadedShapesXml)
            {
                Console.WriteLine($"{item.Name} is {item.Colour} and has an area of {item.Area}");
            }

            Console.WriteLine("\nHave a nice day!");
        }

        public static void ToXml<T>(T obj, string path)
        {
            using (StringWriter sw = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, obj);
                File.WriteAllText(path, sw.ToString());
            }
        }

        public static T FromXml<T>(string path)
        {
            string xmlString = File.ReadAllText(path);
            using (StringReader sr = new StringReader(xmlString))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sr);
            }
        }
    }
}