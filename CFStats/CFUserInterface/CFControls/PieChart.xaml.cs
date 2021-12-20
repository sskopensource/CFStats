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
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : UserControl
    {
        public PieChart()
        {
            InitializeComponent();
        }

        public SeriesCollection PieValues
        {
            get { return (SeriesCollection)GetValue(PieValuesProperty); }
            set { SetValue(PieValuesProperty, value); }
        }

        public static readonly DependencyProperty PieValuesProperty = DependencyProperty.Register("PieValues", typeof(SeriesCollection), typeof(PieChart));
    }
}
