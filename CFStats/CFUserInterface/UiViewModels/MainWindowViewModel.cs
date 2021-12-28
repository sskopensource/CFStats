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
        public LoginModel loginModel { get;} 
        public NavBarViewModel navBarViewModel { get; }
        public ICommand LogoutCommand { get; }

        public MainWindowViewModel()
        {
            loginModel = new LoginModel()
            {
                imageurl = ApiHandler.Avatar,
                handle = ApiHandler.Handle,
                rank = ApiHandler.Rank,
                rankColor = UiUtility.ConvertColorFromRank(ApiHandler.Rank)
            };

            navBarViewModel = new NavBarViewModel();
            LogoutCommand = new DelegateCommand<Window>(Logout);
        }

        private void Logout(Window currWindow)
        {
            LoginWindow newWindow = new LoginWindow();
            newWindow.Show();
            currWindow.Close();
        }
    }
}
