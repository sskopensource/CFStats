using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Common;

namespace UserInterface.Commands
{
    public class NavigationCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private ViewModelBase _createViewModel;
        private NAVTAB _navTab;

        public NavigationCommand(NavigationStore navigationStore, NAVTAB navTab)
        {
            _navigationStore = navigationStore;
            _createViewModel = UiUtility.ConvertPageViewModelFromNAVTAB(navTab);
            _navTab = navTab;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel;
            _navigationStore.CurrentTab = _navTab;
        }
    }
}
