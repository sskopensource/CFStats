using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class ApiControl
    {
        public UserInfoModel userInfo { get; set; }
        public string maxRating { get; set; }
        public ApiControl()
        {
            userInfo = UserInfoControl.LoadUserInfo();
            maxRating = userInfo.result[0].maxRating;
        }
    }
}
