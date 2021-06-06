<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KlasikSoru.aspx.cs" Inherits="WebApplication1.Views.KlasikSoru" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/Register.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapperT">
        <asp:TextBox runat="server" Width="300px" TextMode="MultiLine" ID="tbKlasikSoru"></asp:TextBox>
        <br />
        <asp:Button CssClass="btn btn-success" Width="300px" runat="server" Text="Ekle" OnClick="Unnamed2_Click" />
    </div>
</asp:Content>
