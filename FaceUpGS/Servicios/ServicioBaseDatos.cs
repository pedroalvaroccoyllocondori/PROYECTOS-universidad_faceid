﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FaceUpGS.Datos;
using FaceUpGS.Helpers;
using FaceUpGS.Modelos;


namespace FaceUpGS.Servicios
{
    public class ServicioBaseDatos : IServicioBaseDatos
    {
        private readonly BaseDatos bd;

        public ServicioBaseDatos()
        {
            bd = new BaseDatos(Constantes.NombreBD);
        }

        public async Task<Usuario> ObtenerUsuario(string key)
        {
            try
            {
                return await bd.Usuarios.FirstOrDefaultAsync(x => x.Key == key);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> RegistrarUsuario(Usuario dato)
        {
            try
            {
                await bd.Usuarios.AddAsync(dato);
                await bd.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> ActualizarUsuario(Usuario dato)
        {
            try
            {
                bd.Usuarios.Update(dato);
                await bd.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                return false;
            }
        }
    }
}
