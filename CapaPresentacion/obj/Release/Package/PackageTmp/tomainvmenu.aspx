<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tomainvmenu.aspx.cs" Inherits="CapaPresentacion.tomainvmenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style11 {
            color: #0033CC;
        }
        .auto-style40 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        .auto-style49 {
            color: #000099;
            }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style61 {
            width: 269px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 393px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        TOMA DE INVENTARIO <br />
        <span class="auto-style11">
                <span class="auto-style24">Click para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style61">
                    <strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Generar Toma de Inventario" CssClass="auto-style49" Width="350px" Font-Bold="True" BorderStyle="Solid" />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style61">
                    <strong>
        <asp:Button ID="btnVentaPBuscar2" runat="server" Text="Estados y Reporte de Toma de Inventario" CssClass="auto-style49" Width="350px" Font-Bold="True" BorderStyle="Solid" OnClick="btnVentaPBuscar2_Click" />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style61">
                    <strong>
        <asp:Button runat="server" Text="Ingresar Conteos" CssClass="auto-style49" Width="350px" Font-Bold="True" BorderStyle="Solid" OnClick="btnVentaPBuscar0_Click1" />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style61">
                    &nbsp;</td>
            </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>
