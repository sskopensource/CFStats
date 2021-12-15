using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UserInterface;
using UserInterface.Common;

namespace UnitTestUserInterface
{
    [TestClass]
    public class UnitTestNavBar
    {
        private const string DefaultBackgroundColor = "White";
        private const string AccentBackgroundColor = "#FF8000FF";
        private const string DefaultFontColor = "Black";
        private const string AccentFontColor = "White";
        private const string DefaultHoverColor = "#EDEDED";
        private const string AccentHoverColor = "#FF8000FF";
        
        private HashSet<NAVTAB> navTabSet = new HashSet<NAVTAB>()
        {
             NAVTAB.OVERVIEW,
             NAVTAB.PROBLEM,
             NAVTAB.CONTEST
        };

        public UnitTestNavBar()
        {
            ApiHandler.LoadApiControl("suveen");
        }

        private ViewModelBase ConvertPageViewModelFromNAVTAB(NAVTAB currTab)
        {
            Dictionary<NAVTAB, ViewModelBase> navTabMap = new Dictionary<NAVTAB, ViewModelBase>()
            {
                {NAVTAB.OVERVIEW,new OverviewPageViewModel()},
                {NAVTAB.PROBLEM,new ProblemPageViewModel()},
                {NAVTAB.CONTEST,new ContestPageViewModel()}
            };
            return navTabMap[currTab];
        }

        [TestMethod]
        public void GetNavTabBackgroundColor_AllTab_ReturnsActualColor()
        {
            NavigationStore fakeStore;
            foreach(NAVTAB pressedTab in navTabSet)
            {
                fakeStore = new NavigationStore() {CurrentViewModel=ConvertPageViewModelFromNAVTAB(pressedTab), CurrentTab = pressedTab };

             //   Assert.IsNotNull(fakeStore.CurrentViewModel);

                foreach (NAVTAB navTab in navTabSet)
                {
                    string fakeColor = fakeStore.GetNavTabBackgroundColor(navTab);
                    if (navTab == fakeStore.CurrentTab)
                    {
                        Assert.IsTrue(AccentBackgroundColor == fakeColor);
                        Assert.IsFalse(DefaultBackgroundColor == fakeColor);
                    }
                    else
                    {
                        Assert.IsFalse(AccentBackgroundColor == fakeColor);
                        Assert.IsTrue(DefaultBackgroundColor == fakeColor);
                    }
                }
            }
            
        }

        [TestMethod]
        public void GetNavTabFontColor_AllTab_ReturnsActualColor()
        {
            NavigationStore fakeStore;

            foreach (NAVTAB pressedTab in navTabSet)
            {
                fakeStore = new NavigationStore() { CurrentViewModel = ConvertPageViewModelFromNAVTAB(pressedTab), CurrentTab = pressedTab };

                foreach (NAVTAB navTab in navTabSet)
                {
                    string fakeColor = fakeStore.GetNavTabFontColor(navTab);
                    if (navTab == fakeStore.CurrentTab)
                    {
                        Assert.IsTrue(AccentFontColor == fakeColor);
                        Assert.IsFalse(DefaultFontColor == fakeColor);
                    }
                    else
                    {
                        Assert.IsFalse(AccentFontColor == fakeColor);
                        Assert.IsTrue(DefaultFontColor == fakeColor);
                    }
                }
            }
        }

        [TestMethod]
        public void GetNavTabHoverColor_AllTab_ReturnsActualColor()
        {
            NavigationStore fakeStore;

            foreach (NAVTAB pressedTab in navTabSet)
            {
                fakeStore = new NavigationStore() { CurrentViewModel = ConvertPageViewModelFromNAVTAB(pressedTab), CurrentTab = pressedTab };

                foreach (NAVTAB navTab in navTabSet)
                {
                    string fakeColor = fakeStore.GetNavTabHoverColor(navTab);
                    if (navTab == fakeStore.CurrentTab)
                    {
                        Assert.IsTrue(AccentHoverColor == fakeColor);
                        Assert.IsFalse(DefaultHoverColor == fakeColor);
                    }
                    else
                    {
                        Assert.IsFalse(AccentHoverColor == fakeColor);
                        Assert.IsTrue(DefaultHoverColor == fakeColor);
                    }
                }
            }
        }

    }
}
