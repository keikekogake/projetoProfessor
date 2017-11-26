using projetoProfessor.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoProfessor
{
    public partial class lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Querys exec = new Querys();

            List<Professor> list = exec.ConsultaProfessores();

            tbProfessor.DataSource = list;

            tbProfessor.DataBind();
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Server.Transfer("login.aspx");
        }
    }
}