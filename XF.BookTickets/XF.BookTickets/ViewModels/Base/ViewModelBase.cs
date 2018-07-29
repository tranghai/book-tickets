using System;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.Services;
using XF.BookTickets.Services.Navigation;

namespace XF.BookTickets.ViewModels.Base
{
    public class ViewModelBase : Mvvm.BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _icon;
        public string Icon { get => _icon; set => _icon = value; }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value, () => RaisePropertyChanged(nameof(IsNotBusy)));
        }
        protected INavigationService NavigationService { get; }

        public ViewModelBase()
        {
            NavigationService = ServiceLocator.Instance.Resolve<INavigationService>();

            NavigateCommand = new DelegateCommand<object>(Navigate);
        }

        private void Navigate(object obj)
        {
            NavigationService.NavigateAsync((Type)obj);
        }

        public DelegateCommand<object> NavigateCommand { get; }
        public bool IsNotBusy => !IsBusy;
        public virtual void Init(object parameter = null)
        {

        }
    }
}
