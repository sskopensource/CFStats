using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    class UserContestsControl
    {
        public static UserContestsModel LoadUserContests(string handle)
        {
            string url = "https://codeforces.com/api/user.rating?handle=" + handle;

            using (var httpClient = new HttpClient())
            {
                var json = httpClient.GetStringAsync(url);
                UserContestsModel info = JsonConvert.DeserializeObject<UserContestsModel>(json.Result);
                return info;
            }
        }
    }
}
