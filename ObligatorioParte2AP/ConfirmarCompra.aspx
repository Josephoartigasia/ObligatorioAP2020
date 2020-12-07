<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmarCompra.aspx.cs" Inherits="ObligatorioParte2AP.ConfirmarCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Código de Excursión"></asp:Label><asp:Literal ID="LiteralCodigo" runat="server"></asp:Literal><br />
    <asp:Label ID="Label1" runat="server" Text="Ingresar Cantidad Personas Mayores"></asp:Label><asp:TextBox ID="TxtMayores" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Ingresar Cantidad Personas Menores"></asp:Label><asp:TextBox ID="TxtMenores" runat="server"></asp:TextBox><br />
    <asp:Button ID="BtnConfirmar" runat="server" Text="CONFIRMAR" OnClick="BtnConfirmar_Click" /><asp:Button ID="BtnVolver" runat="server" Text="VOLVER" OnClick="BtnVolver_Click" />
    <asp:Literal ID="LiteralMsj" runat="server"></asp:Literal>
</asp:Content>
