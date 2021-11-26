using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFControls;
using UserInterface.Pages;

namespace UserInterface
{
    public class MainWindowModel
    {
        private LoginModel _loginModel= new LoginModel();
        private OverviewPage _overviewPage;

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

        public OverviewPage OverviewPage
        {
            get
            {
                return _overviewPage;
            }
            set
            {
                _overviewPage = value;
                //OnPropertyChanged("loginModel");
            }
        }
    }
} 