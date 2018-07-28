using Xamarin.Forms;

namespace XF.BookTickets.Views.Base
{
    public class ViewBase : ContentPage
    {
        public ViewBase()
        {
            SetBinding(TitleProperty, new Binding("Title"));
            SetBinding(IsBusyProperty, new Binding("IsBusy"));
            SetBinding(IconProperty, new Binding("Icon"));
        }
    }
}
