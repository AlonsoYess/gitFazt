<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientegrupo.aspx.cs" Inherits="CapaPresentacion.clientegrupo" %>

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
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style35">
        <div>
    <div class="auto-style37">
    
        <div class="auto-style39">
                    <span class="auto-style38">
            <strong>VENTAS AGRUPADO POR CLIENTE - NO INCLUYE IGV SOLES<br />
        Rango de Fecha de Consulta Desde :
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;Hasta
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
            </strong>
        <a href="javascript:window.history.back();"><strong>&laquo; Volver a Resultado Anterior</strong></a><strong>
                     

        </strong>
    
        </span>
    
            <strong>
    
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
 

        <asp:GridView ID="GridPuntoyVendedor" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="900px" HorizontalAlign="Right"  ShowFooter="True" OnRowDataBound="GridPuntoyVendedor_RowDataBound" OnSelectedIndexChanged="GridPuntoyVendedor_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="CanalCod" HeaderText="Canal" />
                <asp:BoundField DataField="CanalDesc" HeaderText="CanalDesc" />
                <asp:BoundField DataField="Vendedor" HeaderText="Vend.Cod." />
                <asp:BoundField DataField="VenDes" HeaderText="Vend. Descrip." />
                <asp:BoundField DataField="RUC" HeaderText="Ruc" />
                <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                <asp:BoundField DataField="SubTotal" HeaderText="Sub-Total" DataFormatString="{0:###,###.00}" />
                <asp:CommandField HeaderText="Documentos Venta" SelectText="Ver Detalle" ShowSelectButton="True" />
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
