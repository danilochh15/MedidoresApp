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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuariosDALDB();
        private IMedidorDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.usuarioDDL.DataSource = this.usuariosDAL.ObtenerUsuarios();
                this.usuarioDDL.DataTextField = "Rut";
                this.usuarioDDL.DataValueField = "Id_usuario";
                this.usuarioDDL.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
            medidor.Id_usuario_fk = Convert.ToInt32(this.usuarioDDL.SelectedItem.Value);
            this.medidoresDAL.AgregarMedidor(medidor);

            Response.Redirect("MostrarMedidores.aspx");
        }
    }
}