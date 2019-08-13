<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientedoc.aspx.cs" Inherits="CapaPresentacion.clientedoc" %>

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
            color: #0000CC;
            font-size: small;
        }
        .auto-style41 {
            color: #990000;
            font-size: small;
        }
        </style>

    
</head>
<body>
    <form id="form1" runat="server" class="auto-style35">
        <div>
    <div class="auto-style37">
    
        <div class="auto-style39">
            <strong>
                 <span class="auto-style40">&nbsp;DETALLE DE DOCUMENTO DE VENTA</span><span class="auto-style38"><br />

        </span>
    
            <span class="auto-style40">
        CLIENTE RUC :
            </span>
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style41"></asp:Label>
        <span class="auto-style40">
&nbsp;RAZON SOCIAL 
            : 
        </span>
                <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style41"></asp:Label>

        
    
            <span class="auto-style38">
        <br />
        <br />
        <a href="javascript:window.history.back();">&laquo; Volver a Resultado Anterior</a>

        </span>
    
        <span class="auto-style13">
        <br />
        </span>
 

        </strong>
    
        <span class="auto-style13">
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style36" colspan="3">
 

                    <br />
    
        <span class="auto-style13">
 

        <asp:GridView ID="GridClienteDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="900px" HorizontalAlign="Right"  ShowFooter="True" OnRowDataBound="GridPuntoyVendedor_RowDataBound" OnSelectedIndexChanged="GridPuntoyVendedor_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="PrecioSoles" HeaderText="Precio S/" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="SubtotalSoles" HeaderText="Subtotal S/" DataFormatString="{0:###,###.00}" />
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
