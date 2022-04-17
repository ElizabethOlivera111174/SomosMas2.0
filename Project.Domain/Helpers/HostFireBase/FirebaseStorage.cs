using Firebase.Auth;
using Firebase.Storage;
using Microsoft.AspNetCore.Http;

namespace ProjectNC.Domain.Helpers.HostFireBase
{
    public class FireBaseStorage
    {
        private static readonly string ApiKey = "AIzaSyCB_2EXazB6VvtH2wdk2I_EFXAD3JN4fYw";
        private static readonly string Bucket = "somosmas-264e6.appspot.com";
        private static readonly string AuthEmail = "datanetcomerce@gmail.com";
        private static readonly string AuthPassword = "datanet123";

       public StreamContent ConvertBase64ToStream(IFormFile img)
        {
            var ms = new MemoryStream();
            img.CopyTo(ms);
            var fileBytes = ms.ToArray();
            string s = Convert.ToBase64String(fileBytes);
            byte[] imageStringToBase64 = Convert.FromBase64String(s);
            StreamContent streamContent = new(new MemoryStream(imageStringToBase64));
            return streamContent;
        }
        
        // public StreamContent ConvertBase64ToStream(string imageFromRequest)
        // {
        //     byte[] imageStringToBase64 = Convert.FromBase64String(imageFromRequest);
        //     StreamContent streamContent = new(new MemoryStream(imageStringToBase64));
        //     return streamContent;
        // }

        public async Task<string> UploadImage(Stream stream, String fileName)
        {
            string imageFromFirebaseStorage = "";
            FirebaseAuthProvider firebaseConfiguration = new(new FirebaseConfig(ApiKey));

            FirebaseAuthLink authConfiguration = await firebaseConfiguration
                .SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

            CancellationTokenSource cancellationToken = new();

            FirebaseStorageTask storageManager = new FirebaseStorage(Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authConfiguration.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child("Archivo")
                .Child(fileName)
                .PutAsync(stream, cancellationToken.Token);

            try
            {
                imageFromFirebaseStorage = await storageManager;
            }
            catch
            {
            }
            return imageFromFirebaseStorage;
        }
    }
}
