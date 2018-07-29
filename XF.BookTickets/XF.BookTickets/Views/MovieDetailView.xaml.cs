using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Models;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieDetailView 
    {
		public MovieDetailView ()
		{
			InitializeComponent ();
            BindingContext = ServiceLocator.Instance.Resolve<MovieDetailViewModel>();

            Random random = new Random();

            int id = random.Next(1, 8);

            List<MovieModel> movies = MovieData.GetData();

            MovieModel movie = movies.Where(m => m.Id == id).FirstOrDefault();

            MovieDetail.BindingContext = movie;

        }
	}
}