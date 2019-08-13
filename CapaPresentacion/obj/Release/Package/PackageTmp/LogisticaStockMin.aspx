<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogisticaStockMin.aspx.cs" Inherits="CapaPresentacion.LogisticaStockMin" %>

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
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
            font-size: small;
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
        .auto-style58 {
            width: 269px;
            text-align: left;
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
            width: 421px;
        }
        .auto-style63 {
            color: #009933;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style64 {
            font-size: x-small;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style65 {
            color: #CC3300;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        </span><span class="auto-style65">
        LOGISTICA ANALISIS DE STOCK&nbsp; - GRUPO CORPORATIVO</span><span class="auto-style51"><br />
        <br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
            </span>
        </span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style42">Fecha Inicial :</td>
                <td class="auto-style58"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="120px">01/01/2018</asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style45">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style42">Fecha Final :</td>
                <td class="auto-style43"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="120px">30/11/2018</asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style45">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Canal :</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlList" runat="server" CssClass="auto-style60" Font-Bold="True" Height="22px" Width="125px">
                        <asp:ListItem>Total</asp:ListItem>
                        <asp:ListItem>Tienda</asp:ListItem>
                        <asp:ListItem>Mayorista</asp:ListItem>
                        <asp:ListItem>Retail</asp:ListItem>
                        <asp:ListItem>Corporativo</asp:ListItem>
                        <asp:ListItem>Cotizadores</asp:ListItem>
                        <asp:ListItem>Oficina</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">
                    <strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" Text="Ver Estadistica" CssClass="auto-style49" Width="127px" Font-Bold="False" OnClick="btnVentaPBuscar_Click" BorderStyle="Solid" Height="24px" />
                    </strong>
                    </td>
                <td class="auto-style48">
                    <strong>
                    <asp:Button ID="btnExcel" runat="server" OnClick="Button1_Click" Text="Descargar Excel" CssClass="auto-style63" Height="24px" Width="127px" BorderStyle="Solid" />
                    </strong>
                    </td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GLogisticaStockMin" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="500px" CssClass="auto-style64">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" HtmlEncode="False" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                <asp:BoundField DataField="Enero" HeaderText="Enero" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Febrero" HeaderText="Febrero" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Marzo" HeaderText="Marzo" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Abril" HeaderText="Abril" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Mayo" HeaderText="Mayo" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Junio" HeaderText="Junio" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Julio" HeaderText="Julio" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Agosto" HeaderText="Agosto" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Setiembre" HeaderText="Setiembre" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Octubre" HeaderText="Octubre" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Noviembre" HeaderText="Noviembre" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Diciembre" HeaderText="Diciembre" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Promedio" HeaderText="Promedio" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="StockSeguridadxMes" HeaderText="StockSeguridadxMes" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="ProveedorCod" HeaderText="ProveedorCod" />
                <asp:BoundField DataField="ACSAAzangaro" DataFormatString="{0:###,###.00}" HeaderText="ACSA Azangaro" />
                <asp:BoundField DataField="ACSABambas" DataFormatString="{0:###,###.00}" HeaderText="ACSA Bambas" />
                <asp:BoundField DataField="ACSAShangrila" DataFormatString="{0:###,###.00}" HeaderText="ACSA Shangrila" />
                <asp:BoundField DataField="ACSARetail" DataFormatString="{0:###,###.00}" HeaderText="ACSA Retail" />
                <asp:BoundField DataField="ACSADefectuoso" DataFormatString="{0:###,###.00}" HeaderText="ACSA Defectuoso" />
                <asp:BoundField DataField="PromatisaBambas" DataFormatString="{0:###,###.00}" HeaderText="PROMATISA Bambas" />
                <asp:BoundField DataField="PromatisaRetail" DataFormatString="{0:###,###.00}" HeaderText="PROMATISA Retail" />
                <asp:BoundField DataField="PromatisaRetail" DataFormatString="{0:###,###.00}" HeaderText="PROMATISA Shangrila" />
                <asp:BoundField DataField="Vision" DataFormatString="{0:###,###.00}" HeaderText="Vision Metal" />
                <asp:BoundField DataField="Conexion" DataFormatString="{0:###,###.00}" HeaderText="Conexión Tec" />
                <asp:BoundField DataField="StockTotal" DataFormatString="{0:###,###.00}" HeaderText="Stock Total" />
                <asp:BoundField DataField="Cobertura" DataFormatString="{0:###,###.00}" HeaderText="Cobertura" />
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
