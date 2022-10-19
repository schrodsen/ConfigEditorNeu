using System.IO;
using ConfigEditor.Model.Contracts;

namespace ConfigEditor.Bl.Services
{
    public class XmlService : IXmlService
    {
        public T ReadXml<T>(string fullFileName)
        {
            var fi = new FileInfo(fullFileName);
            if (fi.Exists == false)
            {
                throw new FileNotFoundException();
            }

            using (var fileStream = fi.OpenRead())
            {
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(fileStream);
            }
        }

        public void WriteXml<T>(string fullFileName, T dataObject)
        {
            using (var fileStream = File.OpenWrite(fullFileName))
            {
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                xmlSerializer.Serialize(fileStream, dataObject);
            }
        }
    }
}
