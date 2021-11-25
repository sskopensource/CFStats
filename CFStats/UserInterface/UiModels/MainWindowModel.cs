using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFControls;

namespace UserInterface
{
    public class MainWindowModel
    {
        public LoginModel _loginModel= new LoginModel();

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
    }
} 