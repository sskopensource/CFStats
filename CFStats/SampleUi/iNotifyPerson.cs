using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUi
{
    public class iNotifyPerson : INotifyPropertyChanged
    {
        public string fName;
        public string lName;
        public string fullName;

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
                OnPropertyChanged("FName");
                OnPropertyChanged("FullName");
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
                OnPropertyChanged("LName");
                OnPropertyChanged("FullName");
            }
        }

        public string FullName
        {
            get
            {
                return fullName=fName+" "+lName;
            }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                }
                
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
