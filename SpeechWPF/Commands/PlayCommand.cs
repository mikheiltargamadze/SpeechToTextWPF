using SpeechWPF.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace SpeechWPF.Commands
{
    internal class PlayCommand
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public void Do()
        {

            var window = Application.Current.Windows.Cast<Window>().First();
            var MainWindow = (MainWindow)window;
            var speechViewModel = MainWindow.DataContext as SpeechViewModel;
            mediaPlayer.Open(new Uri(speechViewModel.UploadFilePath));
            mediaPlayer.Play();

        }
    }

}
