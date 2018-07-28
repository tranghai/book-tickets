using System;
using System.Threading.Tasks;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.Services.Navigation
{
    public interface INavigationService
    {
        Task NavigateAsync(Type viewModelType, object parameter);
        Task NavigateAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;
        Task NavigateAsync(Type viewModelType);
        Task NavigateAsync<TViewModel>() where TViewModel : ViewModelBase;
    }
}
