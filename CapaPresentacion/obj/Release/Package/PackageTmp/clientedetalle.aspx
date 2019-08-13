<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientedetalle.aspx.cs" Inherits="CapaPresentacion.clientedetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style13 {
            color: #0033CC;
            font-size: small;
        }
        .auto-style35 {
            height: 38px;
        }
        .auto-style36 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            color: #0033CC;
            font-size: small;
        }
        .auto-style37 {
            width: 532px;
            height: 235px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style38 {
            color: #336699;
            font-size: small;
        }
        .auto-style39 {
            text-align: left;
            width: 875px;
            height: 79px;
        }
        .auto-style3 {
            font-size: x-small;
            margin-top: 0px;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style40 {
            color: #003399;
            font-size: medium;
        }
        .auto-style41 {
            color: #990000;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style35">
        <div>
    <div class="auto-style37">
    
        <div class="auto-style39">
            <span class="auto-style40"><strong>LISTADO DE DOCUMENTOS DE VENTA</strong></span><strong><br class="auto-style40" />
                    <span class="auto-style40">
            RUC Cliente&nbsp; : <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style41"></asp:Label>
            &nbsp;Razon Social :&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style41"></asp:Label>

        </span>
                    <span class="auto-style38">
        <br />
            <br />
            <a href="javascript:window.history.back();">&laquo; Volver a Resultado Anterior</a></span></strong><span class="auto-style13"></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style36" colspan="3">
 

                    <br />
    
        <span class="auto-style13">
 

        <asp:GridView ID="GridPuntoyVendedor" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="1500px" HorizontalAlign="Right"  ShowFooter="True" OnRowDataBound="GridPuntoyVendedor_RowDataBound" OnSelectedIndexChanged="GridPuntoyVendedor_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="DocNum" HeaderText="Nro.Doc" />
                <asp:BoundField DataField="RUC" HeaderText="RUC" />
                <asp:BoundField DataField="RazonSocial" HeaderText="RazonSocial" />
                <asp:BoundField DataField="VenCod" HeaderText="Cod.Ven" />
                <asp:BoundField DataField="VenDes" HeaderText="Vendedor" />
                <asp:BoundField DataField="CodEmpresa" HeaderText="Empresa" />
                <asp:BoundField DataField="FechaEmision" HeaderText="F.Emision" />
                <asp:BoundField DataField="NroFactura" HeaderText="Nro.Factura" SortExpression="NroFactura" />
                <asp:BoundField DataField="Doc" HeaderText="Tipo" SortExpression="Doc" />
                <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda" />
                <asp:BoundField DataField="IGV" DataFormatString="{0:###,###.00}" HeaderText="IGV S/" SortExpression="IGV" />
                <asp:BoundField DataField="SubTotal" DataFormatString="{0:###,###.00}" HeaderText="SubTotal S/" SortExpression="SubTotal" />
                <asp:BoundField DataField="Total" HeaderText="Total S/" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="FormaPago" HeaderText="FormaPago" SortExpression="FormaPago" />
                <asp:CommandField HeaderText="Detalle Factura" SelectText="Ver Detalle" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        </span>
                    <br />
                    </td>
            </tr>
            <strong>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </strong> 
        </span>
    
    </div>
            <strong>
                    <br />
                    <br />
 

        </strong>
        </div>
    </form>
</body>
</html>
