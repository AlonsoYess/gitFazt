<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventasgc.aspx.cs" Inherits="CapaPresentacion.ventasgc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
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
        .auto-style42 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 408px;
            color: #000099;
        }
        .auto-style43 {
            width: 269px;
        }
        .auto-style45 {
            width: 235px;
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
            width: 408px;
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
            width: 476px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 408px;
            color: #000099;
            height: 26px;
        }
        .auto-style65 {
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
        VENTAS GRUPO CORPORATIVO - NO INCLUYE IGV - SOLES<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style64">Fecha Inicial :</td>
                <td class="auto-style61"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="150px" TextMode="Date"></asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style65"></td>
            </tr>
            <tr>
                <td class="auto-style42">Fecha Final :</td>
                <td class="auto-style43"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="150px" TextMode="Date"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style45">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Canal :</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlList" runat="server" CssClass="auto-style60" Font-Bold="True" Height="22px" Width="157px">
                        <asp:ListItem>Total</asp:ListItem>
                        <asp:ListItem>PDV</asp:ListItem>
                        <asp:ListItem>MAYORISTAS</asp:ListItem>
                        <asp:ListItem>RETAIL</asp:ListItem>
                        <asp:ListItem>CORPORATIVOS</asp:ListItem>
                        <asp:ListItem>PROYECTOS-INGENIERIA</asp:ListItem>
                        <asp:ListItem>COTIZADORES</asp:ListItem>
                        <asp:ListItem>OFICINA</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Ver Ventas" CssClass="auto-style49" Width="127px" Font-Bold="True" />
                    </strong></td>
            </tr>
            </table>
        <div>
            <br />
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="3" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="500px" CssClass="auto-style63" Caption="Ventas x Canal x PROMATISA" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left">
            <Columns>
                <asp:BoundField DataField="CanalCod" HeaderText="Canal Cod." >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="CanalDesc" HeaderText="Canal Desc." >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" DataFormatString="{0:###,###.00}" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Detalle x Punto" SelectText="Ver Detalle" ShowSelectButton="True" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="Yellow" Font-Bold="True" ForeColor="#000066" BorderColor="#003366" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </div>
        <asp:GridView ID="GridVentasGCSAP" runat="server" AutoGenerateColumns="False" CellPadding="3" OnRowDataBound="GridVentasGCSAP_RowDataBound" OnSelectedIndexChanged="GridVentasGCSAP_SelectedIndexChanged" ShowFooter="True" Width="500px" CssClass="auto-style63" Caption="Ventas x Canal x ACSA CORP" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left">
            <Columns>
                <asp:BoundField HeaderText="Canal Cod." DataField="Empresa" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="AREA" HeaderText="Canal Desc." >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="TotalSoles" HeaderText="SubTotal" DataFormatString="{0:###,###.00}" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Detalle x Punto" SelectText="Ver Detalle" ShowSelectButton="True" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="Yellow" Font-Bold="True" ForeColor="#000066" BorderColor="#003366" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
</body>
</html>
