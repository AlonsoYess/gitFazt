<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seguimientosa.aspx.cs" Inherits="CapaPresentacion.seguimientosa" %>

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
            text-align: left;
        }
        .auto-style4 {
            color: #0033CC;
            font-size: x-small;
        }
        .auto-style5 {
            width: 30%;
        }
        .auto-style10 {
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            color: #003366;
        }
        .auto-style11 {
            color: #0033CC;
        }
        .auto-style12 {
            font-size: small;
        }
        .auto-style20 {
            width: 33px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style21 {
            width: 33px;
            height: 26px;
            font-size: small;
        }
        .auto-style22 {
            color: #0033CC;
            height: 26px;
            }
        .auto-style23 {
            height: 26px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style24 {
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            color: #003366;
            height: 26px;
        }
        .auto-style25 {
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
        }
        .auto-style28 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style29 {
            text-align: right;
            font-family: Arial, Helvetica, sans-serif;
            color: #003366;
            font-size: small;
        }
        .auto-style32 {
            font-size: small;
            color: #000099;
        }
        .auto-style33 {
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
            width: 511px;
        }
        .auto-style35 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 511px;
        }
        .auto-style36 {
            font-family: Arial, Helvetica, sans-serif;
            width: 511px;
        }
        .auto-style37 {
            width: 33px;
            height: 26px;
            font-size: small;
            color: #000099;
        }
        .auto-style38 {
            font-family: Arial, Helvetica, sans-serif;
            color: #0033CC;
            text-align: left;
        }
        .auto-style3 {
            font-size: x-small;
            margin-top: 0px;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style40 {
            color: #0033CC;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style41 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <span class="auto-style1"><span class="auto-style32"><strong>CONTROL DE DESPACHO POR ALMACEN</strong></span></span><br />
    
    </div>
        <span class="auto-style1"><strong><span class="auto-style11">
        <table align="left" class="auto-style5">
            <tr>
                <td class="auto-style21">&nbsp;</td>
        </strong>
                <td class="auto-style22" colspan="6">
                    <span class="auto-style32">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style32" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                </td>
            </tr>
            </span><strong>
            <tr>
                <td class="auto-style37"><strong>Desde:</strong> </td>
                <span class="auto-style4">
                <td class="auto-style22">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style41" Width="181px">01/11/2018</asp:TextBox>
                </td>
            </span><span class="auto-style11">
                <td class="auto-style23">&nbsp;</td>
            </span><span class="auto-style4">
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style24"></td>
                <td class="auto-style25">
                </td>
                <td class="auto-style33"></td>
            </tr>
            </span><span class="auto-style11">
            <tr>
                <td class="auto-style20">
        <span class="auto-style1"><strong>
                    <span class="auto-style11">
                    <span class="auto-style32">
                    Hasta:</span></span></strong></span></td>
                <td class="auto-style40">
                    <strong>
                    <span class="auto-style4">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style39" style="font-size: medium" Width="180px">30/11/2018</asp:TextBox>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style35">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
        <span class="auto-style1"><strong>
                    <span class="auto-style11">
                    <span class="auto-style32">
                    Almacen:</span></span></strong></span></td>
                <td class="auto-style38" colspan="3">
                    <strong>
                    <span class="auto-style11">
                    <asp:DropDownList ID="txtAlmacen" runat="server" Height="16px" Width="188px" CssClass="auto-style12">
                        <asp:ListItem>101</asp:ListItem>
                        <asp:ListItem>102</asp:ListItem>
                        <asp:ListItem>200</asp:ListItem>
                    </asp:DropDownList>
        </span>
        </strong>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style36">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
        <span class="auto-style1"><strong>
                    <span class="auto-style11">
                    <span class="auto-style32">
                    Empresa:</span></span></strong></span></td>
                <td class="auto-style38" colspan="3">
                    <strong>
                    <span class="auto-style11">
                    <asp:DropDownList ID="txtEmpresa" runat="server" Height="18px" Width="188px" CssClass="auto-style12">
                        <asp:ListItem>ACS</asp:ListItem>
                    </asp:DropDownList>
        </span>
        </strong>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style36">&nbsp;</td>
            </tr>
        </span>
        </strong>
            <span class="auto-style11">
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style38" colspan="3">
                    <strong>
                    <span class="auto-style11">
                    <span class="auto-style4">
                    <asp:Button ID="btnStockBuscar" runat="server" BorderStyle="Solid" Height="22px"  Text="Buscar" Width="187px" CssClass="auto-style32" OnClick="btnStockBuscar_Click" />
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style36">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style40" colspan="7">
        <asp:GridView ID="GridSeguimientoSA" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="1014px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Right">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="Doc" HeaderText="Doc" />
                <asp:BoundField DataField="NroDoc" HeaderText="Nro. Doc." />
                <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                <asp:BoundField DataField="GuiaRemisionDoc" HeaderText="Guia R." />
                <asp:BoundField DataField="GuiaRemisionNro" HeaderText="Guia Nro." />
                <asp:BoundField DataField="NotaPedidoNro" HeaderText="Nota Pedido" />
                <asp:BoundField DataField="MovimientoSalidaDoc" HeaderText="Mov. Salida" />
                <asp:BoundField DataField="MovimientoSalidaNro" HeaderText="Mov. Salida Nro." />
                <asp:BoundField DataField="EstadoMovimiento" HeaderText="Estado" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
                </td>
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
        </span>
        </span>
        <br />
    </form>
</body>
</html>
