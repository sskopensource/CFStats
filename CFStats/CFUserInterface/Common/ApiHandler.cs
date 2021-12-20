using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{    
    public static class ApiHandler
    {
        private static HashSet<string> contestSet = new HashSet<string>();
        private static HashSet<string> solvedProblemSet = new HashSet<string>();
        private static HashSet<string> problemSet = new HashSet<string>();
        private static HashSet<string> blogSet = new HashSet<string>();
        private static SortedDictionary<int,int> problemsRatingMap = new SortedDictionary<int,int>();
        private static SortedDictionary<string, int> tagsMap = new SortedDictionary<string, int>();
        private static SortedDictionary<string, int> verdictMap = new SortedDictionary<string, int>();
        private static SortedDictionary<string, ProblemModel> problemMap = new SortedDictionary<string, ProblemModel>();



        public static void LoadApiControl(string handle)
        {
            ApiControl.LoadApi(handle);
            ClearSets();
            FillSets();
        }

        //----------------------------Getters----------------------------------//
   
        public static string maxRating => ApiControl.userInfo.result[0].maxRating;
        public static string Contests => contestSet.Count.ToString();
        public static string ProblemTried => problemSet.Count.ToString();
        public static string Contributions => ApiControl.userInfo.result[0].contribution;
        public static string ProblemsSolved => solvedProblemSet.Count.ToString();
        public static string FriendsOf => ApiControl.userInfo.result[0].friendOfCount;
        public static string Blogs => blogSet.Count.ToString();
        public static string Name => GetFullName();
        public static string Rating => ApiControl.userInfo.result[0].rating;
        public static string Rank => ApiControl.userInfo.result[0].rank;
        public static string Organization=> ApiControl.userInfo.result[0].organization;
        public static string Country => ApiControl.userInfo.result[0].country;
        public static string Handle => ApiControl.userInfo.result[0].handle;
        public static string ProfilePicture=> ApiControl.userInfo.result[0].titlePhoto;
        public static string Avatar => ApiControl.userInfo.result[0].avatar;
        public static string ProblemsUnsolved => GetProblemMapData(DataSelector.UNSOLVED).ToString();
        public static string SolvedFirstAttempt => GetProblemMapData(DataSelector.SOLVEDINONEATTEMPT).ToString();
        public static string AverageAttempt => GetProblemMapData(DataSelector.AVERAGEATTEMPT).ToString().Substring(0,4);
        public static string FavouriteTag => TagData(DataSelector.FAVOURITETAG);
        public static string ProblemsTried => solvedProblemSet.Count.ToString();
        public static SortedDictionary<int, int> ProblemsRatingMap => problemsRatingMap;
        public static SortedDictionary<string, int> TagsMap => tagsMap;
        public static SortedDictionary<string, int> VerdictMap => verdictMap;

        //Fill ProblemSet ,ContestSet and ProblemratingMap
        private static void FillSets()
        {
            foreach (var problems in ApiControl.userStatus.result)
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
                problemSet.Add(currentProblem);

                if (!problemMap.ContainsKey(currentProblem))
                {
                    problemMap.Add(currentProblem, new ProblemModel() { wrongAttempts=0 , correctAttempts=0 });
                }
                if (curVerdict=="OK")
                {
                    problemMap[currentProblem].correctAttempts++;
                }
                else
                {
                    problemMap[currentProblem].wrongAttempts++;
                }

                if (curVerdict == "OK")
                {
                    solvedProblemSet.Add(currentProblem);

                    if (curProblemRating !=0)
                    {
                        if (!problemsRatingMap.ContainsKey(curProblemRating))
                        {
                            problemsRatingMap.Add(curProblemRating, 0);
                        }
                        problemsRatingMap[curProblemRating]++;
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
            foreach (var blogs in ApiControl.userBlog.result)
            {
                var currentBlog = blogs.title.ToString();
                blogSet.Add(currentBlog);
            }

            verdictMap.Remove("SKIPPED");
        }


        public static string TagData(DataSelector dataSelector)
        {
            string res = "";
            int maxm = 0;
            string fav = "";
            foreach(var i in tagsMap)
            {
                if (i.Value > maxm)
                {
                    maxm = i.Value;
                    fav = i.Key;
                }
            }

            if(dataSelector== DataSelector.FAVOURITETAG)
            {
                res = fav;
            }

            return res;
        }

        private static void ClearSets()
        {
            solvedProblemSet.Clear();
            contestSet.Clear();
            blogSet.Clear();
            problemsRatingMap.Clear();
            tagsMap.Clear();
            verdictMap.Clear();
        }

        private static string GetFullName()
        {
            string fullName= ApiControl.userInfo.result[0].firstName + " " + ApiControl.userInfo.result[0].lastName;
            return fullName;
        }

        private static double GetProblemMapData(DataSelector dataSelector)
        {
            double averageAttempts=0;
            int unsolved=0;
            double solvedInOneAttempt=0;
            int solved=0;
            foreach(var i in problemMap)
            {
                if (i.Value.correctAttempts != 0)
                {
                    if (i.Value.wrongAttempts == 0)
                    {
                        solvedInOneAttempt++;

                    }

                    averageAttempts += (double)(1 / (i.Value.wrongAttempts + i.Value.correctAttempts));
                    solved++;
                }
                else
                {
                    unsolved++;
                }
            }
            averageAttempts = (double)solved/ averageAttempts;

            if (dataSelector == DataSelector.SOLVEDINONEATTEMPT) return solvedInOneAttempt;
            if (dataSelector==DataSelector.UNSOLVED) return unsolved;
            if (dataSelector==DataSelector.AVERAGEATTEMPT) return averageAttempts;
            return 0;
        }

    }
}
