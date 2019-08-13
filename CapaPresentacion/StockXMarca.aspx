<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockXMarca.aspx.cs" Inherits="CapaPresentacion.StockXMarca" %>

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
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        LISTA DE STOCK DE ARTICULOS -&nbsp; DETALLADAS X MARCAS<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <div>
        </div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="3"  ShowFooter="True" Width="500px" CssClass="auto-style63" Caption="Stock X Marca" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="CMarca" HeaderText="Codigo" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad de Items" DataFormatString="{0:###,###.00}" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Lista de Precios" SelectText="Ver Detalle" ShowSelectButton="True" >
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
