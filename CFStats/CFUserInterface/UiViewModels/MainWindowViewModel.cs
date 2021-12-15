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
        private LoginModel _loginModel = new LoginModel();
        private NavBarViewModel _navBarViewModel;
        public ICommand LogoutCommand { get; }

        public string ImageURL => loginModel.imageurl;
        public string Handle => loginModel.handle;

        public MainWindowViewModel()
        {
            NavBarViewModel = new NavBarViewModel();
            LogoutCommand = new DelegateCommand<Window>(Logout);
            loginModel.imageurl = ApiHandler.Avatar;
            loginModel.handle = ApiHandler.Handle;
        }

        public LoginModel loginModel
        {
            get
            {
                return _loginModel;
            }
            set
            {
                _loginModel = value;
                //OnPropertyChanged("loginModel");
            }
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

        private void Logout(Window currWindow)
        {
            LoginWindow newWindow = new LoginWindow();
            newWindow.Show();
            currWindow.Close();
        }
    }
}
