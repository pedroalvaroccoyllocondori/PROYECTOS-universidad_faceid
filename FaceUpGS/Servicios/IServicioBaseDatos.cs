using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FaceUpGS.Modelos;
namespace FaceUpGS.Servicios
{
    public interface IServicioBaseDatos
    {
        Task<Usuario> ObtenerUsuario(string key);
        Task<bool> RegistrarUsuario(Usuario dato);
        Task<bool> ActualizarUsuario(Usuario dato);
    }
}
