<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lista.aspx.cs" Inherits="projetoProfessor.lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="Content/style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="tbProfessor" runat="server"></asp:GridView>
            <br /><br /><br />
            <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar Novo"/>
            <br /><br />
            <asp:Button ID="btnSair" runat="server" Text="Sair" OnClick="btnSair_Click" />
        </div>
    </form>
</body>
</html>
