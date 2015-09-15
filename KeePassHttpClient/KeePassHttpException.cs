using System;

namespace KeePassHttpClient
{
    public class KeePassHttpException : Exception
    {
        public KeePassHttpException() {}
        public KeePassHttpException(string message) : base(message) {}
        public KeePassHttpException(string message, Exception innerException) : base(message, innerException) {}
    }
}