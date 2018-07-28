using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InTheatresView
	{
        public InTheatresView()
        {
            InitializeComponent();

            BindingContext = ServiceLocator.Instance.Resolve<InTheatresViewModel>();
        }

       
    }

}