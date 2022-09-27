using Kopeechka_Unofficial_Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopeechka_Unofficial_Library
{
    public static class user_balance
    {
        public static async Task<JSON> GetBalance(this KopeechkaClient client)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.SendGetBalanceReqeust("user-balance");
                return JsonConvert.DeserializeObject<JSON>(await result.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
