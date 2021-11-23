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

        public String TextLabel
        {
            get { return (String)GetValue(TextLabelProperty); }
            set { SetValue(TextLabelProperty, value); }
        }

        public static readonly DependencyProperty TextLabelProperty = DependencyProperty.Register("LongBrick.TextLabel", typeof(string), typeof(Brick), new PropertyMetadata(""));

        public object ValueLabel
        {
            get { return (object)GetValue(ValueLabelProperty); }
            set { SetValue(ValueLabelProperty, value); }
        }

        public static readonly DependencyProperty ValueLabelProperty = DependencyProperty.Register("LongBrick.ValueLabel", typeof(object), typeof(Brick), new PropertyMetadata(null));
    }
}
