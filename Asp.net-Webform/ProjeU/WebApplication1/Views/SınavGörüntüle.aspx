<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SınavGörüntüle.aspx.cs" Inherits="WebApplication1.Views.SınavGörüntüle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Content/Register.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapperT">
        <asp:TextBox runat="server" Width="300px" CssClass="form-control" ID="examCode"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" Width="300px" CssClass="btn btn-success" ID="redirectToExam" Text="Sınava Git!" OnClick="redirectToExam_Click"/>
    </div>
</asp:Content>
