using Newtonsoft.Json;
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
        public static UserStatusModel LoadUserStatus(string handle)
        {
            string url = "https://codeforces.com/api/user.status?handle="+handle;

            try
            {

                using (var httpClient = new HttpClient())
                {
                    var json = httpClient.GetStringAsync(url);
                    UserStatusModel info = JsonConvert.DeserializeObject<UserStatusModel>(json.Result);
                    return info;
                }
            }
            catch
            {
                return new UserStatusModel() { status="Failed"};
            }
           
        }
    }
}
