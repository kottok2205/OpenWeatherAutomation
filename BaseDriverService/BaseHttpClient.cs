namespace BaseDriverService
{
    public class BaseHttpClient
    {
        private static HttpClient client;

        private BaseHttpClient() { }

        public static HttpClient GetInstance()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
            return client;
        }
        public static void QuitInstance()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }
    }
}
