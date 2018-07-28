using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpComingView
    {
        public UpComingView()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Instance.Resolve<UpComingViewModel>();
        }
    }
}