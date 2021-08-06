using MedidoresWeb.DAL;
using SistemaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class MostrarMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidoresDALDB();
        private void CargarGrilla(List<Medidor> medidores)
        {
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        } 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarGrilla(this.medidoresDAL.ObtenerMedidores());
            }
        }

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar por tanto, tengo que eliminar el cliente

                int id = Convert.ToInt32(e.CommandArgument);
                medidoresDAL.EliminarMedidor(id);
                CargarGrilla(this.medidoresDAL.ObtenerMedidores());
            }
        }
    }
}