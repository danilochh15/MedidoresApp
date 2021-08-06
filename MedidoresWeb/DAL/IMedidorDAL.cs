using SistemaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWeb.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();

        List<Medidor> ObtenerMedidores(int idUsuario);

        void AgregarMedidor(Medidor medidor);

        void EliminarMedidor(int id);
    }
}
