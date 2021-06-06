<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="WebApplication1.Views.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/Register.css" />
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <div class="card">
            </div>
        </div>
                <div class="card-body">
                    <asp:TextBox ID="TextBox4" CssClass="form-control" reqiured="required" Width="300px" runat="server" placeholder="Adınız"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox5" CssClass="form-control" reqiured="required" Width="300px" placeholder="Soyadınız" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="Email" Width="300px" reqiured="required" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="Şifre" Width="300px" reqiured="required" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Width="300px" reqiured="required" placeholder="Şifreyi Doğrula"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Width="300px" Text="Kayıt Ol" OnClick="Button1_Click" />
                    <br />
                </div>
    </form>
</body>
</html>
