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


        public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

        public string BackgroundColorOverviewTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.OVERVIEW);
        public string BackgroundColorProblemTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM);
        public string BackgroundColorContestTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.CONTEST);
        public string BackgroundColorProblemOneTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM_ONE);
        public string BackgroundColorProblemTwoTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM_TWO);

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
            OnPropertyChanged(nameof(BackgroundColorOverviewTab));
            OnPropertyChanged(nameof(BackgroundColorProblemTab));
            OnPropertyChanged(nameof(BackgroundColorProblemOneTab));
            OnPropertyChanged(nameof(BackgroundColorProblemTwoTab));
            OnPropertyChanged(nameof(BackgroundColorContestTab));
        }
    }
}
