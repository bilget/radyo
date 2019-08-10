using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.Media;

[assembly: Dependency(typeof(Radio.Droid.AudioPlayer))]
namespace Radio.Droid
{
    class AudioPlayer: PlayPage.IAudioPlayer 
    {
        MediaPlayer player = null;

        private async Task StartPlayerAsync(string title)
        {
            var resourceID = (int)typeof(Resource.Raw).GetField(title).GetValue(null);

            await Task.Run(() =>
            {
                if(player == null)
                {
                    player = new MediaPlayer();
                    player.SetAudioStreamType(Stream.Music);

                    player = MediaPlayer.Create(
                        global::Android.App.Application.Context, 
                        resourceID);
                    player.Looping = true;
                    player.Start();
                } else
                {
                    if(player.IsPlaying == true)
                    {
                        player.Pause();
                    } else
                    {
                        player.Start();
                    }
                }
            });
        }

        private void StopPlayer()
        {
            if ((player != null))
            {
                if (player.IsPlaying)
                {
                    player.Stop();
                }
                player.Release();
                player = null;
            }
        }

        public async Task PlayAsync(string title)
        {
            await StartPlayerAsync(title);
        }

        public void Stop()
        {
            StopPlayer();
        }
    }
}