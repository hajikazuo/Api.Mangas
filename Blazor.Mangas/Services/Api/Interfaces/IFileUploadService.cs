namespace Blazor.Mangas.Services.Api.Interfaces
{
    public interface IFileUploadService
    {
        Task<HttpResponseMessage> UploadFileAsync(
            string endpoint, MultipartFormDataContent content);
    }
}
