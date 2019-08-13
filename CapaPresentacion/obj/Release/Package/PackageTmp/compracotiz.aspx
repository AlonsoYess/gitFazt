<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compracotiz.aspx.cs" Inherits="CapaPresentacion.compracotiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 253px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        .auto-style2 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: left;
            color: #000099;
        }
        .auto-style8 {
            width: 253px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            color: #000099;
            text-align: left;
            height: 20px;
        }
        .auto-style10 {
            font-size: small;
            color: #000099;
        }
        .auto-style11 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: left;
            color: #000000;
        }
        .auto-style12 {
            width: 56%;
            height: 71px;
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
            color: #000099;
        }
        .auto-style19 {
            height: 148px;
        }
        .auto-style20 {
            text-align: left;
        }
        .auto-style21 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: right;
            color: #000099;
        }
        .auto-style22 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: right;
            color: #000099;
            height: 26px;
        }
        .auto-style23 {
            width: 253px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 26px;
        }
        .auto-style24 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: left;
            height: 26px;
        }
        .auto-style25 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: center;
            height: 20px;
        }
        .auto-style26 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: left;
            color: #000066;
            height: 20px;
        }
        .auto-style27 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style13">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style17" colspan="3">
    
        <table align="left" class="auto-style12">
            <tbody class="auto-style20">
            <tr>
                <td class="auto-style26"></td>
                <td class="auto-style8"><strong>ORDEN DE COMPRA VS COTIZACION</strong></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style27" colspan="2">
                    <span class="auto-style15">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style15" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style21"><strong>ORDEN DE COMPRA</strong></td>
                <td class="auto-style1">
                    <strong>
                    <asp:TextBox ID="txtOrdenCompra" runat="server" BorderStyle="Solid" CssClass="auto-style10" Height="16px" Width="180px"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22"><strong>COTIZACION</strong></td>
                <td class="auto-style23">
                    <strong>
                    <asp:TextBox ID="txtCotizacion" runat="server" BorderStyle="Solid" CssClass="auto-style10" Height="16px" Width="180px"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style24">
                    </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>
                    <br class="auto-style15" />
                    </strong></td>
                <td class="auto-style1">
                    <strong>
                    <asp:Button ID="btnCompra" runat="server" BorderStyle="Solid" CssClass="auto-style10" OnClick="btnCompra_Click" Text="OK" Width="186px" />
                    </strong>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        </table>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="3">
        <asp:GridView ID="grdComprasCotiz" runat="server" AutoGenerateColumns="False" CssClass="auto-style6" Width="906px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                <asp:BoundField DataField="CostoSoles" HeaderText="Costo Soles" />
                <asp:BoundField DataField="VentaSoles" HeaderText="Venta Soles" />
                <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje" />
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
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
        <div class="auto-style13">
        </div>
    
    </div>
        <div class="auto-style13">
        </div>
    </form>
</body>
</html>
