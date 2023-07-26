<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ogrenciListesi.aspx.cs" Inherits="okul_kayit_bootstrap.ogrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="background-color: burlywood" class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyadı</th>
            <th>Öğrenci Numarası</th>
            <th>Öğrenci Sınıfı</th>
            <th>Seçtiği Dersler</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("AD") %></td>
                        <td><%#Eval("SOYAD") %></td>
                        <td><%#Eval("NUMARA") %></td>
                        <td><%#Eval("SINIF") %></td>
                        <td><%#Eval("DERS") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/ogrenciDetay.aspx?ogrid="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>

                            <asp:HyperLink NavigateUrl='<%#"~/ogrenciDetay.aspx?ogrid="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-primary">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    

</asp:Content>
