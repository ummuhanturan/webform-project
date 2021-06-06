<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="CoktanSecmeli.aspx.cs" Inherits="WebApplication1.Views.CoktanSecmeli" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/Register.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapperT">
        <asp:TextBox runat="server" ID="soruCumlesi" TextMode="MultiLine" Width="200px" placeholder="Soru cümleciğini giriniz.."></asp:TextBox>
        <br />
        <br />
        <asp:ListBox runat="server" placeholder="Şıklar" Width="200px" ID="siklarListBox"></asp:ListBox>
        <br />
        <br />
        <asp:TextBox runat="server" Width="200px" ID="siklarEkle"></asp:TextBox>
        <br />
        <asp:Button CssClass="btn btn-success" runat="server" Width="200px" ID="addAnswer" Text="Şık Ekle" OnClick="addAnswer_Click" />
        <br />
        <br />
        <asp:TextBox runat="server" ID="rightAnswer" Width="200px" placeholder="Doğru Cevap"></asp:TextBox>
        <br />
        <br />
        <asp:Button CssClass="btn btn-success" runat="server" Text="Soruyu Tamamla" Width="200px" OnClick="Unnamed1_Click" />
    </div>
</asp:Content>
