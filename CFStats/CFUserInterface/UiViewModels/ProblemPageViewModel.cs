using CFControls;
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
        public BarGraphModel barGraph { get; private set; }
        public PieChartModel pieChart { get; private set;}
        public LongBrickModel solvedInOneAttempt { get; private set;}
        public LongBrickModel averageAttempts { get; private set;}
        public LongBrickModel problemSolved { get; private set;}
        public LongBrickModel problemTried { get; private set;}
        public LongBrickModel problemUnsolved { get; private set;}
        public LongBrickModel favouriteTag { get; private set;}
        public ProblemPageViewModel()
        {
            InitializeBarGraph();
            InitializePieChart();
            InitializeLongBricks();
        }

        private void InitializeLongBricks()
        {
            averageAttempts = new LongBrickModel() {ValueLabel=ApiHandler.AverageAttempt };
            solvedInOneAttempt = new LongBrickModel() { ValueLabel = ApiHandler.SolvedFirstAttempt };
            favouriteTag = new LongBrickModel() { ValueLabel = ApiHandler.FavouriteTag };
            problemSolved = new LongBrickModel() { ValueLabel = ApiHandler.ProblemsSolved };
            problemUnsolved = new LongBrickModel() { ValueLabel = ApiHandler.ProblemsUnsolved };
            problemTried = new LongBrickModel() { ValueLabel = ApiHandler.ProblemTried };
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
            barGraph = new BarGraphModel(xValues,chartValues);
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
            pieChart = new PieChartModel(list);
        }
        public string[] XValues => barGraph.XValues;
        public Func<int, string> YValues => barGraph.YValues;
        public SeriesCollection BarValues => barGraph.BarValues;
        public SeriesCollection PieValues => pieChart.PieValues;
    }
}
