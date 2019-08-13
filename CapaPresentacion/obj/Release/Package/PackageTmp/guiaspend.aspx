<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guiaspend.aspx.cs" Inherits="CapaPresentacion.guiaspend" %>

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
        .auto-style11 {
            color: #0033CC;
        }
        .auto-style40 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style43 {
            width: 269px;
            height: 26px;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 235px;
            color: #0033CC;
            height: 26px;
        }
        .auto-style49 {
            color: #000099;
            }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style53 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            margin-left: 0px;
            color: #000099;
            font-weight: bold;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style59 {
            width: 453px;
            color: #000099;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 26px;
        }
        .auto-style60 {
            color: #003399;
            font-size: small;
        }
        .auto-style61 {
            width: 269px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 601px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 26px;
        }
        .auto-style65 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            color: #000099;
            }
        .auto-style66 {
            width: 235px;
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        REPORTE DE GUIAS PENDIENTES DE FACTURAS<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style65">Fecha Inicial :</td>
                <td class="auto-style61"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date"></asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style66"></td>
                <td class="auto-style66">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style65">Fecha Final :</td>
                <td class="auto-style43"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style66"></td>
                <td class="auto-style66"></td>
            </tr>
            <tr>
                <td class="auto-style65">Empresa<strong> :</strong></td>
                <td class="auto-style61">
                    <asp:DropDownList ID="ddEmpresa" runat="server" Height="17px" OnSelectedIndexChanged="ddEmpresa_SelectedIndexChanged" Width="123px" CssClass="auto-style65" AutoPostBack="True">
                        <asp:ListItem Selected="True">ACSA</asp:ListItem>
                        <asp:ListItem>PROMATISA</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style65">Series</td>
                <td class="auto-style48"><strong>
                    <asp:DropDownList ID="ddSerie" runat="server" CssClass="auto-style65" Font-Bold="True" Height="22px" Width="155px">
                    </asp:DropDownList>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Estado :</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlEst" runat="server" CssClass="auto-style60" Font-Bold="True" Height="22px" Width="125px">
                        <asp:ListItem Value="V">Pendiente</asp:ListItem>
                        <asp:ListItem Value="0">Todas</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Ver Guias Remisión" CssClass="auto-style49" Width="156px" Font-Bold="True" BorderStyle="Solid" style="height: 26px" />
                    </strong></td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar0" runat="server" OnClick="btnVentaPBuscar0_Click" Text="Guias Remisión a XLS" CssClass="auto-style49" Width="156px" Font-Bold="True" BorderStyle="Solid" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="3"><strong>&quot;000&quot; Todas las Series</strong></td>
                <td class="auto-style64">&nbsp;</td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="100%" CssClass="auto-style63" EmptyDataText="No se encontraron registros">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="NS" HeaderText="NS" SortExpression="NS" />
                <asp:BoundField DataField="Fec" HeaderText="Fecha" DataFormatString="{0:d}" >
                </asp:BoundField>
                <asp:BoundField DataField="Doc" HeaderText="Doc" >
                </asp:BoundField>
                <asp:BoundField DataField="Ser" HeaderText="Ser" >
                </asp:BoundField>
                <asp:BoundField DataField="Num" HeaderText="Numero" />
                <asp:BoundField DataField="Est" HeaderText="Estado" />
                <asp:BoundField DataField="Rdc" HeaderText="Doc. Refer." />
                <asp:BoundField DataField="Rnd" HeaderText="Num.Refer." />
                <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                <asp:BoundField DataField="Cod" HeaderText="Razon Social" />
                <asp:BoundField DataField="Ven" HeaderText="Vendedor" />
                <asp:BoundField DataField="Mon" HeaderText="Moneda" />
                <asp:BoundField DataField="Tot" HeaderText="Total" DataFormatString="{0:###,###.00}" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="False" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        </div>
    </form>
</body>
</html>
