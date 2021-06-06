<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="CokluSecmeli.aspx.cs" Inherits="WebApplication1.Views.CokluSecmeli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/Register.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapperT">
        <asp:TextBox runat="server" ID="questionTB" TextMode="MultiLine" Width="200px" placeholder="Soru cümleciğini giriniz.."></asp:TextBox>
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
        <asp:ListBox runat="server" placeholder="Doğru cevaplar" Width="200px" ID="dogruCevaplarListBox"></asp:ListBox>
        <br />
        <asp:TextBox runat="server" ID="rightAnswer" Width="200px" placeholder="Doğru Cevap"></asp:TextBox>
        <br />
        <asp:Button runat="server" CssClass="btn btn-success" Width="200px" Text="Doğru Şık Ekle" ID="addrightAns" OnClick="addrightAns_Click"/>
        <br />
        <br />
        <asp:Button CssClass="btn btn-success" runat="server" Text="Soruyu Tamamla" Width="200px" OnClick="Unnamed1_Click" />
    </div>
</asp:Content>
