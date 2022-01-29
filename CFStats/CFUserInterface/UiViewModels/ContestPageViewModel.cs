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
    public class ContestPageViewModel : ViewModelBase
    {
        public LongBrickModel contests { get; set; }
        public LongBrickModel bestRank { get; set; }
        public LongBrickModel worstRank { get; set; }
        public LongBrickModel maxUp { get; set; }
        public LongBrickModel maxDown { get; set; }
        public LineGraphModel lineGraph { get; private set; }

        public ContestPageViewModel()
        {
            contests = new LongBrickModel() { ValueLabel = ApiHandler.Contests };
            bestRank = new LongBrickModel() { ValueLabel = ApiHandler.BestRank,TextLabel="Best Rank"};
            worstRank = new LongBrickModel() { ValueLabel = ApiHandler.WorstRank, TextLabel = "Worst Rank" };
            maxUp = new LongBrickModel() { ValueLabel = ApiHandler.MaxUp, TextLabel = "Max Up" };
            maxDown = new LongBrickModel() { ValueLabel = ApiHandler.MaxDown, TextLabel = "Max Down" };

            InitializeLineGraph();
        }

        private void InitializeLineGraph()
        {
            var map = ApiHandler.ContestMap;
            string[] XAxisTime = new string[map.Count];
            int[] chartValues = new int[map.Count];

            int indx = 0;
            foreach (var i in map)
            {
                chartValues[indx] = Convert.ToInt32(i.Value);
                XAxisTime[indx] = i.Key;
                indx++;
            }
            lineGraph = new LineGraphModel(XAxisTime, chartValues);
        }

        public string[] XLValues => lineGraph.XLValues;
        public ChartValues<LineGraphToolTipModel> LineValues => lineGraph.LineValues;

    }
}
