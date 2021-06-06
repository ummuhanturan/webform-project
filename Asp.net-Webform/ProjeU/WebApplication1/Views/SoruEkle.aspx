<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SoruEkle.aspx.cs" Inherits="WebApplication1.Views.SoruEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/Register.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <<div class="wrapperT">
        <br />
        <br />
        <asp:DropDownList ID="soruEkleDropdown" runat="server" Width="300px">
            <asp:ListItem Value="Klasik">Klasik</asp:ListItem>
            <asp:ListItem Value="coktanSecmeli">Çoktan Seçmeli</asp:ListItem>
            <asp:ListItem Value="cokluSecmeli">Çoklu Seçmeli</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="soruEkle" Width="300px" CssClass="btn btn-success" Height="30px" runat="server" Text="Ekle" OnClick="soruEkle_Click" />
        <br />
        <br />
        <asp:Button runat="server" ID="btnComplete" Height="30px" Width="300px" CssClass="btn btn-success" Text="Sınavı Tamamla" OnClick="btnComplete_Click" />
    </div>
</asp:Content>
