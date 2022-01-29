using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Common
{
    public static class UiUtility
    {
        public static ViewModelBase ConvertPageViewModelFromNAVTAB(NAVTAB currTab)
        {
            Dictionary<NAVTAB, ViewModelBase> navTabMap = new Dictionary<NAVTAB, ViewModelBase>()
            {
                {NAVTAB.OVERVIEW,new OverviewPageViewModel()},
                {NAVTAB.PROBLEM,new ProblemPageViewModel()},
                {NAVTAB.PROBLEM_ONE,new ProblemPageOneViewModel()},
                {NAVTAB.PROBLEM_TWO,new ProblemPageTwoViewModel()},
                {NAVTAB.CONTEST,new ContestPageViewModel()}
            };

            return navTabMap[currTab];
        }

        public static string ConvertColorFromRank(string rank)
        {
            Dictionary<string, string> map = new Dictionary<string, string>()
            {
                {"newbie","Gray"},
                {"pupil","Green"},
                {"specialist","Cyan"},
                {"expert","Blue"},
                {"candidate master","Purple"},
                {"master","Orange"},
                {"international master","Orange"},
                {"grandmaster","Red"},
                {"international grandmaster","Red"},
                {"legendary grandmaster","Red"}
            };
            if(map.ContainsKey(rank))return map[rank];
            return "Black";
        }

        public static string EpochToDateTime(long epochTime)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(epochTime);
            DateTime dt = dateTimeOffset.DateTime;
            var date = dt.ToString("MMM yyyy", DateTimeFormatInfo.InvariantInfo);
            return date;
        }

        public static string EpochToFullDateTime(long epochTime)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(epochTime);
            DateTime dt = dateTimeOffset.DateTime;
            var date = dt.ToString("dd MMM yyyy", DateTimeFormatInfo.InvariantInfo);
            return date;
        }
    }
}
