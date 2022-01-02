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
    public class LoginWindowViewModel : ViewModelBase
    {
        public string handle { get; set; }
        public Visibility loadingVisible { get; private set; }
        public Visibility loginVisible { get; private set; }
        public ICommand LoginCommand { get; }
        public ICommand CloseErrorDialog { get; }
        public bool NoInternetVisible { get; set; }
        public bool WrongHandleVisible { get; set; }

        public LoginWindowViewModel()
        {
            NoInternetVisible = false;
            WrongHandleVisible = false;
            loadingVisible = Visibility.Hidden;
            loginVisible = Visibility.Visible;
            LoginCommand = new DelegateCommand<Window>(Login);
            CloseErrorDialog = new DelegateCommand(CloseDialog);
        }

        private void CloseDialog()
        {
            NoInternetVisible = false;
            WrongHandleVisible = false;
            handle = "";

            OnPropertyChanged(nameof(NoInternetVisible));
            OnPropertyChanged(nameof(WrongHandleVisible));
            OnPropertyChanged(nameof(handle));
        }

        private async void Login(Window currWindow)
        {
            ShowLoading();
            await Task.Run(() =>
            {
                ApiStatus status = ApiHandler.LoadApiControl(handle);
                if (status == ApiStatus.NOINTERNET)
                {
                    ShowError(Dialog.NOINTERNET);
                }
                if (status == ApiStatus.FAILED)
                {
                    ShowError(Dialog.WRONGHANDLE);
                }
            });

            if (NoInternetVisible || WrongHandleVisible)
            {
                return;
            }

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

        private void ShowError(Dialog dialog)
        {
            if (dialog == Dialog.NOINTERNET)
            {
                NoInternetVisible = true;
                OnPropertyChanged(nameof(NoInternetVisible));
            }

            if (dialog == Dialog.WRONGHANDLE)
            {
                WrongHandleVisible = true;
                OnPropertyChanged(nameof(WrongHandleVisible));
            }

            loadingVisible = Visibility.Hidden;
            loginVisible = Visibility.Visible;
            OnPropertyChanged("loadingVisible");
            OnPropertyChanged("loginVisible");

        }
    }
}
