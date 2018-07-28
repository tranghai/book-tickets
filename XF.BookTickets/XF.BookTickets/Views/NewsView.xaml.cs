using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsView
    {
        public NewsView()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Instance.Resolve<NewsViewModel>();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            ((ListView)sender).SelectedItem = null;
        }
    }
}