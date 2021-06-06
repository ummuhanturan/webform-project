<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OgretmenAnasayfa.aspx.cs" Inherits="WebApplication1.Views.OgretmenAnasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <style>
        .link {
            color: white !important;
            font-size: 20px;
            font-weight: bold;
            width: auto;
            margin-left:20px;
        }

        .navbar {
            display: flex;
            flex-direction: row;
            justify-content: flex-start;
            background-color: #c23616;
            height: 70px;
            margin: auto;
            padding-left:30px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <asp:LinkButton ID="LinkButton1" CssClass="link" runat="server">Ders Ekle</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" CssClass="link" runat="server">Sınav Oluştur</asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" CssClass="link" runat="server">Sınavlarım</asp:LinkButton>
        </div>
    </form>
</body>
</html>
