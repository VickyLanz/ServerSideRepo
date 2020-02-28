<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="FirstWebApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Show WebForm
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Navigate</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/arrya stark.jpg" />
            <br />
            <br />
            <br />
            <asp:ListBox ID="lbox" runat="server" Height="145px" OnSelectedIndexChanged="lbox_SelectedIndexChanged" Width="318px">
                <asp:ListItem>Vignesh</asp:ListItem>
                <asp:ListItem>Kio Chan</asp:ListItem>
                <asp:ListItem>Scooby Dog</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
