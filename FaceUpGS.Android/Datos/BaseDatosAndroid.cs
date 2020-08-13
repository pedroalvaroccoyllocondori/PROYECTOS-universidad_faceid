using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Xamarin.Forms;
using FaceUpGS.Droid.Datos;
using FaceUpGS.Datos;
using FaceUpGS.Helpers;

[assembly: Dependency(typeof(BaseDatosAndroid))]

namespace FaceUpGS.Droid.Datos
{
    public class BaseDatosAndroid : IBaseDatos
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal),
                    Constantes.NombreBD);
        }
    }
}