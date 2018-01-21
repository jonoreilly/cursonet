<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="gaia.webforms.test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    	<asp:Button ID="btnConectar" runat="server" OnClick="btnConectar_Click" Text="Conectar" />
&nbsp;&nbsp;&nbsp;
		<asp:DropDownList ID="DropDownListTerritorios" runat="server" OnSelectedIndexChanged="DropDownListTerritorios_SelectedIndexChanged">
		</asp:DropDownList>
		<asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333">
			<AlternatingItemStyle BackColor="White" ForeColor="#284775" />
			<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
			<ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
			<SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
		</asp:DataList>
    </form>
</body>
</html>
