using System;
using System.Collections.Generic;
using XF.BookTickets.Models;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;

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

            MovieDetailCommand = new DelegateCommand<object>(
                (object obj) => { NavigationService.NavigateAsync<MovieDetailViewModel>(obj); }
                );
        }


        public DelegateCommand<object> MovieDetailCommand { get; set; }
    }
}
