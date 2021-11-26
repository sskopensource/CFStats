using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFControls;
using UserInterface.Pages;

namespace UserInterface
{
    public class MainWindowViewModel
    {

        private MainWindowModel _mainWindowWodel;
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

        public MainWindowViewModel()
        {
            ApiHandler.LoadApiControl("suveen");
            mainWindowModel = new MainWindowModel();
            mainWindowModel.loginModel.imageurl = ApiHandler.Avatar;
            mainWindowModel.loginModel.handle = ApiHandler.Handle;
            mainWindowModel.OverviewPage = new OverviewPage();
        }

        public string ImageURL
        {
            get
            {
                return mainWindowModel.loginModel.imageurl;
            }
        }

        public string Handle
        {
            get
            {
                return mainWindowModel.loginModel.handle;
            }
        }
    }
}
