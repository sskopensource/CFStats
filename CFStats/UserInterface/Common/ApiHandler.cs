using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    enum SetSelector{
        PROBLEMSET,
        CONTESTSET,
        BLOGSET
    }
    
    public static class ApiHandler
    {
        private static HashSet<string> contestSet = new HashSet<string>();
        private static HashSet<string> problemSet = new HashSet<string>();
        private static HashSet<string> blogSet = new HashSet<string>();
       
        public static void LoadApiControl(string handle)
        {
            Console.WriteLine("Called: ApiHandler");
            ApiControl.LoadApi(handle);
        }

        public static string maxRating
        {
            get
            {
                return ApiControl.UserInfo.result[0].maxRating;
            }
        }

        public static string Contests
        {
            get
            {
                return SetCount(SetSelector.CONTESTSET);
            }
        }

        public static string Contributions
        {
            get
            {
                return ApiControl.UserInfo.result[0].contribution;
            }
        }

        public static string ProblemsSolved
        {
            get
            {
                return SetCount(SetSelector.PROBLEMSET);
            }
        }

        public static string FriendsOf
        {
            get
            {
                return ApiControl.UserInfo.result[0].friendOfCount;
            }
        }

        public static string Blogs
        {
            get
            {
                return SetCount(SetSelector.BLOGSET);
            }
        }

        public static string Name
        {
            get
            {
                return GetFullName();  
            }
        }

        public static string Rating
        {
            get
            {
                return ApiControl.UserInfo.result[0].rating;
            }
        }

        public static string Rank
        {
            get
            {
                return ApiControl.UserInfo.result[0].rank;
            }
        }

        public static string Organization
        {
            get
            {
                return ApiControl.UserInfo.result[0].organization;
            }
        }

        public static string Country
        {
            get
            {
                return ApiControl.UserInfo.result[0].country;
            }
        }

        public static string Handle
        {
            get
            {
                return ApiControl.UserInfo.result[0].handle;
            }
        }

        public static string ProfilePicture
        {
            get
            {
                return ApiControl.UserInfo.result[0].titlePhoto;
            }
        }


        private static string SetCount(SetSelector setSelector)
        {
            if (problemSet.Count == 0)
            {
                FillSets();
            }
            string res="";
            if (setSelector == SetSelector.PROBLEMSET)
            {
                res = problemSet.Count.ToString();
            }
            if (setSelector == SetSelector.CONTESTSET)
            {
                res = contestSet.Count.ToString();
            }
            if (setSelector == SetSelector.BLOGSET)
            {
                res = blogSet.Count.ToString();
            }
            return res;
        }

        private static void FillSets()
        {
            Console.WriteLine("FillSetCalled");

            //Fill ProblemSet and ContestSet
            foreach (var problems in ApiControl.UserStatus.result)
            {
                var currentProblem = problems.problem.name.ToString();
                var currentContest = problems.contestId.ToString();
                var curVerdict = problems.verdict.ToString();
                var curParticipantType = problems.author.participantType.ToString();
                if (curVerdict == "OK")
                {
                    problemSet.Add(currentProblem);
                }
                if (curParticipantType == "CONTESTANT")
                {
                    contestSet.Add(currentContest);
                }

            }

            //Fill BlogSet
            foreach (var blogs in ApiControl.UserBlog.result)
            {
                var currentBlog = blogs.title.ToString();
                blogSet.Add(currentBlog);
            }
        }

        private static string GetFullName()
        {
            string fullName= ApiControl.UserInfo.result[0].firstName + " " + ApiControl.UserInfo.result[0].lastName;
            return fullName;
        }

    }
}
