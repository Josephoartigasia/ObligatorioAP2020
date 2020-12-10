<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaDeCompras.aspx.cs" Inherits="ObligatorioParte2AP.ListaDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LISTA DE COMPRAS REALIZADAS"></asp:Label><br />
    <asp:Literal ID="LtlComprasRealizadas" runat="server"></asp:Literal><br />
    <asp:Literal ID="LtlCostos" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnVolverIniCli" runat="server" Text="VOLVER" OnClick="BtnVolverIniCli_Click" />
</asp:Content>
