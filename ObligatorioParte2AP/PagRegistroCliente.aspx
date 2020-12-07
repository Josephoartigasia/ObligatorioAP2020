<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagRegistroCliente.aspx.cs" Inherits="ObligatorioParte2AP.PagRegistroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="LblCedulaCl" runat="server" Text="Ingresar Cédula"></asp:Label><asp:TextBox ID="TxtCedula" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblNombreCl" runat="server" Text="Ingresar Nombre"></asp:Label><asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblApellidoCl" runat="server" Text="Ingresar Apellido"></asp:Label><asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblContrasena" runat="server" Text="Ingresar Contraseña"></asp:Label><asp:TextBox ID="TxtContrasena" runat="server"></asp:TextBox><br />
    <asp:Button ID="BtnNuevoCliente" runat="server" Text="Registrarme" OnClick="BtnNuevoCliente_Click" /><br />
    <asp:Label ID="LblMsjRegistro" runat="server" Text=""></asp:Label>
</asp:Content>
