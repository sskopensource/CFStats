using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using UserInterface.Common;

namespace UserInterface.CFControls.Models
{
    public class LineGraphModel
    { 
        public ChartValues<LineGraphToolTipModel> LineValues { get; set; }
        public string[] XLValues { get; set; }

        public LineGraphModel(SortedDictionary<string,ContestModel> map)
        {
            LineValues = new ChartValues<LineGraphToolTipModel>();
            XLValues = new string[map.Count];

            int i = 0;
            foreach(var item in map)
            {
                LineValues.Add(new LineGraphToolTipModel()
                {
                    Date = UiUtility.EpochToFullDateTime(Convert.ToInt64(item.Key)),
                    ContestName = item.Value.ContestName,
                    Rating = item.Value.CurrentRating,
                    Rank = "Rank: "+item.Value.ContestRank.ToString(),
                    RatingChange = "(" + item.Value.RatingChange.ToString() + ")"
                }); ;

                XLValues[i] = UiUtility.EpochToDateTime(Convert.ToInt64(item.Key));
                i++;
            }

            var tooltipMapper = Mappers.Xy<LineGraphToolTipModel>()
               .X((value, index) => index) // lets use the position of the item as X
               .Y(value => value.Rating); //and item property as Y

            //save the mapper globally
            Charting.For<LineGraphToolTipModel>(tooltipMapper);
        }
       
    }
}
