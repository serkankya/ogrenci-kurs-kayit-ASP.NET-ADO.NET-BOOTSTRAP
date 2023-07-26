<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ogrenciDetay.aspx.cs" Inherits="okul_kayit_bootstrap.ogrenciDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label6" runat="server" Text="Öğrenci ID : "></asp:Label>
    <asp:TextBox ID="txtID" runat="server" CssClass="form form-control" ></asp:TextBox>

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

    <asp:Label ID="Label4" runat="server" Text="Öğrencinin Mevcut Sınıfı : "></asp:Label>
    <asp:TextBox ID="txtMevcutSinif" runat="server"></asp:TextBox>
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form form-control"  ></asp:DropDownList>

    <br />

    <asp:Label ID="Label5" runat="server" Text="Öğrencinin Mevcut Dersi : "></asp:Label>
    <asp:TextBox ID="txtMevcutDers" runat="server"></asp:TextBox>
    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form form-control" ></asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-success" OnClick="Button1_Click"  />
    <asp:Button ID="Button3" runat="server" Text="KAYDI SİL" CssClass="btn btn-danger" OnClick="Button3_Click" />
    <asp:Button ID="Button2" runat="server" Text="İPTAL ET" CssClass="btn btn-warning" OnClick="Button2_Click"  />
   
</asp:Content>
