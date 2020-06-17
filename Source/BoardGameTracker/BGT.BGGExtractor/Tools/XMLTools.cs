using System.IO;
using System.Xml.Serialization;

namespace BGT.BGG.Extractor
{
    internal class XMLTools
    {
        public static T DeSerializeSearch<T>(string msg)
        {
            var serializer = new XmlSerializer(typeof(T));
            var rdr = new StringReader(msg);
            return (T)serializer.Deserialize(rdr);
        }
    }
}