using System.Threading.Tasks;
using Xamarin.Forms;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;
using XF.BookTickets.Views;

namespace XF.BookTickets.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            Title = "Login";

            LoginCommand = new DelegateCommand<string>(Login, CanLogin)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => Password)
                .ObservesProperty(() => IsBusy);

            RegisterCommand = new DelegateCommand(
                () => {
                    ((NavigationPage)App.Current.MainPage).PushAsync(new RegisterView());
                },
                () => {
                    return IsNotBusy;
                }).ObservesProperty(() => IsBusy);
        }

        private bool CanLogin(string arg)
        {
            //return true;
            return IsNotBusy && (arg != null || (arg == null && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password)));
        }

        private async void Login(string obj)
        {
            IsBusy = true;
            await Task.Delay(1000);
            IsBusy = true;

            Application.Current.MainPage = new MainView();
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand<string> LoginCommand { get; set; }
        public DelegateCommand RegisterCommand { get; set; }
    }
}
