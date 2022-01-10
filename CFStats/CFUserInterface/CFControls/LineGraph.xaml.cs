using LiveCharts;
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
    /// Interaction logic for LineGraph.xaml
    /// </summary>
    public partial class LineGraph : UserControl
    {
        public LineGraph()
        {
            InitializeComponent();
        }

        public string[] XLValues
        {
            get { return (string[])GetValue(XValuesProperty); }
            set { SetValue(XValuesProperty, value); }
        }

        public static readonly DependencyProperty XValuesProperty = DependencyProperty.Register("XLValues", typeof(string[]), typeof(LineGraph));

        public SeriesCollection LineValues
        {
            get { return (SeriesCollection)GetValue(BarValuesProperty); }
            set { SetValue(BarValuesProperty, value); }
        }

        public static readonly DependencyProperty BarValuesProperty = DependencyProperty.Register("LineValues", typeof(SeriesCollection), typeof(LineGraph));

        public Func<double, string> YLValues
        {
            get { return (Func<double, string>)GetValue(YValuesProperty); }
            set { SetValue(YValuesProperty, value); }
        }

        public static readonly DependencyProperty YValuesProperty = DependencyProperty.Register("YLValues", typeof(Func<double, string>), typeof(LineGraph));

    }
}
   