﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoProfessor
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Server.Transfer("login.aspx");
        }
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Server.Transfer("lista.aspx");
        }
    }
}