<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminRemove.aspx.cs" Inherits="Asp_Emlak_Sitesi_Kurs.AdminRemove" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="AdminRemoveComplete.aspx?selectedid=<%# Eval("PropertyID") %>">
                <div style="width: 1100px; min-height: 150px; margin: 10px; padding: 20px; border: 1px solid #dadada; display: flex; flex-direction: row; justify-content: space-between; align-items: center">
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("PropertyPhotos") %>' runat="server" Width="260px" Height="130px" />
                    <h2><%# Eval("PropertyTitle") %></h2>
                    <h2><%# Eval("PropertyPrice") %></h2>
                </div>
            </a>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>
