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

            ServiceLocator.Instance.RegisterViewModel<MainViewModel, MainView>();

            ServiceLocator.Instance.RegisterViewModel<InTheatresViewModel, InTheatresView>();
            ServiceLocator.Instance.RegisterViewModel<TheatresViewModel, TheatresView>();
            ServiceLocator.Instance.RegisterViewModel<NewsViewModel, NewsView>();
            ServiceLocator.Instance.RegisterViewModel<SettingViewModel, SettingView>();
            ServiceLocator.Instance.RegisterViewModel<UpComingViewModel, UpComingView>();

            ServiceLocator.Instance.RegisterViewModel<MovieDetailViewModel, MovieDetailView>();

            ServiceLocator.Instance.RegisterViewModel<LoginViewModel, LoginView>();
            ServiceLocator.Instance.RegisterViewModel<RegisterViewModel, RegisterView>();

            ServiceLocator.Instance.Build();
        }

		protected override void OnStart ()
		{
            ServiceLocator.Instance.Resolve<INavigationService>()
                .NavigateAsync(typeof(LoginViewModel));

           
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
