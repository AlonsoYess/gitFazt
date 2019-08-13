<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compraNP.aspx.cs" Inherits="CapaPresentacion.compraNP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style10 {
            font-size: small;
            color: #000099;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style11 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: left;
            color: #000066;
        }
        .auto-style12 {
            width: 70%;
            height: 141px;
        }
        .auto-style13 {
            text-align: center;
        }
        .auto-style15 {
            color: #000099;
        }
        .auto-style17 {
            height: 114px;
        }
        .auto-style6 {
            font-size: x-small;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style20 {
            text-align: left;
        }
        .auto-style21 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 266px;
            text-align: right;
            color: #000099;
        }
        .auto-style22 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 266px;
            text-align: right;
            color: #000099;
            height: 26px;
        }
        .auto-style24 {
            width: 372px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            color: #000099;
        }
        .auto-style25 {
            width: 372px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 26px;
        }
        .auto-style26 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #000099;
        }
        .auto-style29 {
            width: 470px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        .auto-style30 {
            width: 470px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 26px;
        }
        .auto-style31 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 266px;
            text-align: left;
            color: #000066;
        }
        .auto-style33 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            color: #000099;
        }
        .auto-style34 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #000099;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style20">
    
        <div class="auto-style20">
            <strong>
            <span class="auto-style34">COMPRATIVO ORDEN DE COMPRA&nbsp; VS NOTA DE PEDIDO</span></strong></div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style17">
    
        <table align="left" class="auto-style12">
            <tbody class="auto-style20">
            <tr>
                <td class="auto-style33" colspan="3"><span class="auto-style15">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style15" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style21"><strong>EMPRESA</strong></td>
                <td class="auto-style29">
                    <strong><span class="auto-style11">
                    <asp:DropDownList ID="txtEmpresa" runat="server" Height="16px" Width="190px" CssClass="auto-style26" style="font-size: small">
                        <asp:ListItem>ACS</asp:ListItem>
                    </asp:DropDownList>
        </span>
        </strong>
                </td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21"><strong>ORDEN DE COMPRA</strong></td>
                <td class="auto-style29">
                    <strong>
                    <asp:TextBox ID="txtOrdenCompra" runat="server" BorderStyle="Solid" CssClass="auto-style10" Height="16px" Width="180px"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22"><strong>NOTA DE PEDIDO</strong></td>
                <td class="auto-style30">
                    <strong>
                    <asp:TextBox ID="txtNotaPedido" runat="server" BorderStyle="Solid" CssClass="auto-style10" Height="16px" Width="180px"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style25">
                    </td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>
                    <br class="auto-style15" />
                    </strong></td>
                <td class="auto-style29">
                    <strong>
                    <asp:Button ID="btnCompra" runat="server" BorderStyle="Solid" CssClass="auto-style10" OnClick="btnCompra_Click" Text="OK" Width="186px" />
                    </strong>
                </td>
                <td class="auto-style24">
                    &nbsp;</td>
            </tr>
        </table>
    
                </td>
            </tr>
            </table>
    
    </div>
        <div class="auto-style13">
        </div>
        <asp:GridView ID="grdComprasNotaP" runat="server" AutoGenerateColumns="False" CssClass="auto-style6" Width="906px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad Venta" DataFormatString="{0:f}" />
                <asp:BoundField DataField="CantCN" HeaderText="Cantidad Compra" DataFormatString="{0:f}" />
                <asp:BoundField DataField="VentaSoles" HeaderText="Venta Soles" DataFormatString="{0:f}" />
                <asp:BoundField DataField="CompraSoles" DataFormatString="{0:f}" HeaderText="Costo Soles" />
                <asp:BoundField DataField="Utilidad" HeaderText="Porcentaje" DataFormatString="{0:f}" />
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
    </form>
</body>
</html>
