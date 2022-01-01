
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public static class ApiControl
    {
        public static UserInfoModel userInfo;
        public static UserBlogEntryModel userBlog;
        public static UserStatusModel userStatus;
        public static UserContestsModel userContests;

        public static void LoadApi(string handle)
        {
            userInfo = UserInfoControl.LoadUserInfo(handle);
            userStatus = UserStatusControl.LoadUserStatus(handle);
            userBlog = UserBlogEntryControl.LoadUserBlogStatus(handle);
            userContests = UserContestsControl.LoadUserContests(handle);
        }
    }
}
