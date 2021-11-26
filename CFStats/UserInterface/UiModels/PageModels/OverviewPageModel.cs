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
        private BrickModel _maxRating=new BrickModel();
        private BrickModel _contests = new BrickModel();
        private BrickModel _contributions = new BrickModel();
        private BrickModel _problemsSolved = new BrickModel();
        private BrickModel _friendsOf = new BrickModel();
        private BrickModel _blogs = new BrickModel();


        private LongBrickModel _name = new LongBrickModel();
        private LongBrickModel _rating = new LongBrickModel();
        private LongBrickModel _rank = new LongBrickModel();
        private LongBrickModel _organization = new LongBrickModel();
        private LongBrickModel _country = new LongBrickModel();

        private BitmapImage _photo;

        public OverviewPageModel(string imageLink)
        {
            _photo = new BitmapImage(new Uri(imageLink));
        }

        public BitmapImage Photo
        {
            get
            {
                return _photo;
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
