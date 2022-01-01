using CFControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class ContestPageViewModel : ViewModelBase
    {
        public LongBrickModel contests { get; set; }
        public LongBrickModel bestRank { get; set; }
        public LongBrickModel worstRank { get; set; }
        public LongBrickModel maxUp { get; set; }
        public LongBrickModel maxDown { get; set; }
        public ContestPageViewModel()
        {
            contests = new LongBrickModel() { ValueLabel = ApiHandler.Contests };
            bestRank = new LongBrickModel() { ValueLabel = ApiHandler.BestRank,TextLabel="Best Rank"};
            worstRank = new LongBrickModel() { ValueLabel = ApiHandler.WorstRank, TextLabel = "Worst Rank" };
            maxUp = new LongBrickModel() { ValueLabel = ApiHandler.MaxUp, TextLabel = "Max Up" };
            maxDown = new LongBrickModel() { ValueLabel = ApiHandler.MaxDown, TextLabel = "Max Down" };
            
        }
    }
}
