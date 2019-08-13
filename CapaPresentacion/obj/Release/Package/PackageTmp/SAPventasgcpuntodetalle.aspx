<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAPventasgcpuntodetalle.aspx.cs" Inherits="CapaPresentacion.SAPventasgcpuntodetalle" %>

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
            height: 11px;
        }
        .auto-style36 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            color: #0033CC;
            font-size: small;
        }
        .auto-style3 {
            font-size: x-small;
            margin-top: 0px;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
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
        .auto-style40 {
            font-size: small;
        }
        .auto-style41 {
            text-decoration: underline;
        }
        .auto-style42 {
            color: #336699;
        }
        .auto-style43 {
            color: #CC0000;
            font-size: small;
        }
        .auto-style44 {
            color: #CC0000;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style35">
        <div>
    <div class="auto-style37">
    
        <strong>
        <span class="auto-style38">
        <br />
        VENTAS X PUNTO DE VENTA - NO INCLUYE IGV - SOLES<br />
        Punto de Venta :
        <asp:Label ID="lblPunto" runat="server" Text="Label"></asp:Label>
        <br />
        <span class="auto-style41">Vendedor : </span>
        </span>
    
        <span class="auto-style43">
        <asp:Label ID="lblVen" runat="server" CssClass="auto-style41" Text="Label"></asp:Label>
        <span class="auto-style41">&nbsp;/ </span>
        <asp:Label ID="lblVenD" runat="server" CssClass="auto-style41" Text="Label"></asp:Label>
        </span>
    
        <span class="auto-style40">
        <br class="auto-style42" />
        </span>
    
        <span class="auto-style38">
        Rango de Fecha de Consulta Desde :
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style44"></asp:Label>
&nbsp;Hasta
        <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style44"></asp:Label>
        <br />
        <br />
        <a href="javascript:window.history.back();">« Retornar a Resultado Anterior</a></span><span class="auto-style13"><br />
        </span>
        </strong>
    
        <span class="auto-style13">
        <table style="width:100%;">
            <tr>
                <td class="auto-style36" colspan="3">
 

        <asp:GridView ID="GridPuntoyVendedor" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="1200px" HorizontalAlign="Right"  ShowFooter="True" OnRowDataBound="GridPuntoyVendedor_RowDataBound" OnSelectedIndexChanged="GridPuntoyVendedor_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                <asp:BoundField DataField="DocNum" HeaderText="DocNum" SortExpression="DocNum" />
                <asp:BoundField DataField="AREA" HeaderText="Canal" />
                <asp:BoundField DataField="AREA" HeaderText="CanalDesc" />
                <asp:BoundField DataField="VENCOD" HeaderText="Cod.Ven." />
                <asp:BoundField DataField="VENDES" HeaderText="Vendedor" />
                <asp:BoundField DataField="CLICOD" HeaderText="RUC" />
                <asp:BoundField DataField="CLIDES" HeaderText="Razon Social" />
                <asp:BoundField DataField="FECHA" DataFormatString="{0:d}" HeaderText="Fecha" />
                <asp:BoundField DataField="DOC" HeaderText="Doc" />
                <asp:BoundField DataField="SERIE" HeaderText="Serie"></asp:BoundField>
                <asp:BoundField DataField="NUM" HeaderText="NroDoc" />
                <asp:BoundField DataField="TotalSoles" HeaderText="Sub-Total" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="FORMA" HeaderText="FormaPago" />
                <asp:CommandField HeaderText="Detalle de Factura" SelectText="Ver Detalle" ShowSelectButton="True" />
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
                    <br />
                    <br />
                    </td>
                
            </tr>
            <strong>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
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
                    <br class="auto-style40" />
                    <br class="auto-style40" />
                     <br class="auto-style40" />

        </strong>
        </div>
    </form>
</body>
</html>
