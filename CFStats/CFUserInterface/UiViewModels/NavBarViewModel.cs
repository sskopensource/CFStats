using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserInterface.Commands;
using UserInterface.Common;

namespace UserInterface
{
    public class NavBarViewModel:ViewModelBase
    {
        public NavigationStore navigationStore { get;}
        public ICommand NavigateOverviewPageCommand { get; }
        public ICommand NavigateProblemPageCommand { get; }
        public ICommand NavigateContestPageCommand { get; }
        public ICommand NavigateProblemPageOneCommand { get; }
        public ICommand NavigateProblemPageTwoCommand { get; }

        public bool problemExpanded
        {
            get
            {
                return navigationStore.ProblemExpanded; 
            }
            set
            {
                navigationStore.ProblemExpanded = value;
                navigationStore.CurrentTab = NAVTAB.EXPANDER;
                OnPropertyChanged(nameof(problemExpanded));
                OnPropertyChanged(nameof(FontColorExpander));
                OnPropertyChanged(nameof(BackgroundColorExpander));
                OnPropertyChanged(nameof(HoverFontColorExpander));
                OnPropertyChanged(nameof(HoverBackgroundColorExpander));
                OnPropertyChanged(nameof(ColorBorderExpander));

            }
        }

        public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

        public string BackgroundColorOverviewTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.OVERVIEW);
        public string BackgroundColorProblemTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM);
        public string BackgroundColorContestTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.CONTEST);
        public string BackgroundColorProblemOneTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM_ONE);
        public string BackgroundColorProblemTwoTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM_TWO);

        public string ColorBorderOverview => navigationStore.GetNavTabBorderColor(NAVTAB.OVERVIEW);
        public string ColorBorderExpander => navigationStore.GetExpanderBorderColor();
        public string ColorBorderContest => navigationStore.GetNavTabBorderColor(NAVTAB.CONTEST);


        public string FontColorOverviewTab => navigationStore.GetNavTabFontColor(NAVTAB.OVERVIEW);
        public string FontColorProblemTab => navigationStore.GetNavTabFontColor(NAVTAB.PROBLEM);
        public string FontColorContestTab => navigationStore.GetNavTabFontColor(NAVTAB.CONTEST);
        public string FontColorProblemOneTab => navigationStore.GetNavTabFontColor(NAVTAB.PROBLEM_ONE);
        public string FontColorProblemTwoTab => navigationStore.GetNavTabFontColor(NAVTAB.PROBLEM_TWO);

        public string HoverFontColorOverviewTab => navigationStore.GetNavTabHoverFontColor(NAVTAB.OVERVIEW);
        public string HoverFontColorProblemTab => navigationStore.GetNavTabHoverFontColor(NAVTAB.PROBLEM);
        public string HoverFontColorContestTab => navigationStore.GetNavTabHoverFontColor(NAVTAB.CONTEST);
        public string HoverFontColorProblemOneTab => navigationStore.GetNavTabHoverFontColor(NAVTAB.PROBLEM_ONE);
        public string HoverFontColorProblemTwoTab => navigationStore.GetNavTabHoverFontColor(NAVTAB.PROBLEM_TWO);

        public string HoverBackgroundColorOverviewTab => navigationStore.GetNavTabHoverBackgroundColor(NAVTAB.OVERVIEW);
        public string HoverBackgroundColorProblemTab => navigationStore.GetNavTabHoverBackgroundColor(NAVTAB.PROBLEM);
        public string HoverBackgroundColorContestTab => navigationStore.GetNavTabHoverBackgroundColor(NAVTAB.CONTEST);
        public string HoverBackgroundColorProblemOneTab => navigationStore.GetNavTabHoverBackgroundColor(NAVTAB.PROBLEM_ONE);
        public string HoverBackgroundColorProblemTwoTab => navigationStore.GetNavTabHoverBackgroundColor(NAVTAB.PROBLEM_TWO);

        public string FontColorExpander => navigationStore.GetExpanderFontColor();
        public string BackgroundColorExpander => navigationStore.GetExpanderBackgroundColor();
        public string HoverFontColorExpander => navigationStore.GetExpanderHoverFontColor();
        public string HoverBackgroundColorExpander => navigationStore.GetExpanderHoverBackgroundColor();

        public NavBarViewModel()
        {
            navigationStore = new NavigationStore();
            //Subscribing to CurrentViewModelChanged event of NavigationStore handling the event with OnCurrentViewModelChanged function.
            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            navigationStore.CurrentViewModel = new OverviewPageViewModel();
            navigationStore.CurrentTab = NAVTAB.OVERVIEW;

            NavigateOverviewPageCommand = new NavigationCommand(navigationStore,NAVTAB.OVERVIEW);
            NavigateProblemPageCommand = new NavigationCommand(navigationStore,NAVTAB.PROBLEM);
            NavigateContestPageCommand = new NavigationCommand(navigationStore,NAVTAB.CONTEST);
            NavigateProblemPageOneCommand = new NavigationCommand(navigationStore, NAVTAB.PROBLEM_ONE);
            NavigateProblemPageTwoCommand = new NavigationCommand(navigationStore, NAVTAB.PROBLEM_TWO);

        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            OnPropertyChanged(nameof(problemExpanded));

            OnPropertyChanged(nameof(FontColorExpander));
            OnPropertyChanged(nameof(BackgroundColorExpander));
            OnPropertyChanged(nameof(HoverFontColorExpander));
            OnPropertyChanged(nameof(HoverBackgroundColorExpander));
            OnPropertyChanged(nameof(ColorBorderExpander));


            OnPropertyChanged(nameof(BackgroundColorOverviewTab));
            OnPropertyChanged(nameof(BackgroundColorProblemTab));
            OnPropertyChanged(nameof(BackgroundColorProblemOneTab));
            OnPropertyChanged(nameof(BackgroundColorProblemTwoTab));
            OnPropertyChanged(nameof(BackgroundColorContestTab));

            OnPropertyChanged(nameof(FontColorOverviewTab));
            OnPropertyChanged(nameof(FontColorProblemTab));
            OnPropertyChanged(nameof(FontColorContestTab));
            OnPropertyChanged(nameof(FontColorProblemOneTab));
            OnPropertyChanged(nameof(FontColorProblemTwoTab));

            OnPropertyChanged(nameof(HoverFontColorOverviewTab));
            OnPropertyChanged(nameof(HoverFontColorProblemTab));
            OnPropertyChanged(nameof(HoverFontColorContestTab));
            OnPropertyChanged(nameof(HoverFontColorProblemOneTab));
            OnPropertyChanged(nameof(HoverFontColorProblemTwoTab));

            OnPropertyChanged(nameof(HoverBackgroundColorOverviewTab));
            OnPropertyChanged(nameof(HoverBackgroundColorProblemTab));
            OnPropertyChanged(nameof(HoverBackgroundColorContestTab));
            OnPropertyChanged(nameof(HoverBackgroundColorProblemOneTab));
            OnPropertyChanged(nameof(HoverBackgroundColorProblemTwoTab));

            OnPropertyChanged(nameof(ColorBorderOverview));
            OnPropertyChanged(nameof(ColorBorderContest));
        }
    }
}
