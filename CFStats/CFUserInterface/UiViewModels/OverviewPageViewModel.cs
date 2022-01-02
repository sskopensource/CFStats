using CFControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using UserInterface.CFControls.Models;
using UserInterface.Commands;
using UserInterface.Common;

namespace UserInterface
{
    public class OverviewPageViewModel:ViewModelBase
    {
        public BrickModel maxRating {get; private set;}
        public BrickModel contests {get; private set;}
        public BrickModel contributions {get; private set;}
        public BrickModel problemsSolved {get; private set;}
        public BrickModel friendsOf {get; private set;}
        public BrickModel blogs {get; private set;}

        public LongBrickModel name {get; private set;}
        public LongBrickModel rating {get; private set;}
        public LongBrickModel rank {get; private set;}
        public LongBrickModel organization {get; private set;}
        public LongBrickModel country {get; private set;}

        public AngularGaugeModel angularGauge { get; set; }

        public BitmapImage photo { get; private set; }

        public OverviewPageViewModel()
        {
            photo = new BitmapImage(new Uri(ApiHandler.ProfilePicture));

            int curRating= Int32.Parse(ApiHandler.Rating);
            angularGauge = new AngularGaugeModel() { Value = curRating };

            SetBricks();
            SetLongBricks();
        }

        private void SetBricks()
        {
            maxRating =new BrickModel() { ValueLabel = ApiHandler.maxRating};
            contests = new BrickModel() { ValueLabel = ApiHandler.Contests};
            contributions = new BrickModel() { ValueLabel = ApiHandler.Contributions};
            problemsSolved = new BrickModel() { ValueLabel = ApiHandler.ProblemsSolved};
            friendsOf = new BrickModel() { ValueLabel = ApiHandler.FriendsOf};
            blogs = new BrickModel() { ValueLabel = ApiHandler.Blogs};
        }

        private void SetLongBricks()
        {
            name = new LongBrickModel() { ValueLabel = ApiHandler.Name};
            rating = new LongBrickModel() { ValueLabel = ApiHandler.Rating, ValueColor = UiUtility.ConvertColorFromRank(ApiHandler.Rank) };
            rank = new LongBrickModel() { ValueLabel = ApiHandler.Rank, ValueColor=UiUtility.ConvertColorFromRank(ApiHandler.Rank)};
            organization = new LongBrickModel() { ValueLabel = ApiHandler.Organization};
            country = new LongBrickModel() { ValueLabel = ApiHandler.Country};
        }
    }
}
