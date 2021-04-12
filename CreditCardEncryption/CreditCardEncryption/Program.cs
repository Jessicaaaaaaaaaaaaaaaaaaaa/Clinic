using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CreditCardEncryption
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Bob Smith", CreditCard = "1234-5678-9012-3456", 
                    Password = "Pa$$w0rd" },
                new Customer { Name = "Lucy Johnson", CreditCard = "5252-5678-7845-3456", 
                    Password = "123456" },
            };

            string key = Cripto.Cripto.GenerateSecretString();

            foreach (var item in customers)
            {
                item.CreditCard =
                    Cripto.Cripto.EncryptString(key, item.CreditCard);
                item.Password =
                    Cripto.Cripto.SaltAndHash(item.Password);
            }

            ToXml(customers, "customers.xml");

            var customersFromXml = FromXml<List<Customer>>("customers.xml");

            foreach (var item in customersFromXml)
            {
                var ccn = Cripto.Cripto.DecryptString(key, item.CreditCard);
                Console.WriteLine($"{item.Name} { ccn } {item.Password}");
            }

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
