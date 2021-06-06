<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="WebApplication1.Views.DersEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .body{
            margin-top: 500px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper fadeInDown">
        <div id="formContent" class="text-center">
            <div class="form-group" id="form1">
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="TextBox1" placeholder="Ders Adı" runat="server" reqiured="required"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="TextBox2" placeholder="Ders Kodu" runat="server" reqiured="required"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Ekle" OnClick="Button1_Click" />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
