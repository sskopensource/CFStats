using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface.CFControls
{
    /// <summary>
    /// Interaction logic for LongBrick.xaml
    /// </summary>
    public partial class LongBrick : UserControl
    {
        public LongBrick()
        {
            InitializeComponent();
        }

        public string TextLabel
        {
            get { return (string)GetValue(TextLabelProperty); }
            set { SetValue(TextLabelProperty, value); }
        }

        public static readonly DependencyProperty TextLabelProperty = DependencyProperty.Register("TextLabel", typeof(string), typeof(LongBrick), new PropertyMetadata(""));

        public string ValueLabel
        {
            get { return (string)GetValue(ValueLabelProperty); }
            set { SetValue(ValueLabelProperty, value); }
        }

        public static readonly DependencyProperty ValueLabelProperty = DependencyProperty.Register("ValueLabel", typeof(string), typeof(LongBrick), new PropertyMetadata(null));

        public string ValueColor
        {
            get { return (string)GetValue(ValueColorProperty); }
            set { SetValue(ValueColorProperty, value); }
        }

        public static readonly DependencyProperty ValueColorProperty = DependencyProperty.Register("ValueColor", typeof(string), typeof(LongBrick), new PropertyMetadata(null));
    }
}
