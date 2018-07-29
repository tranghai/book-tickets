using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;

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
                    NavigationService.NavigateAsync<LoginViewModel>();
                }
                );
        }

        public DelegateCommand LoginBackCommand { get; set; }
    }
}
