using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUi
{
    public class Model1 : INotifyPropertyChanged
    {
        public string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                OnPropertyChanged("Model");
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
