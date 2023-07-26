<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="dersler.aspx.cs" Inherits="okul_kayit_bootstrap.dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="background-color: burlywood" class="table table-bordered table-hover">

        <tr>
            <th>DERSLER</th>
            <th>MİNİMUM KONTENJAN</th>
            <th>MAKSİMUM KONTENJAN</th>
            <th>MEVCUT KONTENJAN</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("dersad") %></td>
                        <td><%#Eval("min") %></td>
                        <td><%#Eval("max") %></td>
                        <td><%#Eval("mevcut") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>

    </table>

</asp:Content>
