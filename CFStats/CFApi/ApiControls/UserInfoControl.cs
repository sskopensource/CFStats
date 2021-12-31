using Newtonsoft.Json;
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
        public static UserInfoModel LoadUserInfo(string handle)
        {
            string url = "https://codeforces.com/api/user.info?handles="+handle;
            
            using (var httpClient = new HttpClient())
            {

                var json = httpClient.GetStringAsync(url);

                UserInfoModel info = Deserialize(json);

                if (json.Status==TaskStatus.Faulted &&  json.Exception.InnerException.Message == "An error occurred while sending the request.")
                {
                    return null;
                }

                return info;
            }
        }


        public static UserInfoModel Deserialize(Task<string> json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserInfoModel>(json.Result);

            }
            catch
            {
                return new UserInfoModel() { status = "Failed" };
            }
        }
    }
}
