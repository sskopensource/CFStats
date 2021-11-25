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
    /// Interaction logic for Brick.xaml
    /// </summary>
    public partial class Brick : UserControl
    {
        public Brick()
        {
            InitializeComponent();
        }

        public string TxtLabel
        {
            get { return (string)GetValue(TxtLabelProperty); }
            set { SetValue(TxtLabelProperty, value); }
        }

        public static readonly DependencyProperty TxtLabelProperty = DependencyProperty.Register("TxtLabel", typeof(string), typeof(Brick), new PropertyMetadata(""));

        public string ValLabel
        {
            get { return (string)GetValue(ValLabelProperty); }
            set { SetValue(ValLabelProperty, value); }
        }

        public static readonly DependencyProperty ValLabelProperty = DependencyProperty.Register("ValLabel", typeof(string), typeof(Brick), new PropertyMetadata(null));
    }
}
