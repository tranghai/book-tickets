using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheatresView
    {
        public TheatresView()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Instance.Resolve<TheatresViewModel>();
        }

        private void ListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ((ListView)sender).SelectedItem = null;
        }
    }

    
}