using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
using Xamarin.Forms.Xaml;
using XF.BookTickets.Models;
using XF.BookTickets.Services;
using XF.BookTickets.ViewModels;

namespace XF.BookTickets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieDetailView
	{
        private string videoUrl = "https://www.youtube.com/embed/W--2bfOoR48";
        public MovieModel Movie { get; set; } 
        public MovieDetailView ()
		{
			InitializeComponent ();

            BindingContext = ServiceLocator.Instance.Resolve<MovieDetailViewModel>();

		}

        private void PlayStopButton_Clicked(object sender, System.EventArgs e)
        {
            if(PlayStopButton.Text == "Play")
            {
                CrossMediaManager.Current.Play("https://www.youtube.com/embed/W--2bfOoR48", MediaFileType.Video);

                PlayStopButton.Text = "Stop";
            }
            else if(PlayStopButton.Text == "Stop")
            {
                CrossMediaManager.Current.Stop();

                PlayStopButton.Text = "Play";
            }
        }
    }
}