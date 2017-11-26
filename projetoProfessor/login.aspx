<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="projetoProfessor.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="Content/style.css">
    <title></title>
</head>
<body>
	
	<div class="login-page">
      <div id="form_login" class="form_login">



        <form class="login-form" runat="server">
            <asp:TextBox ID="txtEmail" runat="server">Email</asp:TextBox>
            <asp:TextBox ID="txtSenha" runat="server">Senha</asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button" OnClick="btnLogin_Click"/>
          <p class="message">Não está cadastrado? <a href="cadastro.html">Criar uma conta</a></p>
        </form>
      </div>
    </div>
	
	</body>
</html>
