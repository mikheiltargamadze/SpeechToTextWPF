using APISpeech;
using SpeechWPF.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SpeechWPF.Commands
{
    public class UploadCommand
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
                var resp = await new Nevisa().UploadFile(newSpeechViewModel.UploadFilePath);
                newSpeechViewModel.Progress_url = resp.ProgressUrl;
                newSpeechViewModel.ResultText = "Uploaded";
            }
            catch (System.Exception ex)
            {
                newSpeechViewModel.ResultText = ex.Message;
            }
            finally
            {

                MainWindow.DataContext = newSpeechViewModel;
            }


        }
    }

}
