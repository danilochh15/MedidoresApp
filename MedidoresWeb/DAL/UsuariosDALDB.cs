using SistemaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedidoresWeb.DAL
{
    public class UsuariosDALDB : IUsuarioDAL
    {
        private sistemaEntities sistema = new sistemaEntities();

        public void AgregarUsuario(Usuario usuario)
        {
            this.sistema.Usuarios.Add(usuario);
            this.sistema.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            //Buscar usuario asistente al id
            Usuario usuario = this.sistema.Usuarios.Find(id);
            //Eliminar el asistente
            this.sistema.Usuarios.Remove(usuario);
            this.sistema.SaveChanges();
        }

        public void Actualizar(Usuario usuario)
        {
            Usuario uOriginal = this.sistema.Usuarios.Find(usuario.Id_usuario);
            uOriginal.Nombre = usuario.Nombre;
            uOriginal.Rut = usuario.Rut;
            uOriginal.Email = usuario.Email;
            uOriginal.Contrasena = usuario.Contrasena;
        }


        public List<Usuario> ObtenerUsuarios()
        {
            return this.sistema.Usuarios.ToList();
        }

        public Usuario Obtener(int id)
        {
            return this.sistema.Usuarios.Find(id);
        }
    }
}