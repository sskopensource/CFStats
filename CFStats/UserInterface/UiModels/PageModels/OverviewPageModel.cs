using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using CFControls;

namespace UserInterface
{
    public class OverviewPageModel
    {
        private BrickModel _maxRating;
        private BrickModel _contests;
        private BrickModel _contributions;
        private BrickModel _problemsSolved;
        private BrickModel _friendsOf;
        private BrickModel _blogs;

        private LongBrickModel _name;
        private LongBrickModel _rating;
        private LongBrickModel _rank;
        private LongBrickModel _organization;
        private LongBrickModel _country;

        private BitmapImage _photo;

        public OverviewPageModel(string imageLink)
        {
            MaxRating = new BrickModel();
            Contests = new BrickModel();
            Contributions = new BrickModel();
            ProblemsSolved = new BrickModel();
            FriendsOf = new BrickModel();
            Blogs = new BrickModel();

            Name = new LongBrickModel();
            Rating = new LongBrickModel();
            Rank = new LongBrickModel();
            Organization = new LongBrickModel();
            Country = new LongBrickModel();

            Photo = new BitmapImage(new Uri(imageLink));
        }

        public BitmapImage Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
            }
        }

        public BrickModel MaxRating
        {
            get
            {
                return _maxRating;
            }
            set
            {
                _maxRating = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public BrickModel Contests
        {
            get
            {
                return _contests;
            }
            set
            {
                _contests = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public BrickModel Contributions
        {
            get
            {
                return _contributions;
            }
            set
            {
                _contributions = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public BrickModel ProblemsSolved
        {
            get
            {
                return _problemsSolved;
            }
            set
            {
                _problemsSolved = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public BrickModel FriendsOf
        {
            get
            {
                return _friendsOf;
            }
            set
            {
                _friendsOf = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public BrickModel Blogs
        {
            get
            {
                return _blogs;
            }
            set
            {
                _blogs = value;
                //  OnPropertyChanged("MaxRating");
            }
        }

        public LongBrickModel Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public LongBrickModel Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                _rank = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public LongBrickModel Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public LongBrickModel Organization
        {
            get
            {
                return _organization;
            }
            set
            {
                _organization = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
        public LongBrickModel Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                //  OnPropertyChanged("MaxRating");
            }
        }
    }
}
