using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFControls;

namespace UserInterface
{
    public class MainWindowViewModel
    {
        public MainWindowModel mainwindowmodel { get; set; }
        
        public MainWindowViewModel()
        {
            mainwindowmodel = new MainWindowModel();
            mainwindowmodel.loginModel.imageurl = "https://userpic.codeforces.org/422/avatar/2b5dbe87f0d859a2.jpg";
            mainwindowmodel.loginModel.handle = "tourist";
        }
    }
}
