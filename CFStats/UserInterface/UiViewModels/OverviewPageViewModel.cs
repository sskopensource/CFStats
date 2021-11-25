using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class OverviewPageViewModel
    {
        public OverviewPageModel _overviewPageModel;
        public OverviewPageModel overviewPageModel
        {
            get
            {
                return _overviewPageModel;
            }
            set
            {
                _overviewPageModel = value;
            }
        }

        public OverviewPageViewModel()
        {
            overviewPageModel = new OverviewPageModel();

            //setting value of usercontrols on overview pages
            SetBricks(overviewPageModel);
            SetLongBricks(overviewPageModel);
        }

        private void SetBricks(OverviewPageModel overviewPageModel)
        {
            overviewPageModel.MaxRating.ValueLabel = ApiHandler.maxRating;
            overviewPageModel.Contests.ValueLabel = ApiHandler.Contests;
            overviewPageModel.Contributions.ValueLabel = ApiHandler.Contributions;
            overviewPageModel.ProblemsSolved.ValueLabel = ApiHandler.ProblemsSolved;
            overviewPageModel.FriendsOf.ValueLabel = ApiHandler.FriendsOf;
            overviewPageModel.Blogs.ValueLabel = ApiHandler.Blogs;
        }

        private void SetLongBricks(OverviewPageModel overviewPageModel)
        {
            overviewPageModel.Name.ValueLabel = ApiHandler.Name;
            overviewPageModel.Rating.ValueLabel = ApiHandler.Rating;
            overviewPageModel.Rank.ValueLabel = ApiHandler.Rank;
            overviewPageModel.Organization.ValueLabel = ApiHandler.Organization;
            overviewPageModel.Country.ValueLabel = ApiHandler.Country;
        }
    }
}
