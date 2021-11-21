using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UserInterface.CFControls.Controls
{
    public class BrickControl:UserControl
    {
        public String TextLabel
        {
            get { return (String)GetValue(TextLabelProperty); }
            set { SetValue(TextLabelProperty, value); }
        }

        public static readonly DependencyProperty TextLabelProperty = DependencyProperty.Register("TextLabel", typeof(string), typeof(Brick), new PropertyMetadata(""));

        public object ValueLabel
        {
            get { return (object)GetValue(ValueLabelProperty); }
            set { SetValue(ValueLabelProperty, value); }
        }

        public static readonly DependencyProperty ValueLabelProperty = DependencyProperty.Register("ValueLabel", typeof(object), typeof(Brick), new PropertyMetadata(null));

        public BrickControl()
        {
            TextLabel = "default";
            ValueLabel = "defaultlabel";
        }
    }
}
