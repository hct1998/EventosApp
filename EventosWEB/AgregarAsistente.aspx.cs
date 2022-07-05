using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class AgregarAsistente : System.Web.UI.Page
    {

        private IAsistentesDAL asistentesDAL = new AsistenteDALDB();



        protected void Page_Load(object sender, EventArgs e)
        {

        }


       protected void AgregarAsis_Click(object sender, EventArgs e)
        {
            string rut = this.rutTxt.Text.Trim();
            string nombre = this.nombreTxt.Text.Trim();
            string apellido = this.apellidoTxt.Text.Trim();
            string edad = this.edadTxt.Text.Trim();
            string empresa = this.empresaTxt.Text.Trim();
            string estado = this.estadoTxt.Text.Trim();


        }
















    }
}