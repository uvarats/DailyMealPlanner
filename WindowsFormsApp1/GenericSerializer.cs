using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    class GenericSerializer<T>
    {
        private static XmlSerializer serializer;
        static GenericSerializer()
        {
            serializer = new XmlSerializer(typeof(T));
        }
        public static T Deserialize(string fileName)
        {
            XmlReaderSettings readerSettings = new XmlReaderSettings();
            T var;
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                var = (T) serializer.Deserialize(reader);
            }
            return var;
        }

        public static void Serialize(T var, string fileName)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings { Indent = true };
            Console.WriteLine();
            using (XmlWriter writer = XmlWriter.Create(fileName, writerSettings))
            {
                serializer.Serialize(writer, var);
            }
        }
    }
}
