using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;

namespace UserInterface.CFControls.Models
{
    public class LineGraphModel
    { 
        public SeriesCollection LineValues { get; set; }
        public string[] XLValues { get; set; }
        public Func<double, string> YLValues { get; set; }

        public LineGraphModel(string[] xVals, ChartValues<int> Vals)
        {
            LineValues = new SeriesCollection
            {
                new LineSeries
                {
                    Title="",
                    Values = Vals,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 5
                }
            };
            XLValues = xVals;
            YLValues = value => value.ToString("N");
        }
       
    }
}
