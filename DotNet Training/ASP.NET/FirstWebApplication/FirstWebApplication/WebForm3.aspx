<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FirstWebApplication.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label>
            :<asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Validate Form.aspx">Navigate To Validate Form</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" />
            <br />
            <asp:GridView ID="gv" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
