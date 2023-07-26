<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="siniflar.aspx.cs" Inherits="okul_kayit_bootstrap.siniflar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="background-color: burlywood" class="table table-bordered table-hover">

        <tr>
            <th>SINIFLAR</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>
                    <tr>
                        <td><%#Eval("sinif") %></td>

                    </tr>
                </ItemTemplate>

            </asp:Repeater>
        </tbody>

    </table>

</asp:Content>
