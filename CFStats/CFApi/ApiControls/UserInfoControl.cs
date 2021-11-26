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
                UserInfoModel info = JsonConvert.DeserializeObject<UserInfoModel>(json.Result);
                return info;
            }
        }
    }
}
