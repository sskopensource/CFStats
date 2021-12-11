using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Common;

namespace UserInterface.Commands
{
    public class NavigationCommand<T> : CommandBase
        where T : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private Func<T> _createViewModel;
        private NAVTAB _navTab;

        public NavigationCommand(NavigationStore navigationStore,Func<T> createViewModel, NAVTAB navTab)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _navTab = navTab;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
            _navigationStore.CurrentTab = _navTab;
            Console.WriteLine(_navigationStore.CurrentViewModel.ToString());
        }
    }
}
