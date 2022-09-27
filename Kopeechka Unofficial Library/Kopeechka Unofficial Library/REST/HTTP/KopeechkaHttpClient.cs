using Kopeechka_Unofficial_Library.Models;
using System.Net;

namespace Kopeechka_Unofficial_Library
{
    public class KopeechkaHttpClient
    {
        private readonly KopeechkaClient _KopeechkaClient;

        public KopeechkaHttpClient(KopeechkaClient KopeechkaClient)
        {
            _KopeechkaClient = KopeechkaClient;
        }

        public async Task<HttpResponseMessage> SendMailRequest(string endpoint, string site, string mail_type, string sender, string regex, string soft , string investor, string subject, string clear)
        {
            using var webClient = new HttpClient();

            try
            {
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                HttpResponseMessage response = await webClient.GetAsync("http://api.kopeechka.store/" + endpoint + "site=" + site + "&mail_type=" + mail_type + "&sender=" + sender + "&regex=" + regex + "&token=" + _KopeechkaClient.Api_Key + "&soft=" + soft + "&investor=" + investor + "&type=JSON&subject=" + subject + "&clear="+ clear + "&api=2.0");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public async Task<HttpResponseMessage> SendCancelMailRequest(string endpoint, int id)
        {
            using var webClient = new HttpClient();

            try
            {
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                HttpResponseMessage response = await webClient.GetAsync("http://api.kopeechka.store/" + endpoint + "?id=" + id + "&token="  + _KopeechkaClient.Api_Key + "&type=JSON&api=2.0");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public async Task<HttpResponseMessage> SendGetBalanceReqeust(string endpoint)
        {
            using var webClient = new HttpClient();

            try
            {
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                HttpResponseMessage response = await webClient.GetAsync("http://api.kopeechka.store/" + endpoint + "&token=" + _KopeechkaClient.Api_Key + "&type=JSON&api=2.0");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public async Task<HttpResponseMessage> SendGetMessageOfMailRequest(string endpoint,string full,  int id)
        {
            using var webClient = new HttpClient();

            try
            {
                webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                HttpResponseMessage response = await webClient.GetAsync("http://api.kopeechka.store/" + endpoint + "?full=" + full + "?id=" + id + "&token=" + _KopeechkaClient.Api_Key + "&type=JSON&api=2.0");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
