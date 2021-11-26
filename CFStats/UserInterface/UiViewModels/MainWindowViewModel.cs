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
        public MainWindowModel mainwindowmodel { get; set; }    
        
        public MainWindowViewModel()
        {
            ApiHandler.LoadApiControl("KAN");
            Console.WriteLine("Called: MainWindowViewModel");
            mainwindowmodel = new MainWindowModel();
            mainwindowmodel.loginModel.imageurl = ApiHandler.ProfilePicture;
            mainwindowmodel.loginModel.handle = ApiHandler.Handle;
            mainwindowmodel.OverviewPage = new OverviewPage();

        }
    }
}
