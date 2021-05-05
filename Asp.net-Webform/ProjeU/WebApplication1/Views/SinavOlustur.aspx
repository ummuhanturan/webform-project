<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SinavOlustur.aspx.cs" Inherits="WebApplication1.Views.SınavOlustur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .wp {
            margin-left: 40px;
            margin-top: 40px;
            width: 350px;
        }

        #RadioButtonList1 {
            margin-top: 50px;
            display: flex;
            flex-direction: row;
            flex-wrap: nowrap;
            justify-content: flex-start;
            align-items: flex-start;
            align-content: stretch;
        }

        #cspanel {
            margin-top: 50px;
            display: flex;
            flex-direction: column;
            flex-wrap: nowrap;
            justify-content: flex-start;
            align-items: flex-start;
            align-content: stretch;
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper wp">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="96px" Width="310px">
            <asp:ListItem Text="Klasik" Value="Klasik"></asp:ListItem>
            <asp:ListItem Text="Çoktan Seçmeli" Value="Çoktan Seçmeli"></asp:ListItem>
            <asp:ListItem Text="Çoklu Seçmeli" Value="Çoklu Seçmeli"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Ekle" OnClick="Button1_Click1" />
    </div>
    <div class="wrapper">
        <asp:Panel ID="Klasik" runat="server" Visible="False">
            <asp:Label ID="Label1" runat="server" Text="Soruyu giriniz.."></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Soruyu Ekle" />
        </asp:Panel>
        <asp:Panel ID="CS" runat="server" Visible="False">
            <div id="cspanel">
                <asp:Label ID="Label2" runat="server" Text="Soru :"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Cevaplar :"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Ekle" OnClick="Button2_Click1" />
                <asp:ListBox ID="ListBox1" runat="server" Width="140px"></asp:ListBox>
                <asp:Button ID="Button3" runat="server" Text="Soruyu Ekle" OnClick="Button3_Click" />
            </div>
        </asp:Panel>
        <asp:Panel ID="CLS" runat="server" Visible="False">
        </asp:Panel>
    </div>

</asp:Content>
