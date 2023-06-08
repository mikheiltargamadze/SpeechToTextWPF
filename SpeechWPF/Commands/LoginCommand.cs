using APISpeech;
using SpeechWPF.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SpeechWPF.Commands
{
    public class LoginCommand
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
                await new Nevisa().Login("hatefm69", "123456789");
                newSpeechViewModel.ResultText = "Logged in";
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
