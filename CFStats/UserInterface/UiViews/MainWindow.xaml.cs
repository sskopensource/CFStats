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
using UserInterface.Pages;
namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new OverviewPage();
           // ApiHelper.InitializeClient();
        }
        //private async Task LoadApi()
        //{
        //    //var userInfo = await Api.UserInfoControl.LoadUserInfo(txtBox.Text);
        //    //var userStatus = await Api.UserStatusControl.LoadUserStatus(txtBox.Text);
        //    //var rating = userInfo.result[0].rating;
        //    //var maxRating = userInfo.result[0].maxRating;
        //    //var uriSource = new Uri(userInfo.result[0].titlePhoto, UriKind.Absolute);

        //    //HashSet<string> contestSet = new HashSet<string>();
        //    //HashSet<string> problemSet = new HashSet<string>();
        //    //foreach (var problems in userStatus.result)
        //    //{   
        //    //    var currentProblem = problems.problem.name.ToString();
        //    //    var currentContest = problems.contestId.ToString();
        //    //    var curVerdict = problems.verdict.ToString();
        //    //    var curParticipantType = problems.author.participantType.ToString();
        //    //    if (curVerdict == "OK")
        //    //    {
        //    //        problemSet.Add(currentProblem);
        //    //    }
        //    //    if (curParticipantType == "CONTESTANT")
        //    //    {
        //    //        contestSet.Add(currentContest);
        //    //    }

        //    //}
        //    //string name = "Welcome! ";
        //    //string firstname = userInfo.result[0].firstName;
        //    //string lastname = userInfo.result[0].lastName;
        //    //name += firstname+" "+lastname;
        //    //label.Content = name;
        //    //img.Source = new BitmapImage(uriSource);
        //    //ratingValueLabel.Content = rating;
        //    //maxratingValueLabel.Content = maxRating;
        //    //problemsValueLabel.Content = problemSet.Count;
        //    //contestValueLabel.Content = contestSet.Count;
        //}

        //private async void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    await LoadApi();
        //}

        //private async void button_click(object sender, routedeventargs e)
        //{
        //    await loadapi();
        //}

        //private void brick_loaded(object sender, routedeventargs e)
        //{

        //}
    }
}
