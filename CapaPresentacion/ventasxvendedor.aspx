<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventasxvendedor.aspx.cs" Inherits="CapaPresentacion.ventasxvendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 373px;
        }
        .auto-style4 {
            height: 22px;
            width: 373px;
        }
        .auto-style5 {
            width: 100%;
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <table class="auto-style5">
            <tr>
                <td class="auto-style3">Clientes x Vendedor Mensualizado</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">Vendedor :
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" BorderStyle="Solid" Text="Buscar" Width="141px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
