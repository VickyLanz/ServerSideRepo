<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lbldate">
            &nbsp;
            Name:<asp:TextBox ID="txtName" runat="server" placeholder="First Name" style="margin-left: 3px" Width="203px"></asp:TextBox>
            <br />
            Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            Country:<asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddl_SelectedIndexChanged" Width="119px">
            </asp:DropDownList>
            <br />
            <asp:Calendar ID="cid" runat="server" BackColor="#3366FF" BorderColor="#FF66FF" OnSelectionChanged="cid_SelectionChanged"></asp:Calendar>
            <asp:Label ID="lbldate" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Hobbies"></asp:Label>
            :<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
            <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" style="margin-left: 0px" Width="127px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
