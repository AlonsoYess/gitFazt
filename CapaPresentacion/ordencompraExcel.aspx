<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ordencompraExcel.aspx.cs" Inherits="CapaPresentacion.ordencompraExcel" %>

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
            color: #0033CC;
            font-size: x-small;
            height: 26px;
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
            color: #006600;
            background-color: #FFFF00;
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
        .auto-style61 {
            width: 269px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 553px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            color: #003399;
            font-weight: bold;
        }
        .auto-style65 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 408px;
            color: #000099;
            height: 26px;
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
        ORDEN DE
        COMPRA vs NOTA DE INGRESO vs FACTURA&nbsp;&nbsp; EN EXCEL<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style42">Fecha Inicial :</td>
                <td class="auto-style58"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date"></asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style45"></td>
            </tr>
            <tr>
                <td class="auto-style65">Fecha Final :</td>
                <td class="auto-style43"><strong>
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style66">
                    <strong>
                        <asp:Button ID="btnBuscar" runat="server" CssClass="auto-style49" Text="Buscar" Width="215px" Font-Bold="True" OnClick="btnBuscar_Click" />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Empresa :</strong></td>
                <td class="auto-style61">
                    <strong>
                    <asp:DropDownList ID="ddlListEmp" runat="server" CssClass="auto-style64" Width="130px">
                        <asp:ListItem Value="PRO">PROMATISA</asp:ListItem>
                    </asp:DropDownList>
                    </strong>
                    </td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Descargar Archivo en Excel" CssClass="auto-style49" Width="217px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" />
                    </strong></td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="2100px" CssClass="auto-style63" EmptyDataText="No se encontraron registros">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="NroOrden" HeaderText="NroOrden" SortExpression="NroOrden" />
                <asp:BoundField DataField="RucProveedor" HeaderText="RucProveedor" SortExpression="RucProveedor" />
                <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" SortExpression="Proveedor" />
                <asp:BoundField DataField="FechaDocumento" HeaderText="FechaDoc" SortExpression="FechaDocumento" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Item" HeaderText="Item" SortExpression="Item" />
                <asp:BoundField DataField="CodigoArticulo" HeaderText="CodigoArt." SortExpression="CodigoArticulo" />
                <asp:BoundField DataField="CodRef" HeaderText="CodRef" SortExpression="CodRef" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="Unidad" HeaderText="UM" SortExpression="Unidad" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cant." SortExpression="Cantidad" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="PrecioUnitario" HeaderText="PrecioUnit." SortExpression="PrecioUnitario" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="PorcentajeDesc" HeaderText="% Desc." SortExpression="PorcentajeDesc" />
                <asp:BoundField DataField="Descuento" HeaderText="Descuento" SortExpression="Descuento" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="IGV" HeaderText="IGV" SortExpression="IGV" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="NPRENET" HeaderText="NPRENET" SortExpression="NPRENET" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="TotVen" HeaderText="TotVen" SortExpression="TotVen" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="TotNeto" HeaderText="TotNeto" SortExpression="TotNeto" DataFormatString="{0: 0.00}" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                <asp:BoundField DataField="PrecioVen" HeaderText="PrecioVen" SortExpression="PrecioVen" DataFormatString="{0: 0.00}" />
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
