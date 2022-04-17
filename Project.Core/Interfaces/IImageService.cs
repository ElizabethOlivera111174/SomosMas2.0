using Microsoft.AspNetCore.Http;

namespace Project.Core.Interfaces
{
    public interface IImageService
    {
        Task<String> Save(string fileName, IFormFile image);

       // Task<bool> Delete(string name);

    }
}