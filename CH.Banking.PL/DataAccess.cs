using System.Xml.Serialization;

namespace CH.Banking.PL
{
    public static class DataAccess
    {
        public static string XMLFilePath { get; set; } = "";

        //writes the data to the XML File
        public static void SaveXML (Type type, object obj)
        {
            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }
        //reads the data on the XML file
        public static object LoadXML(Type type)
        {
            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}