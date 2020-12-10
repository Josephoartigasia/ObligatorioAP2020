<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioCliente.aspx.cs" Inherits="ObligatorioParte2AP.InicioCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>EXCURSIONES DISPONIBLES</h1>
    <asp:Literal ID="LiteralTabla" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnComprasRealizadas" runat="server" Text="EXCURSIONES COMPRADAS" OnClick="BtnComprasRealizadas_Click" /><asp:Button ID="BtnSalir" runat="server" Text="SALIR" OnClick="BtnSalir_Click" />
</asp:Content>
