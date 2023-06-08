using APISpeech;
using SpeechWPF.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SpeechWPF.Commands
{
    internal class GetTextCommand
    {
        public async Task Do()
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

            try
            {
                var progressRoot = new ProgressRoot();
                while (!progressRoot.Complete)
                {
                    progressRoot = await new Nevisa().GetText(newSpeechViewModel.Progress_url);

                    newSpeechViewModel.ResultText = $"%{progressRoot.Progress.Percent}";
                    MainWindow.DataContext = newSpeechViewModel;
                }
                var finalSpeechViewModel = new SpeechViewModel
                {
                    Progress_url = newSpeechViewModel.Progress_url,
                    ResultText = newSpeechViewModel.ResultText,
                    UploadFilePath = newSpeechViewModel.UploadFilePath,
                };
                finalSpeechViewModel.ResultText = $"%{progressRoot.Result.Transcription.Text}";
                MainWindow.DataContext = finalSpeechViewModel;
            }
            catch (System.Exception ex)
            {
                var finalSpeechViewModel = new SpeechViewModel
                {
                    Progress_url = newSpeechViewModel.Progress_url,
                    ResultText = newSpeechViewModel.ResultText,
                    UploadFilePath = newSpeechViewModel.UploadFilePath,
                };
                finalSpeechViewModel.ResultText = ex.Message;
                MainWindow.DataContext = finalSpeechViewModel;

            }

        }
    }
}
