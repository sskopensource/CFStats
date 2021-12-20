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
        private BarGraphModel _barGraph;
        private PieChartModel _pieChart;
        private LongBrickModel _solvedInOneAttempt;
        private LongBrickModel _averageAttempt;
        private LongBrickModel _problemSolved;
        private LongBrickModel _problemTried;
        private LongBrickModel _problemUnsolved;
        private LongBrickModel _favouriteTag;


        public LongBrickModel favouriteTag
        {
            get
            {
                return _favouriteTag;
            }
            set
            {
                _favouriteTag = value;
            }
        }

        public LongBrickModel problemSolved
        {
            get
            {
                return _problemSolved;
            }
            set
            {
                _problemSolved = value;
            }
        }


        public LongBrickModel problemUnSolved
        {
            get
            {
                return _problemUnsolved;
            }
            set
            {
                _problemUnsolved = value;
            }
        }

        public LongBrickModel problemTried
        {
            get
            {
                return _problemTried;
            }
            set
            {
                _problemTried = value;
            }
        }

        public LongBrickModel averageAttempts
        {
            get
            {
                return _averageAttempt;
            }
            set
            {
                _averageAttempt = value;
            }
        }
        public LongBrickModel solvedInOneAttempt
        {
            get
            {
                return _solvedInOneAttempt;
            }
            set
            {
                _solvedInOneAttempt = value;
            }
        }
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
            InitializeLongBricks();
        }

        private void InitializeLongBricks()
        {
            averageAttempts = new LongBrickModel() {ValueLabel=ApiHandler.AverageAttempt };
            solvedInOneAttempt = new LongBrickModel() { ValueLabel = ApiHandler.SolvedFirstAttempt };
            favouriteTag = new LongBrickModel() { ValueLabel = ApiHandler.FavouriteTag };
            problemSolved = new LongBrickModel() { ValueLabel = ApiHandler.ProblemsSolved };
            problemUnSolved = new LongBrickModel() { ValueLabel = ApiHandler.ProblemsUnsolved };
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
        public string SolvedInOneAttempt => solvedInOneAttempt.ValueLabel;
        public string AverageAttempts => averageAttempts.ValueLabel;
        public string FavouriteTag => favouriteTag.ValueLabel;
        public string ProblemTried => problemTried.ValueLabel;
        public string ProblemUnsolved => problemUnSolved.ValueLabel;
        public string ProblemSolved => problemSolved.ValueLabel;


    }
}
