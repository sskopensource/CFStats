using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UserInterface
{
    public class LoginWindowViewModel:ViewModelBase
    {
        public string handle { get; set; }
        public Visibility loadingVisible { get; private set; }
        public Visibility loginVisible{ get; private set; }
        public ICommand LoginCommand { get;}
        public LoginWindowViewModel()
        {
            loadingVisible = Visibility.Hidden;
            loginVisible = Visibility.Visible;
            LoginCommand = new DelegateCommand<Window>(Login);
        }

        private async void Login(Window currWindow)
        {
            ShowLoading();
            await Task.Run(() =>
            {
                ApiHandler.LoadApiControl(handle);
            });
            MainWindow objPopupwindow = new MainWindow();
            objPopupwindow.Show();
            currWindow.Close();
        }

        private void ShowLoading()
        {
            loginVisible = Visibility.Hidden;
            loadingVisible = Visibility.Visible;
            OnPropertyChanged("loadingVisible");
            OnPropertyChanged("loginVisible");
        }
    }
}
