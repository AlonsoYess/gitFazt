<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAPventasgcpv.aspx.cs" Inherits="CapaPresentacion.SAPventasgcpv" %>

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
            height: 69px;
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
            <strong>VENTAS X PUNTO DE VENTA - NO INCLUYE IGV SOLES<br />
        Rango de Fecha de Consulta Desde :
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;Hasta
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
            </strong>
        <a href="javascript:window.history.back();"><strong>&laquo; Volver a Resultado Anterior</strong></a></span><strong><span class="auto-style13"><br />
        </span>
 

        </strong>
    
        <span class="auto-style13">
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style36" colspan="3">
 

                    <br />
    
        <span class="auto-style13">
 

        <asp:GridView ID="GridPuntoyVendedor" runat="server" AutoGenerateColumns="False" CellPadding="3" CssClass="auto-style3" Width="700px" HorizontalAlign="Right"  ShowFooter="True" OnRowDataBound="GridPuntoyVendedor_RowDataBound" OnSelectedIndexChanged="GridPuntoyVendedor_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="174px">
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Canal" />
                <asp:BoundField DataField="AREA" HeaderText="CanalDesc" />
                <asp:BoundField DataField="VENCOD" HeaderText="Vend.Cod." />
                <asp:BoundField DataField="VENDES" HeaderText="Vend. Descrip." />
                <asp:BoundField DataField="TotalSoles" HeaderText="Sub-Total" DataFormatString="{0:###,###.00}" />
                <asp:CommandField HeaderText="Documentos" SelectText="Ver Detalle" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
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
