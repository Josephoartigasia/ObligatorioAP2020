<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarCompra.aspx.cs" Inherits="ObligatorioParte2AP.EliminarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ELIMINAR EXCURSIÓN</h1>
    <asp:Label ID="Label1" runat="server" Text="DESEA ELIMINAR EXCURSIÓN?: "></asp:Label><asp:Literal ID="LtlNumExcursion" runat="server"></asp:Literal><br />
    <asp:Literal ID="LtlMsjEliminar" runat="server"></asp:Literal><br />
    <asp:Button ID="BtnEliminar" runat="server" Text="ELIMINAR" OnClick="BtnEliminar_Click" /><asp:Button ID="BtnVolver" runat="server" Text="VOLVER" OnClick="BtnVolver_Click" />
</asp:Content>
