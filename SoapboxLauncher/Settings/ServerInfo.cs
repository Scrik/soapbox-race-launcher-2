using System;
using System.Xml.Serialization;

namespace SoapboxLauncher.Settings
{
    [Serializable()]
    [XmlRoot("Server")]
    public class ServerInfo
    {
        [XmlElement("IP")]
        public String ip;
        [XmlElement("Port")]
        public Int32 port;
    }
}
