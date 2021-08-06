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
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        private IUsuarioDAL usuarioDAL = new UsuariosDALDB();
        private void CargarGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuarios.DataSource = usuarios;
            this.grillaUsuarios.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarGrilla(this.usuarioDAL.ObtenerUsuarios());
            }
        }

        protected void grillaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar por tanto, tengo que eliminar el cliente

                int id = Convert.ToInt32(e.CommandArgument);
                usuarioDAL.EliminarUsuario(id);
                CargarGrilla(this.usuarioDAL.ObtenerUsuarios());
            }
        }
    }
}