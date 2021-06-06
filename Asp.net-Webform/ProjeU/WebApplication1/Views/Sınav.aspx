<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Sınav.aspx.cs" Inherits="WebApplication1.Views.Sınav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper" style="margin-left:20px;height:auto;">
        <div class="row" style="margin-left:20px; width:500px; height:auto;">
            <asp:TextBox ID="tbKlasik" runat="server" Width="500px" TextMode="MultiLine" Rows="5" CssClass="form-control" Enabled="false"></asp:TextBox>
            <asp:TextBox runat="server" Width="500px" TextMode="MultiLine" Rows="5" Text="Cevabı Giriniz!" CssClass="form-control"></asp:TextBox>
            <br />
        </div>
        <div class="row" style="margin-left:20px; width:500px;height:auto;">
            <br />
            <br />
            <asp:TextBox ID="tbCokluSecmeli" runat="server" Width="500px" TextMode="MultiLine" Rows="5" CssClass="form-control" Enabled="false"></asp:TextBox>
            <asp:CheckBoxList ID="cblCokluSecmeli" runat="server" Width="300px" style="height:max-content;"></asp:CheckBoxList>
            <br />
            <br />
        </div>
        <div class="row" style="margin-left:20px; width:500px;height:auto;">
            <br />
            <br />
            <asp:TextBox ID="tbCoktanSecmeli" runat="server" Width="500px" TextMode="MultiLine" Rows="5" CssClass="form-control" Enabled="false"></asp:TextBox>
            <asp:RadioButtonList ID="rblCoktanSecmeli" runat="server" style="height:max-content;" Width="300px"></asp:RadioButtonList>
        </div>
        <asp:Button runat="server" ID="btnComplete" Width="300px" CssClass="btn btn-success" Text="Sınavı Tamamla" OnClick="btnComplete_Click"/>
    </div>
</asp:Content>
