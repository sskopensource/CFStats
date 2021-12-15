using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;

namespace UserInterface.CFControls.Models
{
    public class BarGraphModel
    {
        public string[] XValues { get; set; }
        public Func<int, string> YValues { get; set; }
        public SeriesCollection BarValues { get; set; }

        public BarGraphModel(string[] xVals,ChartValues<int> Vals)
        {
            BarValues = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title="",
                    Values = Vals
                }
            };
            XValues = xVals;
            YValues = value => value.ToString("N");
        }
    }
}
