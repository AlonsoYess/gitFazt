<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tomainvEDetalle.aspx.cs" Inherits="CapaPresentacion.tomainvEDetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style11 {
            color: #0033CC;
        }
        .auto-style40 {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 235px;
            color: #0033CC;
            height: 26px;
        }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style59 {
            width: 311px;
            color: #000099;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 26px;
        }
        .auto-style61 {
            width: 269px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 404px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            font-size: small;
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style65 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #336699;
        }
        .auto-style66 {
            font-size: small;
            color: #FF3300;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style67 {
            font-weight: bold;
            color: #3366CC;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        TOMA DE INVENTARIO - Detalle <br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para </span>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="tomainvEstados.aspx">Retornar a Pagna Anterior</asp:HyperLink>
        <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style59"><strong>Inventario Nro:</strong></td>
                <td class="auto-style61"><strong><em>
                    <asp:Label ID="lblInventario" runat="server" CssClass="auto-style64">Dato</asp:Label>
                    </em></strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Estado Actual:</strong></td>
                <td class="auto-style61"><strong><em>
                    <asp:Label ID="lblEInventario" runat="server" CssClass="auto-style66" Text="Label"></asp:Label>
                    </em></strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Conteo Nro:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlConteo" runat="server" Height="17px" Width="128px" CssClass="auto-style67">
                        <asp:ListItem>Conteo 1</asp:ListItem>
                        <asp:ListItem>Conteo 2</asp:ListItem>
                        <asp:ListItem>Conteo 3</asp:ListItem>
                        <asp:ListItem>Conteo 4</asp:ListItem>
                        <asp:ListItem>Conteo 5</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61"><strong>
                    <asp:Button ID="btnTomaInvActualizar" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="Button1_Click" Text="Autorizar Inventario" Width="191px" />
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61"><strong>
                    <asp:Button ID="btnTomaInvCerrar" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="btnTomaInvCerrar_Click" Text="Cerrar Inventario" Width="191px" />
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61"><strong>
                    <asp:Button ID="btnTomaInvReporteT" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="btnTomaInvReporteT_Click" Text="Reporte Inventario General" Width="191px" />
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61"><strong>
                    <asp:Button ID="btnTomaInvReporteConteo" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="btnTomaInvCerrar_Click" Text="Reporte Inventario Conteo" Width="191px" />
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="717px" CssClass="auto-style63">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="invcodigo" HeaderText="Nro. Toma Inv" >
                </asp:BoundField>
                <asp:BoundField DataField="invfecha" DataFormatString="{0:d}" HeaderText="Inv.Fecha" />
                <asp:BoundField DataField="invusuario" HeaderText="Usuario" />
                <asp:BoundField DataField="invresponsable" HeaderText="Responsable" />
                <asp:BoundField DataField="invfechainicio" DataFormatString="{0:d}" HeaderText="Fecha Inicio" />
                <asp:BoundField DataField="invfechafin" DataFormatString="{0:d}" HeaderText="Fecha Fin" />
                <asp:BoundField DataField="invalmacen" HeaderText="Almacen Cod." />
                <asp:BoundField DataField="invalmacendes" HeaderText="Almacen Des" />
                <asp:BoundField DataField="investado" HeaderText="Estado" />
                <asp:BoundField DataField="invdproducto" HeaderText="Cod. Producto" />
                <asp:BoundField DataField="invddescripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="invdunidad" HeaderText="Unidad" />
                <asp:BoundField DataField="invdstocksis1" HeaderText="Stock Sistema" />
                <asp:CommandField HeaderText="Detalle de Toma de Inv." SelectText="Ver Detalle" ShowSelectButton="True" >
                <HeaderStyle HorizontalAlign="Left" />
                </asp:CommandField>
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
