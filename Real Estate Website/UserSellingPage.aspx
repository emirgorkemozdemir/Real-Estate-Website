<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserSellingPage.aspx.cs" Inherits="Asp_Emlak_Sitesi_Kurs.UserSellingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post">
       <h2>Kullanıcı Satış Sayfası</h2>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="tboxTitle" placeholder="Başlık giriniz" runat="server" Width="370px"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="tboxPrice" placeholder="Fiyat giriniz" runat="server" Width="370px"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:DropDownList ID="DropDownListCity" AutoPostBack="true" OnSelectedIndexChanged="DropDownListCity_SelectedIndexChanged"  runat="server"  Height="33px" Width="376px"></asp:DropDownList>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:DropDownList ID="DropDownListHood" runat="server"  Height="33px" Width="376px"></asp:DropDownList>
        </p>
        <p>&nbsp;</p>
        <p>
               <asp:DropDownList ID="DropDownListRoom" runat="server"  Height="33px" Width="376px"></asp:DropDownList>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:TextBox ID="tboxPhoto" placeholder="Fotoğraf linki giriniz"  runat="server" Width="370px"></asp:TextBox>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:DropDownList ID="DropDownListType" AutoPostBack="true" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" runat="server" Height="33px" Width="376px">
            </asp:DropDownList>
        </p>

        <p>
            <asp:Button ID="btnAddProperty" CssClass="btn btn-danger" OnClick="btnAddProperty_Click" runat="server" Text="Ekle" />
        </p>
    </form>
</asp:Content>
