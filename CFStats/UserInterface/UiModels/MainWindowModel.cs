using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.CFControls.Models;
using UserInterface.Core;

namespace UserInterface.UiModels
{
    public class MainWindowModel
    {
        public LoginModel _loginModel= new LoginModel();
        public BrickModel _maxRating = new BrickModel();

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

        public BrickModel MaxRating

        {
            get
            {
                return _maxRating;
            }
            set
            {
                _maxRating = value;
              //  OnPropertyChanged("MaxRating");
            }
        }
    }
} 