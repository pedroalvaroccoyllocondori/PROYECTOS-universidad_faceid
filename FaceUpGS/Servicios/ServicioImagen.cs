using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace FaceUpGS.Servicios
{
    public static class ServicioImagen
    {
        public static async Task<MediaFile> TomarFoto()
        {
            MediaFile foto = null;

            try
            {
                await CrossMedia.Current.Initialize();

                if (CrossMedia.Current.IsCameraAvailable || CrossMedia.Current.IsTakePhotoSupported)
                {
                    //foto = await CrossMedia.Current.PickPhotoAsync(); //galeria de fotos
                    foto = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory = "Pictures",
                        Name = "emotion.jpg"
                    });
                }
            }
            catch (Exception ex)
            {

            }

            return foto;
        }
    }
}
