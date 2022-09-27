﻿using Kopeechka_Unofficial_Library.Models;
using Newtonsoft.Json;
namespace Kopeechka_Unofficial_Library
{
    public static class mailbox_get_email
    {
        public static async Task<JSON> GenerateEmail(this KopeechkaClient client, string site, string mail_type, string sender, string regex, string soft, string investor, string subject, string clear)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.SendMailRequest("mailbox-get-email", site, mail_type, sender, soft, regex, investor, subject , clear);
                return JsonConvert.DeserializeObject<JSON>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
