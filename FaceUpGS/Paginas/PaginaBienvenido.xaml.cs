using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FaceUpGS.Modelos;

namespace FaceUpGS.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaBienvenido : ContentPage
    {
        Usuario usuario;

        public PaginaBienvenido(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            imagen.Source = ImageSource.FromFile(usuario.FotoActual);
            lblMensaje.Text = usuario.MensajeBienvenida;
        }
    }
}