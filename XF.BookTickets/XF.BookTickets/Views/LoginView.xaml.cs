using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView
	{
		public LoginView ()
		{
			InitializeComponent ();
            BindingContext = ServiceLocator.Instance.Resolve<LoginViewModel>();
		}
	}
}