using Microsoft.Win32;
using SpeechWPF.Model;
using System.Linq;
using System.Windows;

namespace SpeechWPF.Commands
{
    internal class BrowseCommand
    {
        public void Do()
        {
            var window = Application.Current.Windows.Cast<Window>().First();
            var MainWindow = (MainWindow)window;
            var speechViewModel = MainWindow.DataContext as SpeechViewModel;
            var newSpeechViewModel = new SpeechViewModel
            {
                Progress_url = speechViewModel.Progress_url,
                ResultText = speechViewModel.ResultText,
                UploadFilePath = speechViewModel.UploadFilePath,
            };

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                newSpeechViewModel.UploadFilePath = openFileDialog.FileName;

            MainWindow.DataContext = newSpeechViewModel;
        }
    }

}
