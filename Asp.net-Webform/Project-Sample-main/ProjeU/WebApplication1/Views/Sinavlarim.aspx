<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Sinavlarim.aspx.cs" Inherits="WebApplication1.Views.Sinavlarim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapperT">
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <div class="table-responsive">
                    <table class="table table-success">
                        <thead>
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Sınav Adı</th>
                                <th scope="col">Sınav Kodu</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                        </tbody>
                    </table>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%#Eval("Id")%>
                    </td>
                    <td>
                        <%#Eval("Name")%>
                    </td>
                    <td>
                        <%#Eval("examCode")%>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
