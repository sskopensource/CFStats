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
        private static SortedDictionary<int,int> probemsRatingMap = new SortedDictionary<int,int>();
        private static SortedDictionary<string, int> tagsMap = new SortedDictionary<string, int>();
        private static SortedDictionary<string, int> verdictMap = new SortedDictionary<string, int>();

        public static void LoadApiControl(string handle)
        {
            ApiControl.LoadApi(handle);
        }

        //----------------------------Getters----------------------------------//
   
        public static string maxRating => ApiControl.UserInfo.result[0].maxRating;
        public static string Contests => SetCount(SetSelector.CONTESTSET);
        public static string Contributions => ApiControl.UserInfo.result[0].contribution;
        public static string ProblemsSolved => SetCount(SetSelector.PROBLEMSET);
        public static string FriendsOf => ApiControl.UserInfo.result[0].friendOfCount;
        public static string Blogs => SetCount(SetSelector.BLOGSET);
        public static string Name => GetFullName();
        public static string Rating => ApiControl.UserInfo.result[0].rating;
        public static string Rank => ApiControl.UserInfo.result[0].rank;
        public static string Organization=> ApiControl.UserInfo.result[0].organization;
        public static string Country => ApiControl.UserInfo.result[0].country;
        public static string Handle => ApiControl.UserInfo.result[0].handle;
        public static string ProfilePicture=> ApiControl.UserInfo.result[0].titlePhoto;
        public static string Avatar => ApiControl.UserInfo.result[0].avatar;
        public static SortedDictionary<int, int> ProblemsRatingMap => probemsRatingMap;
        public static SortedDictionary<string, int> TagsMap => tagsMap;
        public static SortedDictionary<string, int> VerdictMap => verdictMap;

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

        //Fill ProblemSet ,ContestSet and ProblemratingMap
        private static void FillSets()
        {
            foreach (var problems in ApiControl.UserStatus.result)
            {
                var currentProblem = problems.problem.name.ToString();
                var currentContest = problems.contestId.ToString();
                var curVerdict = problems.verdict.ToString();
                
                var curProblemRating= problems.problem.rating;
                var curTags = problems.problem.tags;
                var curParticipantType = problems.author.participantType.ToString();

                if (!verdictMap.ContainsKey(curVerdict))
                {
                    verdictMap.Add(curVerdict, 0);
                }
                verdictMap[curVerdict]++;

                if (curVerdict == "OK")
                {
                    problemSet.Add(currentProblem);

                    if (curProblemRating !=0)
                    {
                        if (!probemsRatingMap.ContainsKey(curProblemRating))
                        {
                            probemsRatingMap.Add(curProblemRating, 0);
                        }
                        probemsRatingMap[curProblemRating]++;
                    }

                    foreach (var tag in curTags)
                    {
                        if (tag != null)
                        {
                            if (!tagsMap.ContainsKey(tag))
                            {
                                tagsMap.Add(tag, 0);
                            }
                            tagsMap[tag]++;
                        }   
                    }
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
