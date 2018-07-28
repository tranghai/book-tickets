using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView
    {
        public RegisterView()
        {
            InitializeComponent();

            BindingContext = ServiceLocator.Instance.Resolve<RegisterViewModel>();

            country.ItemsSource = countryCode;
            country.SelectedIndex = 1;
        }

        List<string> countryCode = new List<string>()
            { "+84" , "+85", "+86", "+87","+88","+89", "+90" };
    }
}