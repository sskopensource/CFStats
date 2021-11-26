﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;

namespace CFControls
{
    public class BrickModel
    {
        private string _textLabel;
        private string _valueLabel;

        public string TextLabel
        {
            get
            {
                return _textLabel;
            }
            set
            {
                _textLabel = value;
             //   OnPropertyChanged("TextLabel");
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
             //   OnPropertyChanged("ValueLabel");
            }
        }
    }
}
