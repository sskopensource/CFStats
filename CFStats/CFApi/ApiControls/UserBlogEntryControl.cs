using Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserBlogEntryControl
    {
        public static UserBlogEntryModel LoadUserBlogStatus(string handle)
        {
            string url = "https://codeforces.com/api/user.blogEntries?handle="+handle;

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var json = httpClient.GetStringAsync(url);
                    UserBlogEntryModel info = JsonConvert.DeserializeObject<UserBlogEntryModel>(json.Result);
                    return info;
                }
            }
            catch
            {
                return new UserBlogEntryModel() { status="Failed"};
            }
           
        }
    }
}
