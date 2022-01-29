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

        public LineGraphModel(string[] xVals, int[] Vals)
        {
            LineValues = new ChartValues<LineGraphToolTipModel>();

            for (int i = 0; i < xVals.Length; i++)
            {
                LineValues.Add(new LineGraphToolTipModel()
                { 
                    Date = UiUtility.EpochToFullDateTime(Convert.ToInt64(xVals[i])),
                    ContestName = "Fake Contest",
                    Rating = Vals[i],
                    Rank = 1000 
                });

                xVals[i] = UiUtility.EpochToDateTime(Convert.ToInt64(xVals[i]));
            }

            var tooltipMapper = Mappers.Xy<LineGraphToolTipModel>()
               .X((value, index) => index) // lets use the position of the item as X
               .Y(value => value.Rating); //and item property as Y

            //save the mapper globally
            Charting.For<LineGraphToolTipModel>(tooltipMapper);
            XLValues = xVals;
        }
       
    }
}
