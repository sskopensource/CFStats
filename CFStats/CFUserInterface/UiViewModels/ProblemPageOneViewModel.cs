using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.CFControls.Models;

namespace UserInterface
{
    public class ProblemPageOneViewModel:ViewModelBase
    {
        public PieChartModel pieChart { get; private set; }
        public HorizontalBarGraphModel barGraph { get; private set; }

        public ProblemPageOneViewModel()
        {
            InitializePieChart();
            InitializeBarGraph();
        }

        private void InitializePieChart()
        {
            var map = ApiHandler.TagsMap;
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            foreach (var i in map)
            {
                string curVerdict = i.Key;
                list.Add(new KeyValuePair<string, int>(curVerdict, i.Value));
            }
            list.Sort((x, y) => (y.Value.CompareTo(x.Value)));
            pieChart = new PieChartModel(list);
        }

        private void InitializeBarGraph()
        {
            var map = ApiHandler.LevelsMap;
            string[] yValues = new string[map.Count];
            ChartValues<int> chartValues = new ChartValues<int>();

            int indx = 0;
            foreach (var i in map)
            {
                chartValues.Add(i.Value);
                yValues[indx] = i.Key.ToString();
                indx++;
            }
            barGraph = new HorizontalBarGraphModel(yValues, chartValues);
        }

        public Func<int, string> XValues => barGraph.XValues;
        public string[] YValues => barGraph.YValues;
        public SeriesCollection BarValues => barGraph.BarValues;
        public SeriesCollection PieValues => pieChart.PieValues;
    }
}
