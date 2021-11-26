using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace UserInterface
{
    public class OverviewPageViewModel
    {
        private OverviewPageModel _overviewPageModel;
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
            Console.WriteLine("Called: OverviewPageViewModel");
            overviewPageModel = new OverviewPageModel(ApiHandler.ProfilePicture);

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

        public string MaxRating
        {
            get
            {
                return overviewPageModel.MaxRating.ValueLabel;
            }
        }

        public string Contests
        {
            get
            {
                return overviewPageModel.Contests.ValueLabel;
            }
        }

        public string Contributions
        {
            get
            {
                return overviewPageModel.Contributions.ValueLabel;
            }
        }

        public string ProblemsSolved
        {
            get
            {
                return overviewPageModel.ProblemsSolved.ValueLabel;
            }
        }

        public string FriendsOf
        {
            get
            {
                return overviewPageModel.FriendsOf.ValueLabel;
            }
        }

        public string Blogs
        {
            get
            {
                return overviewPageModel.Blogs.ValueLabel;
            }
        }

        public string Name
        {
            get
            {
                return overviewPageModel.Name.ValueLabel;
            }
        }

        public string Rating
        {
            get
            {
                return overviewPageModel.Rating.ValueLabel;
            }
        }

        public string Rank
        {
            get
            {
                return overviewPageModel.Rank.ValueLabel;
            }
        }

        public string Organization
        {
            get
            {
                return overviewPageModel.Organization.ValueLabel;
            }
        }

        public string Country
        {
            get
            {
                return overviewPageModel.Country.ValueLabel;
            }
        }
    }
}
