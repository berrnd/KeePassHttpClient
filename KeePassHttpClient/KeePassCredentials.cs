using System.Collections.Generic;

namespace KeePassHttpClient
{
    public class KeePassCredential
    {
        public KeePassCredential(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public KeePassCredential(string username, string password, string uuid, string name)
        {
            this.Username = username;
            this.Password = password;
            this.Uuid = uuid;
            this.Name = name;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Uuid { get; private set; }
        public string Name { get; private set; }
        public List<KeePassHttpResponseStringField> StringFields { get; set; } = new List<KeePassHttpResponseStringField>();
    }
}
