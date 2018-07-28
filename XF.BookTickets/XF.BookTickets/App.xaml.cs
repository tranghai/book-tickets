using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Services;
using XF.BookTickets.Services.Navigation;
using XF.BookTickets.ViewModels;
using XF.BookTickets.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.BookTickets
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

#if DEBUG
            LiveReload.Init();
#endif

            //ServiceLocator.Instance.Register<INavigationService, NavigationService>();

            ServiceLocator.Instance.Register<INavigationService, NavigationService>();

            ServiceLocator.Instance.Register<InTheatresViewModel>();
            ServiceLocator.Instance.Register<TheatresViewModel>();
            ServiceLocator.Instance.Register<NewsViewModel>();
            ServiceLocator.Instance.Register<SettingViewModel>();
            ServiceLocator.Instance.Register<UpComingViewModel>();

            ServiceLocator.Instance.Register<MovieDetailViewModel>();

            ServiceLocator.Instance.Register<LoginViewModel>();
            ServiceLocator.Instance.Register<RegisterViewModel>();

            ServiceLocator.Instance.Build();

            MainPage = new NavigationPage(new LoginView());
        }

		protected override void OnStart ()
		{
            //ServiceLocator.Instance.Resolve<INavigationService>()
            //    .NavigateAsync(typeof(LoginViewModel));

           
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
