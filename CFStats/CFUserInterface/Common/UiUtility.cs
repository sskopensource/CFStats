using System;
using System.Collections.Generic;
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
    }
}
