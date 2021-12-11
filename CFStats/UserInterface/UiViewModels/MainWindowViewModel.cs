using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CFControls;
using Prism.Commands;
using UserInterface.Commands;
using UserInterface.Common;
using UserInterface.UiViews;

namespace UserInterface
{
    public class MainWindowViewModel:ViewModelBase
    {
        private MainWindowModel _mainWindowWodel;
        private NavBarViewModel _navBarViewModel;
        public ICommand LogoutCommand { get; }

        public string ImageURL => mainWindowModel.loginModel.imageurl;
        public string Handle => mainWindowModel.loginModel.handle;

        public MainWindowViewModel()
        {
            NavBarViewModel = new NavBarViewModel();
            mainWindowModel = new MainWindowModel();
            LogoutCommand = new DelegateCommand<Window>(Logout);
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

        private void Logout(Window currWindow)
        {
            LoginWindow newWindow = new LoginWindow();
            newWindow.Show();
            currWindow.Close();
        }
    }
}
