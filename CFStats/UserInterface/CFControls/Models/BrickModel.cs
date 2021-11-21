using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.CFControls.Models
{
    public class BrickModel
    {
        public string _textLabel;
        public string _valueLabel;
        public string TextLabel
        {
            get
            {
                return _textLabel;
            }
            set
            {
                _textLabel = value;
                //OnPropertyChanged("handle");
            }
        }
        public string ValueLabel
        {
            get
            {
                return _valueLabel;
            }
            set
            {
                _valueLabel = value;
                //OnPropertyChanged("handle");
            }
        }
    }
}
