using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

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
                var httpClientHandler = new HttpClientHandler();
                httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                client = new HttpClient(httpClientHandler) { BaseAddress = new Uri("https://openweathermap.org/") };
                
                System.Net.ServicePointManager.SecurityProtocol =  SecurityProtocolType.Tls;
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
