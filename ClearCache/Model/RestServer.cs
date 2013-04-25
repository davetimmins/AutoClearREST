using System;
using System.IO;
using System.Xml.Serialization;

namespace ClearCache.Model
{
    /// <summary>
    /// Provides a model for the data required to work against the server clear admin endpoint
    /// </summary>
    [XmlRootAttribute("RestServer", Namespace = "", IsNullable = false)]
    public class RestServer
    {
        public const string FileExtension = ".restclearconfig";
        private const string Endpoint = "{0}://{1}/{2}/rest/admin/cache/clear?token={3}&f=json";

        public RestServer()
            : this(string.Empty, Scheme.Http, string.Empty, "arcgis", string.Empty)
        {
        }

        public RestServer(string name, Scheme scheme, string host, string instance, string token)
        {
            Name = name;
            Scheme = scheme;            
            Host = host;
            Instance = instance;
            Token = token;
        }

        /// <summary>
        /// The human readable description of the <c>RestServer</c> configuration
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Scheme used to access the REST endpoint
        /// </summary>
        public Scheme Scheme { get; set; }
                
        /// <summary>
        /// The name or IP address of the host
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The name of the instance, default is arcgis
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// The token value as generated from the REST admin page
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// REST endpoint to the clear cache operation
        /// </summary>
        [XmlIgnore]
        public string ClearEndpoint
        {
            get { return string.Format(Endpoint, Scheme, Host, Instance, Token); }
        }

        /// <summary>
        /// The file path used for the config file
        /// </summary>
        [XmlIgnore]
        public string FilePath
        {
            get
            {
                var directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(directory, string.Format("{0}{1}", Host, FileExtension));
            }
        }

        /// <summary>
        /// Deletes the configuration file if present
        /// </summary>
        public void Delete()
        {
            var fileInfo = new FileInfo(FilePath);
            if (fileInfo.Exists)
                fileInfo.Delete();
        }
    }

    public enum Scheme
    {
        Http,
        Https
    }
}
