<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Asp_Emlak_Sitesi_Kurs.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <style>
        .mytbox {
            width: 250px;
            height: 40px;
            margin-top: 20px;
        }

        .mybutton {
            width: 250px;
            height: 40px;
            margin-top: 20px;
        }
    </style>
    <title></title>
</head>
<body>

    <form id="form1" runat="server" method="post" style="display: flex; flex-direction: column; height: 500px; margin-left: 20px">
        <h2>Giriş Yap</h2>
       
        <asp:TextBox CssClass="form-control mytbox" ID="tboxMail" placeholder="Mail adresinizi giriniz" runat="server"></asp:TextBox>
        <asp:TextBox CssClass="form-control mytbox" ID="tboxPassword" placeholder="Şifrenizi giriniz" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button CssClass="btn btn-danger mybutton" ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
    </form>
</body>
</html>