using Xamarin.Forms;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;
using XF.BookTickets.Views;

namespace XF.BookTickets.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        public RegisterViewModel()
        {
            Title = "Register";

            LoginBackCommand = new DelegateCommand(
                () =>
                {
                    ((NavigationPage)App.Current.MainPage).PushAsync(new LoginView());
                }
                );
        }

        public DelegateCommand LoginBackCommand { get; set; }
    }
}
