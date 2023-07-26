<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ogrenciEkle.aspx.cs" Inherits="okul_kayit_bootstrap.ogrenciEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="message" runat="server" Text="Label" Visible="false" ></asp:Label>
    <br />

    <asp:Label ID="Label1" runat="server" Text="Öğrenci Adı : "></asp:Label>
    <asp:TextBox ID="txtAd" runat="server" CssClass="form form-control" ></asp:TextBox>

    <br />

    <asp:Label ID="Label2" runat="server" Text="Öğrenci Soyadı : "></asp:Label>
    <asp:TextBox ID="txtSoyad" runat="server" CssClass="form form-control"></asp:TextBox>

    <br />

    <asp:Label ID="Label3" runat="server" Text="Öğrenci Numarası : "></asp:Label>
    <asp:TextBox ID="txtNumara" runat="server" CssClass="form form-control"></asp:TextBox>

    <br />

    <asp:Label ID="Label4" runat="server" Text="Öğrenci Sınıfı : "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form form-control"  ></asp:DropDownList>

    <br />

    <asp:Label ID="Label5" runat="server" Text="Alacağı Ders : "></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form form-control" ></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-success" OnClick="Button1_Click" />

    <asp:Button ID="Button2" runat="server" Text="TEMİZLE" CssClass="btn btn-danger" />
</asp:Content>
