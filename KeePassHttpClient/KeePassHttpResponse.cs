using System.Collections.Generic;

namespace KeePassHttpClient
{
    public class KeePassHttpResponse
    {
        public string RequestType { get; set; }
        public string Error { get; set; }
        public bool Success { get; set; }
        public string Id { get; set; }
        public int Count { get; set; }
        public string Version { get; set; }
        public string Hash { get; set; }
        public List<KeePassHttpResponseEntry> Entries { get; set; }
        public string Nonce { get; set; }
        public string Verifier { get; set; }
    }
}