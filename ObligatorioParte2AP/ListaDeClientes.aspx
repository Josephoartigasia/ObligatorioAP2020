<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeClientes.aspx.cs" Inherits="ObligatorioParte2AP.ListaDeClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LISTA DE USUARIOS REGISTRADOS"></asp:Label>
    <asp:Literal ID="LtlUsuariosRegistrados" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnVolver" runat="server" Text="VOLVER" OnClick="BtnVolver_Click" />
</asp:Content>
