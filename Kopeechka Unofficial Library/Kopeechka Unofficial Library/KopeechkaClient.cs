namespace Kopeechka_Unofficial_Library
{
    public class KopeechkaClient
    {
        public string Api_Key { get; set; }

        public KopeechkaHttpClient HttpClient { get; private set; }

        public KopeechkaClient(string api_key)
        {
            HttpClient = new KopeechkaHttpClient(this);
            Api_Key = api_key;
        }
    }
}
