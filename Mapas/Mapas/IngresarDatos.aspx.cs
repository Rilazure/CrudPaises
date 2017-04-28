using Bel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mapas
{
    public partial class IngresarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        Bll bb = new Bll();
            if (IsPostBack)
            {

            }
            else
            {
                DrlPais.DataSource = bb.CargarDrlB();
                DrlPais.DataTextField = "Pais";
                DrlPais.DataValueField = "IdPais";
                DrlPais.DataBind();
                DrlPais.Items.Insert(0, "ok");

            }

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Bll bb = new Bll();
            bb.InsertUsuarioB(TxtNombre.Text, (int)Session["Perfil"]);
            Session.Clear();
        }

        protected void DrlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bll bb = new Bll();
            if (DrlPais.SelectedIndex > 0)
            {

                Session.Add("Perfil", DrlPais.SelectedIndex);
                int datoDrlPais = DrlPais.SelectedIndex;
                
                DrlCiudad.DataSource = bb.CargarDrlCiudades(DrlPais.SelectedIndex);
                DrlCiudad.DataTextField = "Ciudad";
                DrlCiudad.DataValueField = "IdCiudad";
                DrlCiudad.DataBind();
                DrlCiudad.Items.Insert(0, "ok");
            }

        }

        protected void GvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Bll bb = new Bll();
            if (e.CommandName =="Delete")
            {
                int i = Convert.ToInt32(e.CommandArgument);
                string index = GvUsuarios.Rows[i].Cells[1].Text;    
                bb.EliminarB(Convert.ToInt32 (index));
                GvUsuarios.DataSource = bb.ConsultarUsuariosB();
                GvUsuarios.DataBind();
            }            
            
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Bll bb = new Bll();
            GvUsuarios.DataSource = bb.ConsultarUsuariosB();
            GvUsuarios.DataBind();
        }
    }
}