<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventasgcformapago.aspx.cs" Inherits="CapaPresentacion.ventasgcformapago" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            color: #0033CC;
            font-size: x-small;
        }
        .auto-style5 {
            width: 42%;
        }
        .auto-style11 {
            color: #0033CC;
        }
        .auto-style12 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style13 {
            color: #003399;
            font-size: small;
        }
        .auto-style22 {
            color: #0033CC;
            height: 26px;
            width: 142px;
        }
        .auto-style24 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            color: #003399;
            height: 26px;
            width: 131px;
        }
        .auto-style25 {
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
        }
        .auto-style26 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            margin-left: 0px;
            color: #003399;
        }
        .auto-style27 {
            height: 26px;
            font-size: small;
            text-align: left;
            width: 94px;
            color: #003399;
        }
        .auto-style3 {
            font-size: x-small;
            margin-top: 0px;
            color: #000000;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style29 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            color: #003399;
            height: 26px;
            width: 98px;
        }
        .auto-style30 {
            color: #003399;
            font-size: small;
            font-weight: bold;
        }
        .auto-style31 {
            font-size: x-small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style32 {
            width: 79%;
            font-size: small;
        }
        .auto-style34 {
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
            color: #000099;
        }
        .auto-style36 {
            height: 26px;
            font-size: small;
            text-align: left;
            color: #000099;
        }
        .auto-style37 {
            height: 26px;
            font-size: small;
            text-align: left;
            width: 94px;
            color: #336699;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style38 {
            color: #0033CC;
            height: 26px;
            width: 142px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style40 {
            text-align: left;
        }
        .auto-style42 {
            color: #000000;
        }
        .auto-style44 {
            color: #003399;
        }
        .auto-style45 {
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
            color: #003399;
        }
        .auto-style46 {
            height: 26px;
            font-size: small;
            text-align: left;
            color: #003399;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <span class="auto-style1"><strong><span class="auto-style13">VENTAS GRUPO CORPORATIVO X FORMA DE PAGO - NO INCLUYE IGV - SOLES</span></strong></span></div>
        <span class="auto-style1">
        <table align="left" class="auto-style32">
            <tr>
                <td class="auto-style46" colspan="7">
        <span class="auto-style1">
                <span class="auto-style11">
                    <span class="auto-style44">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style44" NavigateUrl="menup.aspx">Menú Prinicipal</asp:HyperLink>
                    <br />
            </span>
        </span>
                </td>
                <span class="auto-style11">
            </tr>
            <tr>
                <td class="auto-style27"><strong>Fecha&nbsp; Inicial:</strong></td>
            </span><strong><span class="auto-style4">
                <td class="auto-style22">
                    <strong>
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style26" Width="123px" OnTextChanged="txtFecha1_TextChanged" Height="17px" TextMode="Date"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style34">
                    <strong><span class="auto-style4">
                    <span class="auto-style11">
                    <asp:Button ID="btnVentaPBuscar" runat="server" BorderStyle="Solid" Height="23px"  Text="Buscar" Width="115px" CssClass="auto-style30" OnClick="btnVentaPBuscar_Click"  />
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style25">
                </td>
                <td class="auto-style45">&nbsp;</td>
            </tr>
            </span><span class="auto-style11">
            <tr>
                <td class="auto-style37"><strong><span class="auto-style44">
                    Fecha&nbsp; Final:</span></strong></td>
                <td class="auto-style38">
                    <strong><span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style26" Width="125px" Height="16px" TextMode="Date"></asp:TextBox>
            </span>
        </strong>
                </td>
                <td class="auto-style45">&nbsp;</td>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style45">
                    &nbsp;</td>
                <td class="auto-style45">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style37"><strong><span class="auto-style44">
                    Empresa:</span></strong></td>
                <td>
                    <asp:DropDownList ID="ddEmpresa" runat="server" Height="16px" Width="130px" CssClass="auto-style26">
                        <asp:ListItem Selected="True">ACSA</asp:ListItem>
                        <asp:ListItem>PROMATISA</asp:ListItem>
                        <asp:ListItem>TODOS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style36" colspan="7">
        <table align="left" class="auto-style5">
            <tr class="auto-style12">
                <strong><span class="auto-style11">
                <td class="auto-style31"><span class="auto-style42">
        </strong>
        </strong>
        </span>
                    <span class="auto-style11">
        <asp:GridView ID="GridVentasGCFormaPago" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style3" Width="900px" HorizontalAlign="Right"   OnRowDataBound="GridVentasGCMarca_RowDataBound"  ShowFooter="True" ForeColor="#333333" GridLines="None" EmptyDataText="No se han encontrado registros.">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="FormaPagoSicoDes" HeaderText="Forma de Pago" />
                <asp:BoundField DataField="Tienda" HeaderText="Tienda" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Mayorista" DataFormatString="{0:###,###.00}" HeaderText="Mayorista" />
                <asp:BoundField DataField="Retail" DataFormatString="{0:###,###.00}" HeaderText="Retail" />
                <asp:BoundField DataField="Corporativo" DataFormatString="{0:###,###.00}" HeaderText="Corporativo" />
                <asp:BoundField DataField="Proyectos" HeaderText="Proyectos" SortExpression="Proyectos" />
                <asp:BoundField DataField="Cotizadores" DataFormatString="{0:###,###.00}" HeaderText="Cotizadores" />
                <asp:BoundField DataField="Oficina" DataFormatString="{0:###,###.00}" HeaderText="Oficina" />
                <asp:BoundField DataField="Total" DataFormatString="{0:###,###.00}" HeaderText="Total" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        </span>
                    <span class="auto-style42">
                    <strong>
                    <br />
                    <br />
                    <br />
                    <br />
                    </strong>
        </span>
                </td>
        </span>
        </strong>
            </tr>
        </table>
                </td>
            </tr>
            </table>
        </span>
        </strong>
        <br class="auto-style42" />
        <br class="auto-style42" />
        <br class="auto-style42" />
        </span>
        <br class="auto-style42" />
    </form>
</body>
</html>
