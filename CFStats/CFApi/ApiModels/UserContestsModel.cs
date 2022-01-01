using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserContestsModel
    {
        
        public string status { get; set; }
         public UserContestsListModel [] result { get; set; }
    }

    public class UserContestsListModel
    {
        public string contestId { get; set; }
        public string contestName { get; set; }
        public string handle { get; set; }
        public string rank { get; set; }
        public string ratingUpdateTimeSeconds { get; set; }
        public string oldRating { get; set; }
        public string newRating { get; set; }
    

    }
}
