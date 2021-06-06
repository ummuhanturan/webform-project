<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SınavaGir.aspx.cs" Inherits="WebApplication1.Views.SınavaGir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../Content/bootstrap.min.css"/>
    <link rel="stylesheet" href="../Content/Register.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapperT">
            <asp:TextBox runat="server" Width="300px" CssClass="form-control" ID="examCode" placeholder="Sınav kodunu giriniz!"></asp:TextBox>
            <br />
            <asp:Button runat="server" Width="300px" CssClass="btn btn-success" Text="Sınava Gir!" ID="btnSınav" OnClick="btnSınav_Click"/>
        </div>
    </form>
</body>
</html>
