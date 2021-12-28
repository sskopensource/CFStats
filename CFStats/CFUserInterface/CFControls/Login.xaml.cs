using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface.CFControls
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public string ImgURL
        {
            get { return (string)GetValue(ImgURLProperty); }
            set { SetValue(ImgURLProperty, value); }
        }

        public static readonly DependencyProperty ImgURLProperty = DependencyProperty.Register("ImgURL", typeof(string), typeof(Login), new PropertyMetadata(""));

        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        public static readonly DependencyProperty UserNameProperty = DependencyProperty.Register("UserName", typeof(string), typeof(Login), new PropertyMetadata(null));

        public string ColorRank
        {
            get { return (string)GetValue(ColorRankProperty); }
            set { SetValue(ColorRankProperty, value); }
        }

        public static readonly DependencyProperty ColorRankProperty = DependencyProperty.Register("ColorRank", typeof(string), typeof(Login), new PropertyMetadata(null));

        public string Rank
        {
            get { return (string)GetValue(RankProperty); }
            set { SetValue(RankProperty, value); }
        }

        public static readonly DependencyProperty RankProperty = DependencyProperty.Register("Rank", typeof(string), typeof(Login), new PropertyMetadata(null));

        public ICommand LogoutCommand
        {
            get { return (ICommand)GetValue(LogoutCommandProperty); }
            set { SetValue(LogoutCommandProperty, value); }
        }

        public static readonly DependencyProperty LogoutCommandProperty = DependencyProperty.Register("LogoutCommand", typeof(ICommand), typeof(Login));

        public object LogoutCommandParameter
        {
            get { return (object)GetValue(LogoutCommandParameterProperty); }
            set { SetValue(LogoutCommandParameterProperty, value); }
        }

        public static readonly DependencyProperty LogoutCommandParameterProperty = DependencyProperty.Register("LogoutCommandParameter", typeof(object), typeof(Login));
    }
}