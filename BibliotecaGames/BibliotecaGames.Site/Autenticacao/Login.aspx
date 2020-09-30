<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaGames.Site.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>Usuario:</div>
            <div><asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox></div>
            <br />
            <div>Senha:</div>
            <div><asp:TextBox ID="TxtSenha" runat="server" TextMode="Password"></asp:TextBox></div>
            <div><asp:Button ID="BtnEntrar" Text="Entrar" runat="server" OnClick="BtnEntrar_Click" /></div>              
        </div>
    </form>
</body>
</html>
