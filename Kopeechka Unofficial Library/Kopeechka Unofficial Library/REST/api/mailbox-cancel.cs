using Kopeechka_Unofficial_Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopeechka_Unofficial_Library
{
    public static class mailbox_cancel
    {
        public static async Task<JSON> GenerateEmail(this KopeechkaClient client, string site, string mail_type, string sender, string regex, string soft, string investor, string subject, string clear)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.SendMailRequest("mailbox-get-email", site, mail_type, sender, soft, regex, investor, subject, clear);
                return JsonConvert.DeserializeObject<JSON>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
