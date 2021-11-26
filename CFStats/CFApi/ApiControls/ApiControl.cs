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
        public UserStatusModel userStatus { get; set; }
        public UserBlogEntryModel userBlog { get; set; }
        public ApiControl()
        {
            userInfo = UserInfoControl.LoadUserInfo();
            userStatus = UserStatusControl.LoadUserStatus();
            userBlog = UserBlogEntryControl.LoadUserBlogStatus();
            
        }
    }
}
