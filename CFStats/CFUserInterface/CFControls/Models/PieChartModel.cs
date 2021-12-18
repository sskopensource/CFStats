using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.CFControls.Models
{
    public class PieChartModel
    {
        public SeriesCollection PieValues { get; set; }

        public PieChartModel(List<KeyValuePair<string,int>> vals)
        {
            PieValues = new SeriesCollection();

            foreach(var i in vals)
            {
                var curSeries = new PieSeries()
                {
                    Title = i.Key,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(i.Value) }
                };

                PieValues.Add(curSeries);
            }
        }
    }
}
