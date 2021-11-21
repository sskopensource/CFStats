using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Core;

namespace UserInterface.CFControls.Models
{
    public class LoginModel
    {
        public string _imageurl;
        public string _handle;

        public string imageurl
        {
            get
            {
                return _imageurl;
            }
            set
            {
                _imageurl = value;
               // OnPropertyChanged("imageurl");
            }
        }
        public string handle
        {
            get
            {
                return _handle;
            }
            set
            {
                _handle = value;
                //OnPropertyChanged("handle");
            }
        }
    }
}
