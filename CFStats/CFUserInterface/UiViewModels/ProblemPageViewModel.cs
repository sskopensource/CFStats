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
        public ProblemPageViewModel()
        {
            InitializeBarGraph();
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

        public string[] XValues => barGraphModel.XValues;
        public Func<int, string> YValues => barGraphModel.YValues;
        public SeriesCollection BarValues => barGraphModel.BarValues;
    }
}
