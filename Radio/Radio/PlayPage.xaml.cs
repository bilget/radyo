using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Radio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayPage : ContentPage
	{
        public interface IAudioPlayer
        {
            Task PlayAsync(string title);
            void Stop();
        }

        int clickcount = 0;
		public PlayPage ()
		{
			InitializeComponent ();
		}

        public void Play_Click(object sender, EventArgs e)
        {
            clickcount += 1;
            if(clickcount%2 == 0)
            {
                //pausing
                playButton.Command = new Command((obj) => {
                    DependencyService.Get<IAudioPlayer>().PlayAsync("http://radyoyayin.sabanciuniv.edu:8002/stream");
                });
                deneme.Text = "Paused!";
                playButton.Source = "play.png";
            }
            else
            {
                //playing
                playButton.Command = new Command((obj) => {
                    DependencyService.Get<IAudioPlayer>().Stop();
                });
                deneme.Text = "Playing..";
                playButton.Source = "pause.png";
            }
        }
	}
}