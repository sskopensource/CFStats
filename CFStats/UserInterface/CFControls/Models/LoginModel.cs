using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;

namespace CFControls
{
    public class LoginModel
    {
        private string _imageurl;
        private string _handle;

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
