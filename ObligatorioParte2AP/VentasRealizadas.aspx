<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentasRealizadas.aspx.cs" Inherits="ObligatorioParte2AP.VentasRealizadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="VENTAS REALIZADAS POR PERÍODO"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Fecha Inicio"></asp:Label><asp:TextBox ID="TxtFechaIni" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Fecha Final"></asp:Label><asp:TextBox ID="TxtFechaFin" runat="server"></asp:TextBox><br />
    <asp:Literal ID="LiteralListaVentas" runat="server"></asp:Literal><br />
    <asp:Label ID="Label4" runat="server" Text="MONTO TOTAL $: "></asp:Label>
    <asp:Literal ID="LiteralMontoTotal" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnBuscar" runat="server" Text="BUSCAR" OnClick="BtnBuscar_Click" /><asp:Button ID="BtnSalir" runat="server" Text="SALIR" OnClick="BtnSalir_Click" />
</asp:Content>
