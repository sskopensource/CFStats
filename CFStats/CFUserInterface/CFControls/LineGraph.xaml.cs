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

        public ChartValues<LineGraphToolTipModel> LineValues
        {
            get { return (ChartValues<LineGraphToolTipModel>)GetValue(LineValuesProperty); }
            set { SetValue(LineValuesProperty, value); }
        }

        public static readonly DependencyProperty LineValuesProperty = DependencyProperty.Register("LineValues", typeof(ChartValues<LineGraphToolTipModel>), typeof(LineGraph));
    }
}
   