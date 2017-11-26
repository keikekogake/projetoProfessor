using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using projetoProfessor.DAO;

namespace projetoProfessor
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Querys exec = new Querys();
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if(exec.Login(email, senha))
            {
                Server.Transfer("lista.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Usuário e/ou senha inválido');</script>");
            }
        }


    }
}