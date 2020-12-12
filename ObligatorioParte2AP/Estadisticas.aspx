<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="ObligatorioParte2AP.Estadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ESTADÍSTICAS</h1><br />
    <asp:Label ID="Label2" runat="server" Text="Buscar Excursiones por Destino"></asp:Label><br />
    <asp:Label ID="Label1" runat="server" Text="Destino"></asp:Label><asp:TextBox ID="TxtDestino" runat="server"></asp:TextBox>
    <asp:Button ID="BtnBuscar" runat="server" Text="BUSCAR" OnClick="BtnBuscar_Click" /><br />
    <asp:Literal ID="LiteralExcursionesPorDestino" runat="server"></asp:Literal><br />
    <asp:Label ID="Label3" runat="server" Text="Buscar Destino en mayor cantidad de Excursiones "></asp:Label><br />
    <asp:Button ID="BtnDestMasExc" runat="server" Text="BUSCAR" OnClick="BtnDestMasExc_Click" /><br />
    <asp:Literal ID="LiteralDestinoEnMasExc" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnSalir" runat="server" Text="SALIR" OnClick="BtnSalir_Click" />

</asp:Content>
