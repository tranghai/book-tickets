using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XF.BookTickets.Models;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels.Base;
using XF.BookTickets.Views;

namespace XF.BookTickets.ViewModels
{
    public class InTheatresViewModel : ViewModelBase
    {
        public static Dictionary<Type, Type> Mapping { get; } = new Dictionary<Type, Type>();
        public List<MovieModel> ListInTheatres { get; set; }
        public InTheatresViewModel()
        {
            Title = "In Theatres";
            Icon = "in_theatres_7mdpi.png";
            ListInTheatres = MovieData.GetData();

            MovieDetailCommand = new DelegateCommand<object>(MovieDetail);
        }

        private async void MovieDetail(object obj)
        {
            MovieModel movie = (MovieModel)obj;

            var viewModel = ServiceLocator.Instance.Resolve(typeof(MovieDetailViewModel)) as ViewModelBase;

            var viewPage = (Page)Activator.CreateInstance(typeof(MovieDetailView)); 

            viewPage.BindingContext = viewModel;

            await ((NavigationPage)App.Current.MainPage).PushAsync(viewPage);
        }

        public DelegateCommand<object> MovieDetailCommand { get; set; }
    }
}
