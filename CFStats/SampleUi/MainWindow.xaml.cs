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

namespace SampleUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        iNotifyPerson obj = new iNotifyPerson();
        public MainWindow()
        {
            InitializeComponent();

            obj = new iNotifyPerson() { fName = "Bruce", lName = "Wayne" };
            this.DataContext = obj;
        }

        private void Blue_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Blue);
        }

        private void Red_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Red);
        }
    }
}
