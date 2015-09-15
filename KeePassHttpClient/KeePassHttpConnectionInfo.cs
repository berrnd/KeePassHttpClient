namespace KeePassHttpClient
{
    public class KeePassHttpConnectionInfo
    {
        public KeePassHttpConnectionInfo() { }

        public KeePassHttpConnectionInfo(string host, int port, string id, byte[] key)
        {
            this.Host = host;
            this.Port = port;
            this.Id = id;
            this.Key = key;
        }

        public string Host { get; set; }
        public int Port { get; set; }
        public string Id { get; set; }
        public byte[] Key { get; set; }
    }
}
