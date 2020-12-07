<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PagInicio.aspx.cs" Inherits="ObligatorioParte2AP.PagInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ingreso al sistema</h1>
    <asp:Label ID="LblUsuario" runat="server" Text="Usuario"></asp:Label><asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblContrasena" runat="server" Text="Contraseña"></asp:Label><asp:TextBox ID="TxtContrasena" runat="server"></asp:TextBox><br />
    <asp:Label ID="LblRol" runat="server" Text="Tipo de Usuario"></asp:Label>
    <asp:RadioButton ID="RBtnCliente" runat="server" Text="Cliente" GroupName="Usuarios" value="Cliente"/>
    <asp:RadioButton ID="RBtnOperador" runat="server" Text="Operador" GroupName="Usuarios" value="Operador"/><br />
    <asp:Button ID="BtnIngresar" runat="server" Text="INGRESAR" OnClick="BtnIngresar_Click" />
    <asp:Button ID="BtnRegistrarse" runat="server" Text="REGISTRARSE" OnClick="BtnRegistrarse_Click" /><br />
    <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
</asp:Content>
