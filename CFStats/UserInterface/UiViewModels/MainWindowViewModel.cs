using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CFControls;
using UserInterface.Commands;
using UserInterface.Common;

namespace UserInterface
{
    public class MainWindowViewModel:ViewModelBase
    {
        private MainWindowModel _mainWindowWodel;
        private NavBarViewModel _navBarViewModel;

        public MainWindowViewModel()
        {
            NavBarViewModel = new NavBarViewModel();
            mainWindowModel = new MainWindowModel();
            mainWindowModel.loginModel.imageurl = ApiHandler.Avatar;
            mainWindowModel.loginModel.handle = ApiHandler.Handle;
        }

        public NavBarViewModel NavBarViewModel
        {
            get
            {
                return _navBarViewModel;
            }
            set
            {
                _navBarViewModel = value;
            }
        }

        public MainWindowModel mainWindowModel
        {
            get
            {
                return _mainWindowWodel;
            }
            set
            {
                _mainWindowWodel = value;
            }
        }

        public string ImageURL => mainWindowModel.loginModel.imageurl;
        public string Handle => mainWindowModel.loginModel.handle;
    }
}
