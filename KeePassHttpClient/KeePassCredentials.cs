namespace KeePassHttpClient
{
    public class KeePassCredential
    {
        public KeePassCredential(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}
