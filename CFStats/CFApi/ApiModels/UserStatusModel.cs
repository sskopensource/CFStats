using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class UserStatusModel
    {
        public string status { get; set; }
        public UserStatusListModel[] result { get; set; }
    }
    public class UserStatusListModel
    {
        public int contestId { get; set; }
        public ProblemModel problem { get; set; }
        public string verdict { get; set; }
        public AuthorModel author { get; set; }
    }
    public class ProblemModel
    {
        public string name { get; set; }
    }
    public class AuthorModel
    {
        public string participantType { get; set; }
    }
}
