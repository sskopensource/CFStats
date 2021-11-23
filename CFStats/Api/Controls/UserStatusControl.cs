using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserStatusControl
    {
        public static async Task<UserStatusModel> LoadUserStatus(string handle="tourist")
        {
            string url = "https://codeforces.com/api/user.status?handle=";
            url += handle;
            Console.WriteLine(handle);

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    UserStatusModel userModel = await response.Content.ReadAsAsync<UserStatusModel>();
                    return userModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
