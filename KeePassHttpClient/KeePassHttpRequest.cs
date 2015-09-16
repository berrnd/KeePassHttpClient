namespace KeePassHttpClient
{
    public class KeePassHttpRequest
    {
        public string RequestType { get; set; }
        public string SortSelection { get; set; }
        public string TriggerUnlock { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Uuid { get; set; }
        public string Url { get; set; }
        public string SubmitUrl { get; set; }
        public string Key { get; set; }
        public string Id { get; set; }
        public string Verifier { get; set; }
        public string Nonce { get; set; }
        public string Realm { get; set; }
        public string SearchString { get; set; }
    }
}