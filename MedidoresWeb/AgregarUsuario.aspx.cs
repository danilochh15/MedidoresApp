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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = this.nombreTxt.Text.Trim();
            usuario.Rut = this.rutTxt.Text.Trim();
            usuario.Contrasena = this.contrasenaTxt.Text.Trim();
            usuario.Email = this.emailTxt.Text.Trim();
            this.usuariosDAL.AgregarUsuario(usuario);

            Response.Redirect("MostrarUsuarios.aspx");
        }
    }
}