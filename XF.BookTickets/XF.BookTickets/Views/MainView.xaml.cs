﻿
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : Xamarin.Forms.TabbedPage
    {
        public MainView ()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetBarSelectedItemColor(Color.Red);
        }
    }
}