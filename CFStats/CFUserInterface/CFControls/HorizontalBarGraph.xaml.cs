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
    /// Interaction logic for HorizontalBarGraph.xaml
    /// </summary>
    public partial class HorizontalBarGraph : UserControl
    {
        public HorizontalBarGraph()
        {
            InitializeComponent();
        }

        public string[] YValues
        {
            get { return (string[])GetValue(YValuesProperty); }
            set { SetValue(YValuesProperty, value); }
        }

        public static readonly DependencyProperty YValuesProperty = DependencyProperty.Register("YValues", typeof(string[]), typeof(HorizontalBarGraph));

        public SeriesCollection BarValues
        {
            get { return (SeriesCollection)GetValue(BarValuesProperty); }
            set { SetValue(BarValuesProperty, value); }
        }

        public static readonly DependencyProperty BarValuesProperty = DependencyProperty.Register("BarValues", typeof(SeriesCollection), typeof(HorizontalBarGraph));

        public Func<int, string> XValues
        {
            get { return (Func<int, string>)GetValue(XValuesProperty); }
            set { SetValue(XValuesProperty, value); }
        }

        public static readonly DependencyProperty XValuesProperty = DependencyProperty.Register("XValues", typeof(Func<int, string>), typeof(HorizontalBarGraph));
    }
}
