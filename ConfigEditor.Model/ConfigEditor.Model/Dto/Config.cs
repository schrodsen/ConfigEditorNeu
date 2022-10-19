using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConfigEditor.Model.Dto
{
    public class Config
    {
        [XmlElement]
        public List<Server> Servers { get; set; }

        [XmlElement]
        public List<Client> Clients { get; set; }
    }

    public class Server
    {
        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlElement]
        public string ConnectionString { get; set; }
    }

    public class Client
    {
        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlElement]
        public bool TSClient { get; set; }

    }
}
