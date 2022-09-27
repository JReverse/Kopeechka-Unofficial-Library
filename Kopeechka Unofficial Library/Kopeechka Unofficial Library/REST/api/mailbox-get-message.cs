using Kopeechka_Unofficial_Library.Models;
using Newtonsoft.Json;

namespace Kopeechka_Unofficial_Library
{
    public static class mailbox_get_message
    {
        public static async Task<JSON> GetMessageOfMail(this KopeechkaClient client, string full, int id)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.SendGetBalanceReqeust("mailbox-get-message");
                return JsonConvert.DeserializeObject<JSON>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
