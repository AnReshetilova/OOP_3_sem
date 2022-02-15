using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace lab14
{
    static class CustomSerializer<T>
    {
        public static void Serialize(T obj, int serializationType)
        {
            switch(serializationType)
            {
                case 1:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream("object.dat", FileMode.Create))
                    {
                        formatter.Serialize(fs, obj);
                    }
                    break;
      
                case 2:
                    {
                        XmlSerializer xSer = new XmlSerializer(typeof(T));
                        using (FileStream fs = new FileStream("object.xml", FileMode.Create))
                        {
                            xSer.Serialize(fs, obj);
                        }
                        break;
                    }
                case 3:
                    {
                        using (var fs = new StreamWriter("object.json"))
                        {
                            fs.Write(JsonSerializer.Serialize(obj));
                        }
                        break;
                    }
            }
        }

        public static void Desirialize(out object obj, int serializationType)
        {
            switch (serializationType)
            {
                case 1:
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream("object.dat", FileMode.Open))
                        {
                            obj = formatter.Deserialize(fs);
                        }
                        break;
                    }
                case 2:
                    {
                        XmlSerializer xSer = new XmlSerializer(typeof(T));
                        using (FileStream fs = new FileStream("object.xml", FileMode.Open))
                        {
                            obj = xSer.Deserialize(fs);
                        }

                        break;
                    }
                case 3:
                    {
                        using (var fs = new StreamReader("object.json"))
                        {
                            obj = JsonSerializer.Deserialize<T>(fs.ReadToEnd());
                        }

                        break;
                    }
                default:
                    {
                        obj = null;
                        break;
                    }
            }
        }
    }
}
