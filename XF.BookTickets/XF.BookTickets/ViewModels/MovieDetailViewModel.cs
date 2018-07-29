using XF.BookTickets.Models;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.ViewModels
{
    public class MovieDetailViewModel : ViewModelBase
    {
        public MovieModel Movie { get; set; }
        public string Detail { get; set; }
        public MovieDetailViewModel()
        {
            Title = "Detail";
            Detail = "Demo Page Detail";
        }

        public override void Init(object parameter = null)
        {
            Movie = (MovieModel)parameter;
        }
    }
}
