using System.Collections.Generic;

namespace KeePassHttpClient
{
    public class KeePassHttpResponseEntry
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public List<KeePassHttpResponseStringField> StringFields { get; set; }
    }
}