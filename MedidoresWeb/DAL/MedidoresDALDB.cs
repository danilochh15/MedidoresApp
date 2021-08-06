using SistemaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedidoresWeb.DAL
{
    public class MedidoresDALDB : IMedidorDAL
    {
        private sistemaEntities sistema = new sistemaEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            this.sistema.Medidors.Add(medidor);
            this.sistema.SaveChanges();
        }

        public void EliminarMedidor(int id)
        {
            //buscar medidor asociado al id
            Medidor medidor = this.sistema.Medidors.Find(id);
            //Eliminar el asistente
            this.sistema.Medidors.Remove(medidor);
            this.sistema.SaveChanges();
        }

        public Medidor Obtener(int id)
        {
            return this.sistema.Medidors.Find(id);
        }

        public void Actualizar(Medidor m)
        {
            Medidor mOriginal = this.sistema.Medidors.Find(m.Id_usuario_fk);
            mOriginal.Id_usuario_fk = m.Id_usuario_fk;
            this.sistema.SaveChanges();
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.sistema.Medidors.ToList();
        }

        public List<Medidor> ObtenerMedidores(int idUsuario)
        {
            //LINQ
            var query = from m in this.sistema.Medidors
                        where m.Id_usuario_fk == idUsuario
                        select m;
            return query.ToList();
        }

       
    }
}