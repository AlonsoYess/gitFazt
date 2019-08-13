<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentasxClientexMensualD.aspx.cs" Inherits="CapaPresentacion.VentasxClientexMensualD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
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
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            color: #CC3300;
            font-size: small;
        }
        .auto-style38 {
            color: #336699;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        VENDEDOR Y CLIENTES - </span><span class="auto-style64">
        GESTION 2018</span><span class="auto-style51"><br />
    
        <span class="auto-style38">
        <a href="javascript:window.history.back();">« Retornar a Resultado Anterior</a></span><span class="auto-style11"><br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="500px" CssClass="auto-style63">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="RazonSocial" HeaderText="RazonSocial" >
                <ControlStyle Width="250px" />
                <FooterStyle Width="250px" />
                <HeaderStyle HorizontalAlign="Left" Width="250px" />
                <ItemStyle Width="250px" />
                </asp:BoundField>
                <asp:BoundField DataField="MbEprCod" HeaderText="Empresa" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:d}" />
                <asp:BoundField DataField="MbDocCod" HeaderText="Doc" />
                <asp:BoundField DataField="GcFacFolti" HeaderText="NroDoc" />
                <asp:BoundField DataField="MbArtCod" HeaderText="Codigo" />
                <asp:BoundField DataField="MbArtNom" HeaderText="Decripcion" >
                <ControlStyle Width="250px" />
                <FooterStyle Width="250px" />
                <HeaderStyle Width="250px" />
                <ItemStyle Width="250px" />
                </asp:BoundField>
                <asp:BoundField DataField="GcFacUme" HeaderText="Unidad" />
                <asp:BoundField DataField="GcFacArtCa" DataFormatString="{0:###,###.00}" HeaderText="Cantidad" />
                <asp:BoundField DataField="Moneda" HeaderText="Moneda" />
                <asp:BoundField DataField="GcFacArtDt" DataFormatString="{0:###,###.00}" HeaderText="Descuento" />
                <asp:BoundField DataField="PrecioLista" DataFormatString="{0:###,###.00}" HeaderText="PrecioLista" />
                <asp:BoundField DataField="PrecioSoles" DataFormatString="{0:###,###.00}" HeaderText="PrecioSoles" />
                <asp:BoundField DataField="SubtotalSoles" DataFormatString="{0:###,###.00}" HeaderText="SubtotalSoles" />
                <asp:BoundField DataField="FormaPago" HeaderText="FormaPago" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
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
