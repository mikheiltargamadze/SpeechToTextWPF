using SpeechWPF.Commands;
using SpeechWPF.Infra;

namespace SpeechWPF.Model
{
    public class SpeechViewModel
    {
        public string ResultText { get; set; }
        public string UploadFilePath { get; set; }
        public string Progress_url { get; set; }
        public bool CanExecutePlayCommand => !string.IsNullOrEmpty(UploadFilePath);
        public bool CanExecuteUploadFileCommand => !string.IsNullOrEmpty(UploadFilePath);
        public bool CanExecuteGetTextCommand => !string.IsNullOrEmpty(Progress_url);
        public RelayActionCommand PlayCommand => new RelayActionCommand()
        {
            CanExecuteAction = n => CanExecutePlayCommand,
            ExecuteAction = (p) => { new PlayCommand().Do(); }
        };
        public RelayActionCommand LoginCommand => new RelayActionCommand()
        {
            CanExecuteAction = n => true,
            ExecuteAction = async (p) => { await new LoginCommand().Do(); }
        };
        public RelayActionCommand UploadCommand => new RelayActionCommand()
        {
            CanExecuteAction = n => CanExecuteUploadFileCommand,
            ExecuteAction = async (p) => { await new UploadCommand().Do(); }
        };
        public RelayActionCommand GetTextCommand => new RelayActionCommand()
        {
            CanExecuteAction = n => CanExecuteGetTextCommand,
            ExecuteAction = async (p) => { await new GetTextCommand().Do(); }
        };
        public RelayActionCommand BrowseCommand => new RelayActionCommand()
        {
            CanExecuteAction = n => true,
            ExecuteAction = (p) => { new BrowseCommand().Do(); }
        };
    }
}
