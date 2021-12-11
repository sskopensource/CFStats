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
        private string _handle;
        private Visibility _loadingVisible = Visibility.Hidden;
        private Visibility _loginVisible = Visibility.Visible;
        public Visibility LoadingVisible
        {
            get
            {
                return _loadingVisible;
            }
            set
            {
                _loadingVisible = value;
                OnPropertyChanged("LoadingVisible");
            }
        }

        public Visibility LoginVisible
        {
            get
            {
                return _loginVisible;
            }
            set
            {
                _loginVisible = value;
                OnPropertyChanged("LoginVisible");
            }
        }

        public string Handle
        {
            get
            {
                return _handle;
            }
            set
            {
                _handle = value;
            }
        }
        public ICommand LoginCommand { get; private set; }
        public LoginWindowViewModel()
        {
            LoginCommand = new DelegateCommand<Window>(Login);
        }
        private async void Login(Window currWindow)
        {
            ShowLoading();
            await Task.Run(() =>
            {
                ApiHandler.LoadApiControl(Handle);
            });
            MainWindow objPopupwindow = new MainWindow();
            objPopupwindow.Show();
            currWindow.Close();
        }

        private void ShowLoading()
        {
            LoginVisible = Visibility.Hidden;
            LoadingVisible = Visibility.Visible;
        }
    }
}
