using Flurl.Http;
using SpeechWPF.SpeechAPI;
using System.Threading.Tasks;

namespace APISpeech
{
    internal class Nevisa
    {
        string loginUrl = "https:url";
        string uploadFileUrl = "/recognize-file";
        string baseUrl = "https://api.url.com";
        public async Task Login(string userName, string password)
        {
            var resp = await loginUrl.PostJsonAsync(new { username_or_phone_or_email = userName, password = password });
            var result = await resp.GetJsonAsync<AuthorizeRoot>();
            Token.Write(result);
        }
        public async Task<ResultRecognizeFile> UploadFile(string path)
        {
            var token = Token.Read<AuthorizeRoot>();
            var resp = await $"{baseUrl}{uploadFileUrl}"
                .PostMultipartAsync(mp => mp
                .AddStringParts(new { auth_token = token.User.Token, api_key = token.User.NevisaServiceAccount.CurrentServiceRecord.Key })         // multiple strings
                .AddFile("file", path)                    // local file path
                .AddUrlEncoded("urlEnc", new { bar = "y" }) // URL-encoded                      
                );
            var resultRecognizeFile = await resp.GetJsonAsync<ResultRecognizeFile>();
            return resultRecognizeFile;
        }
        public async Task<ProgressRoot> GetText(string progress_url)
        {
            return await $"{baseUrl}{progress_url}".GetJsonAsync<ProgressRoot>();
        }
    }
}
