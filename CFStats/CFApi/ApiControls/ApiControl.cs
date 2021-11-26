using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public static class ApiControl
    {
        private static UserInfoModel _userInfo;
        private static UserBlogEntryModel _userBlog;
        private static UserStatusModel _userStatus;

        public static void LoadApi(string handle)
        {
            Console.WriteLine("Called: ApiControl");
            UserInfo = UserInfoControl.LoadUserInfo(handle);
            UserStatus = UserStatusControl.LoadUserStatus(handle);
            UserBlog = UserBlogEntryControl.LoadUserBlogStatus(handle);
        }

        public static UserInfoModel UserInfo
        {
            get
            {
                return _userInfo;
            }
            set
            {
                _userInfo = value;
            }
        }
        public static UserStatusModel UserStatus
        {
            get
            {
                return _userStatus;
            }
            set
            {
                _userStatus = value;
            }
        }

        public static UserBlogEntryModel UserBlog
        {
            get
            {
                return _userBlog;
            }
            set
            {
                _userBlog = value;
            }
        }
        
    }
}
