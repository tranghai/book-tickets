using Xamarin.Forms;

namespace XF.BookTickets.Controls
{
    public class MyEntry : ContentView
    {

        public static readonly BindableProperty MyProperty =
    BindableProperty.Create(nameof(My), typeof(string), typeof(MyEntry));

        public string My
        {
            get => (string)GetValue(MyProperty);
            set => SetValue(MyProperty, value);
        }
    }
}
