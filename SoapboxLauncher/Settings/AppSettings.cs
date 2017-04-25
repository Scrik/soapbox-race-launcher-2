using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoapboxLauncher.Settings
{
    [Serializable()]
    [XmlRoot("LauncherSettings")]
    public class AppSettings
    {
        [XmlArray("Servers")]
        [XmlArrayItem("Server")]
        public List<ServerInfo> servers;

        public AppSettings()
        {
            servers = new List<ServerInfo>();
        }
    }
}
