<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComprarExcursion.aspx.cs" Inherits="ObligatorioParte2AP.ComprarExcursion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>DETALLES DE EXCURSIÓN</h1>
    <asp:Literal ID="LiteralDetalle" runat="server"></asp:Literal><br />
    <asp:Literal ID="LiteralDestinos" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnVolver" runat="server" Text="VOLVER" OnClick="BtnVolver_Click" />
</asp:Content>
