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
    /// Interaction logic for DoughnutChart.xaml
    /// </summary>
    public partial class DoughnutChart : UserControl
    {
        public DoughnutChart()
        {
            InitializeComponent();
        }

        public SeriesCollection DoughnutValues
        {
            get { return (SeriesCollection)GetValue(DoughnutValuesProperty); }
            set { SetValue(DoughnutValuesProperty, value); }
        }

        public static readonly DependencyProperty DoughnutValuesProperty = DependencyProperty.Register("DoughnutValues", typeof(SeriesCollection), typeof(DoughnutChart));

        public double PieInnerRadius
        {
            get { return (double)GetValue(PieInnerRadiusProperty); }
            set { SetValue(PieInnerRadiusProperty, value); }
        }

        public static readonly DependencyProperty PieInnerRadiusProperty = DependencyProperty.Register("PieInnerRadius", typeof(double), typeof(DoughnutChart));
    }
}
