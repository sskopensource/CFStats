using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
        public class UserInfoModel
        {
            public string status { get; set; }
            public UserInfoListModel[] result { get; set; }
        }
        public class UserInfoListModel
        {
            public string rating { get; set; }
            public string maxRating { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string titlePhoto { get; set; }
            public string avatar { get; set; }
            public string organisation { get; set; }
            public string handle { get; set; }
            public string country { get; set; }
            public string rank { get; set; }
            public string friendOfCount { get; set; }
            public string contribution { get; set; }
    }
}
