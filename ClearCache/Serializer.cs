using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ClearCache.Model;

namespace ClearCache
{
    /// <summary>
    /// Helper class for serializing the <c>RestServer</c> to an xml file
    /// </summary>
    internal static class Serializer
    {
        internal static void SerializeRestServer(RestServer restServer)
        {
            var path = restServer.FilePath;

            restServer.Delete();

            var serializer = new XmlSerializer(typeof(RestServer));

            using (var stream = File.Open(path, FileMode.Create))
            {
                serializer.Serialize(stream, restServer);
                stream.Close();
            }
        }

        internal static List<RestServer> DeSerializeRestServers()
        {
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var directoryInfo = new DirectoryInfo(directory);
            var configFiles = directoryInfo.GetFiles(string.Format("*{0}", RestServer.FileExtension), SearchOption.TopDirectoryOnly);
            
            return configFiles.Select(configFile => DeSerializeRestServer(configFile.FullName)).ToList();
        }

        private static RestServer DeSerializeRestServer(string filename)
        {
            var serializer = new XmlSerializer(typeof(RestServer));

            using (var stream = File.Open(filename, FileMode.Open))
            {
                var restServer = (RestServer)serializer.Deserialize(stream);
                stream.Close();
                return restServer;
            }
        }
    }
}
