<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="WebApplication1.Views.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/Register.css" />
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <style>
        body {
            color: #fff;
            background: #63738a;
            font-family: 'Roboto', sans-serif;
        }

        .form-control {
            height: 40px;
            box-shadow: none;
            color: #969fa4;
        }

            .form-control:focus {
                border-color: #5cb85c;
            }

        .form-control, .btn {
            border-radius: 3px;
        }

        .signup-form {
            width: 400px;
            margin: 0 auto;
            padding: 30px 0;
        }

            .signup-form h2 {
                color: #636363;
                margin: 0 0 15px;
                position: relative;
                text-align: center;
            }

                .signup-form h2:before, .signup-form h2:after {
                    content: "";
                    height: 2px;
                    width: 30%;
                    background: #d4d4d4;
                    position: absolute;
                    top: 50%;
                    z-index: 2;
                }

                .signup-form h2:before {
                    left: 0;
                }

                .signup-form h2:after {
                    right: 0;
                }

            .signup-form .hint-text {
                color: #999;
                margin-bottom: 30px;
                text-align: center;
            }

            .signup-form form {
                color: #999;
                border-radius: 3px;
                margin-bottom: 15px;
                background: #f2f3f7;
                box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
                padding: 30px;
            }

            .signup-form .form-group {
                margin-bottom: 20px;
            }

            .signup-form input[type="checkbox"] {
                margin-top: 3px;
            }

            .signup-form .btn {
                font-size: 16px;
                font-weight: bold;
                min-width: 140px;
                outline: none !important;
            }

            .signup-form .row div:first-child {
                padding-right: 10px;
            }

            .signup-form .row div:last-child {
                padding-left: 10px;
            }

            .signup-form a {
                color: #fff;
                text-decoration: underline;
            }

                .signup-form a:hover {
                    text-decoration: none;
                }

            .signup-form form a {
                color: #5cb85c;
                text-decoration: none;
            }

                .signup-form form a:hover {
                    text-decoration: underline;
                }
    </style>
</head>
<body>
    <div class="wrapper fadeInDown">
        <div id="formContent" class="text-center">
            <form id="form1" runat="server">
                <h2>Register</h2>
                <div class="form-group">
                    <div class="row">
                        <asp:TextBox ID="TextBox4" CssClass="form-control" reqiured="required" runat="server" placeholder="Adınız"></asp:TextBox>
                        <asp:TextBox ID="TextBox5" CssClass="form-control" reqiured="required" placeholder="Soyadınız" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row">
                        <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="Email" reqiured="required" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="Şifre" reqiured="required" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" reqiured="required" placeholder="Şifreyi Doğrula"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="row">
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success btn-lg btn-block" Text="Kayıt Ol" OnClick="Button1_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>

</body>
</html>
