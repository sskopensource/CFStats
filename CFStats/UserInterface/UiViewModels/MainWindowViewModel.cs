using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.CFControls.Models;
using UserInterface.Core;
using UserInterface.UiModels;

namespace UserInterface.UiViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowModel mainwindowmodel { get; set; }
        public MainWindowViewModel()
        {
            mainwindowmodel = new MainWindowModel();
            mainwindowmodel.loginModel.imageurl = "https://userpic.codeforces.org/422/avatar/2b5dbe87f0d859a2.jpg";
            mainwindowmodel.loginModel.handle = "tourist";
            mainwindowmodel.MaxRating.TextLabel = "Max Ratings";
            mainwindowmodel.MaxRating.ValueLabel = "8888";
        }
    }
}
