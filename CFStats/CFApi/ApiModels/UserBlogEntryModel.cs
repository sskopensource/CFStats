using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserBlogEntryModel
    {
        public string status { get; set; }
        public UserBlogEntryListModel[] result { get; set; }
    }
    public class UserBlogEntryListModel
    {
        public string title { get; set; }
    }
}
