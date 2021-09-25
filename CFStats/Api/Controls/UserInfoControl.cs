using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserInfoControl
    {
        public static async Task<UserInfoModel> LoadUserInfo(string handle)
        {
            string url = "https://codeforces.com/api/user.info?handles=";
            url += (handle);
            Console.WriteLine(handle);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("okhttpresponse");
                    UserInfoModel userModel = await response.Content.ReadAsAsync<UserInfoModel>();
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
