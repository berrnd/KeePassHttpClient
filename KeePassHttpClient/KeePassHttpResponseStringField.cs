namespace KeePassHttpClient
{
    public class KeePassHttpResponseStringField
    {
        public KeePassHttpResponseStringField() { }

        public KeePassHttpResponseStringField(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}