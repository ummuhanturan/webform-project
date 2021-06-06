 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="WebApplication1.GirisYap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/Login.css" />
    <style type="text/css">
        #form1 {
            height: 226px;
        }
    </style>
</head>
<body>
    <div class="wrapper fadeInDown">
        <div id="formContent" class="text-center">
            <form id="form1" runat="server">
                <asp:TextBox ID="TextBox1" placeholder="Email" runat="server" reqiured="required" Width="210px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox2" placeholder="Şifre" runat="server" reqiured="required" Width="210px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Giriş" OnClick="Button1_Click" Width="253px" />
                <asp:Button ID="Button2" runat="server" Text="Kayıt Ol" OnClick="Button2_Click" Width="253px" />
            </form>
        </div>
    </div>
</body>
</html>
