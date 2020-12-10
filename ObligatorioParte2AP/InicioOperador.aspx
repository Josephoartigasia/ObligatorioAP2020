<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioOperador.aspx.cs" Inherits="ObligatorioParte2AP.InicioOperador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>OPCIONES OPERADOR</h1>
    <asp:Button ID="BtnVentas" runat="server" Text="VENTAS REALIZADAS" OnClick="BtnVentas_Click" /><br />
    <asp:Button ID="BtnClientes" runat="server" Text="CLIENTES" OnClick="BtnClientes_Click" /><br />
    <asp:Button ID="BtnEstadisticas" runat="server" Text="ESTADISTICAS" OnClick="BtnEstadisticas_Click" /><br />
    <asp:Button ID="BtnSalir" runat="server" Text="SALIR" OnClick="BtnSalir_Click" />
</asp:Content>
