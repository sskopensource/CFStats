using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.CFControls.Models
{
    public class HorizontalBarGraphModel
    {
        public string[] YValues { get; set; }
        public Func<int, string> XValues { get; set; }
        public SeriesCollection BarValues { get; set; }

        public HorizontalBarGraphModel(string[] yVals, ChartValues<int> Vals)
        {
            BarValues = new SeriesCollection
            {
                new RowSeries
                {
                    Title="",
                    Values = Vals,
                    RowPadding=1                  
                }
            };
            YValues = yVals;
            XValues = value => value.ToString("N");
        }
    }
}
