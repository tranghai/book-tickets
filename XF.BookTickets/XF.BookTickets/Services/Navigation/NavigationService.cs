using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public static Dictionary<Type, Type> Mapping { get; } = new Dictionary<Type, Type>();

        static NavigationService()
        {

        }

        public NavigationService()
        {

        }


        public async Task NavigateAsync(Type viewModelType, object parameter)
        {
            var viewType = Mapping[viewModelType]; // typeof(LoginView)

            var viewPage = (Page)Activator.CreateInstance(viewType); // new LoginView()

            var viewModel = ServiceLocator.Instance.Resolve(viewModelType) as ViewModelBase;

            viewPage.BindingContext = viewModel;


            if (viewPage is TabbedPage)
            {
                Application.Current.MainPage = new NavigationPage(viewPage);
            }
            else
            {
                NavigationPage navigationPage = null;

                if (Application.Current.MainPage is NavigationPage)
                {
                    navigationPage = (NavigationPage)Application.Current.MainPage;
                }
                else if (Application.Current.MainPage == null)
                {
                    Application.Current.MainPage = navigationPage = new NavigationPage();
                }

                await navigationPage.PushAsync(viewPage);

                if (Application.Current.MainPage is MasterDetailPage m)
                {
                    m.IsPresented = false;
                }
            }
            
        }
        public Task NavigateAsync(Type viewModelType)
        {
            return NavigateAsync(viewModelType, null);
        }
        public Task NavigateAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return NavigateAsync(typeof(TViewModel), null);
        }

        public Task NavigateAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return NavigateAsync(typeof(TViewModel), parameter);
        }
    }
}
