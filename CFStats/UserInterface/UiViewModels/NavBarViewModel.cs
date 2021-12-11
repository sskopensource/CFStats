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

        public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

        public string BackgroundColorOverviewTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.OVERVIEW);
        public string BackgroundColorProblemTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.PROBLEM);
        public string BackgroundColorContestTab => navigationStore.GetNavTabBackgroundColor(NAVTAB.CONTEST);

        public string FontColorOverviewTab => navigationStore.GetNavTabFontColor(NAVTAB.OVERVIEW);
        public string FontColorProblemTab => navigationStore.GetNavTabFontColor(NAVTAB.PROBLEM);
        public string FontColorContestTab => navigationStore.GetNavTabFontColor(NAVTAB.CONTEST);

        public string HoverColorOverviewTab => navigationStore.GetNavTabHoverColor(NAVTAB.OVERVIEW);
        public string HoverColorProblemTab => navigationStore.GetNavTabHoverColor(NAVTAB.PROBLEM);
        public string HoverColorContestTab => navigationStore.GetNavTabHoverColor(NAVTAB.CONTEST);

        public NavBarViewModel()
        {
            navigationStore = new NavigationStore();
            //Subscribing to CurrentViewModelChanged event of NavigationStore handling the event with OnCurrentViewModelChanged function.
            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            navigationStore.CurrentViewModel = new OverviewPageViewModel();
            navigationStore.CurrentTab = NAVTAB.OVERVIEW;

            NavigateOverviewPageCommand = new NavigationCommand<OverviewPageViewModel>(navigationStore, () => new OverviewPageViewModel(),NAVTAB.OVERVIEW);
            NavigateProblemPageCommand = new NavigationCommand<ProblemPageViewModel>(navigationStore, () => new ProblemPageViewModel(),NAVTAB.PROBLEM);
            NavigateContestPageCommand = new NavigationCommand<ContestPageViewModel>(navigationStore, () => new ContestPageViewModel(),NAVTAB.CONTEST);
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            OnPropertyChanged(nameof(BackgroundColorOverviewTab));
            OnPropertyChanged(nameof(BackgroundColorProblemTab));
            OnPropertyChanged(nameof(BackgroundColorContestTab));
            OnPropertyChanged(nameof(FontColorOverviewTab));
            OnPropertyChanged(nameof(FontColorProblemTab));
            OnPropertyChanged(nameof(FontColorContestTab));
            OnPropertyChanged(nameof(HoverColorOverviewTab));
            OnPropertyChanged(nameof(HoverColorProblemTab));
            OnPropertyChanged(nameof(HoverColorContestTab));
        }
    }
}
