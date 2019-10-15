<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gestion.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</head>
<body class="bg-dark text-white">
    <form id="form1" runat="server">
        <div class="container centered  center-block text-center col-md-4" role="main">
            <img src="images/elba.jpg" width="25%" />
            <h1> ELBA - Sistema de gestión </h1>

            <h2> Login: </h2>
            <div class="form-group col-lg-3">
                
                <asp:TextBox runat="server" CssClass="form-control center-block" ClientIDMode="Static" id="txtUsuario" placeholder="Usuario"></asp:TextBox>
                <asp:TextBox runat="server" TextMode="Password" CssClass="form-control center-block" ClientIDMode="Static" id="txtPassword" placeholder="Contraseña"></asp:TextBox>
                <asp:Button CssClass="btn btn-outline-light btn-block  center-block" runat="server" Text="Ingresar" ID="btnLogin" ClientIDMode="Static" />
           </div>
           
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
