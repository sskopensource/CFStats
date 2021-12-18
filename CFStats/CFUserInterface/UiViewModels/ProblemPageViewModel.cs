using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.CFControls;
using UserInterface.CFControls.Models;

namespace UserInterface
{
    public class ProblemPageViewModel:ViewModelBase
    {
        private BarGraphModel _barGraph;
        public BarGraphModel barGraphModel
        {
            get
            {
                return _barGraph;
            }
            set
            {
                _barGraph = value;
            }
        }

        private PieChartModel _pieChart;
        public PieChartModel pieChartModel
        {
            get
            {
                return _pieChart;
            }
            set
            {
                _pieChart = value;
            }
        }
        public ProblemPageViewModel()
        {
            InitializeBarGraph();
            InitializePieChart();
        }

        private void InitializeBarGraph()
        {
            var map = ApiHandler.ProblemsRatingMap;
            string[] xValues = new string[map.Count];
            ChartValues<int> chartValues = new ChartValues<int>();

            int indx = 0;
            foreach (var i in map)
            {
                chartValues.Add(i.Value);
                xValues[indx] = i.Key.ToString();
                indx++;
            }
            barGraphModel = new BarGraphModel(xValues,chartValues);
        }

        private void InitializePieChart()
        {
            var map = ApiHandler.VerdictMap;
            List<KeyValuePair<string,int>> list = new List<KeyValuePair<string, int>>();
            foreach(var i in map)
            {
                string curVerdict=i.Key;
                if (curVerdict == "OK") curVerdict = "ACCEPTED";
                if (curVerdict == "COMPILATION_ERROR") curVerdict = "CE";
                if (curVerdict == "TIME_LIMIT_EXCEEDED") curVerdict = "TLE";
                if (curVerdict == "MEMORY_LIMIT_EXCEEDED") curVerdict = "MLE";
                if (curVerdict == "IDLENESS_LIMIT_EXCEEDED") curVerdict = "ILE";
                if (curVerdict == "RUNTIME_ERROR") curVerdict = "RE";
                if (curVerdict == "WRONG_ANSWER") curVerdict = "WA";
                if (curVerdict == "PRESENTATION_ERROR") curVerdict = "PE";

                list.Add(new KeyValuePair<string, int>(curVerdict, i.Value));
            }
            list.Sort((x, y) => (y.Value.CompareTo(x.Value)));
            pieChartModel = new PieChartModel(list);
        }

        public string[] XValues => barGraphModel.XValues;
        public Func<int, string> YValues => barGraphModel.YValues;
        public SeriesCollection BarValues => barGraphModel.BarValues;

        public SeriesCollection PieValues => pieChartModel.PieValues;

    }
}
