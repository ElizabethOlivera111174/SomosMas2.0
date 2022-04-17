using Microsoft.AspNetCore.Http;
using Project.Domain.Helpers.HostFireBase;
using ProjectNC.Domain.Helpers.HostFireBase;

namespace Project.Core.Interfaces
{
    public class ImageService : IImageService
    {
        private FireBaseStorage _FireBaseStorage;
        public ImageService()
        {
            _FireBaseStorage = new FireBaseStorage();
        }
        public async Task<String> Save(string fileName, IFormFile image)
        {
            if (image != null)
            {
                if (ValidateFiles.ValidateImage(image))
                {
                    Stream Imagestream= image.OpenReadStream();
                     var responseFB = await _FireBaseStorage.UploadImage(Imagestream, fileName);
                    if (String.IsNullOrEmpty(responseFB))
                    {
                        throw new Exception("Error al guardar imagen. Detalle:" + responseFB);
                    }
                    return responseFB;
                }
                else
                    throw new Exception("Extensión de imagen no válida. Debe ser jpg, png o jpeg.");
            }
            else
                throw new Exception("Error, no existe imagen.");
        }
       /* public async Task<bool> Delete(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            else
            {
                string nameImage = await _s3AwsHelper.GetKeyFromUrl(name);
                FirebaseManagerResponse responseAws = await _s3AwsHelper.AwsFileDelete(nameImage);
                if (!String.IsNullOrEmpty(responseAws.Errors))
                    return false;
                return true;
            }
        }*/
    }
}