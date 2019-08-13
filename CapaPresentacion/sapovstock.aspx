<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sapovstock.aspx.cs" Inherits="CapaPresentacion.sapovstock
    " %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.5" />   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
    <link href="../style/css/style.css" rel="stylesheet" type="text/css" />
    <script src="../style/script/jquery-1.5.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {

            $('#btnStockBuscar').click(function () {

                var options = 'location=1,status=1,scrollbars=1,width=1000,height=500';

                window.open('productoconsulta.aspx', 'Proveedores', options);

            });

        });
    
    </script>
    <script type="text/javascript">
        function AbrirVentana() 
        {
            day = new Date();
            id = day.getTime();
            iz = (screen.width - 780) / 2;
            ar = (screen.height - 550) / 2;

            var options = 'top=50,left=300,status=1,scrollbars=1,width=1000,height=500';
                window.open('productoconsulta.aspx','Clientes', options);
                //window.focus();
        };
    
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 531px;
        }
        .auto-style4 {
            width: 464px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style7 {
            width: 121px;
            height: 31px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style8 {
            height: 31px;
        }
        .auto-style10 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style11 {
            width: 464px;
            height: 23px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style13 {
            height: 23px;
            font-family: Arial;
            font-size: x-small;
        }
        .auto-style15 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style16 {
            height: 23px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
            font-weight: bold;
        }
        .auto-style18 {
            width: 50%;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style19 {
            width: 121px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        </style>
</head>
<body>



    <form id="Articulo" runat="server">
        <span class="auto-style4">
        <p>
            <table class="auto-style18">
                <tr>
                    <td class="auto-style16" colspan="2">
    
                        <strong><span class="auto-style15">ORDEN DE VENT / STOCK-UBICACIONES</span></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2"><strong>
        <span class="auto-style4">
                        <span class="auto-style15">Click al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style24" NavigateUrl="menup.aspx" style="font-family: Arial, Helvetica, sans-serif; color: #003399;">Menú Principal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"><strong>
                        <span class="auto-style11">
                        ORDEN VENTA:</td>
                    <td class="auto-style8"><strong><span class="auto-style4">
        <asp:TextBox ID="txtValor" runat="server" BorderStyle="Solid" Width="102px" CssClass="auto-style17" style="font-family: Arial, Helvetica, sans-serif; font-size: small"></asp:TextBox>
        <span class="auto-style1"><span class="auto-style10">&nbsp;&nbsp;</span></span></span></strong><span class="auto-style4"><strong><asp:Label ID="lblDes" runat="server"></asp:Label>
                       
        </span>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
        <span class="auto-style4">
                        <strong>
        <span class="auto-style1"><span class="auto-style10"><asp:Button ID="btnBuscar" runat="server" BorderStyle="Solid" Height="22px"  Text="Aceptar" Width="110px"  CssClass="auto-style17"  style="font-family: Arial, Helvetica, sans-serif; font-size: small" OnClick="btnBuscar_Click" />
                        </span>
                        </span>
                        </td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                </table>
        </p>
 
        <asp:GridView ID="GridVStockDatos" runat="server" AutoGenerateColumns="False" CellPadding="3" CssClass="auto-style13"  Width="1060px" OnRowDataBound="GridVStockDatos_RowDataBound" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Caption="ORDEN DE VENTA / STOCK - UBICACIONES" Font-Bold="False">
            <Columns>
                <asp:BoundField DataField="Numero" HeaderText="OrdenVenta" >
                <HeaderStyle BackColor="Yellow" ForeColor="Black" />
                <ItemStyle BackColor="Yellow" HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Codigo" DataField="Codigo">
                <ItemStyle Width="80px" HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Descri" HeaderText="Descripcion" >
                <ItemStyle Width="500px" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Almacen" HeaderText="Almacen" >
                <HeaderStyle HorizontalAlign="Center" Width="100px" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Stock" HeaderText="Stock General" DataFormatString="{0:###,###.00}" >
                <ItemStyle Width="100px" HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="StockUbic" HeaderText="Stock Ubica" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
   
        </span>
   
        <br />
   
    </form>
</body>
</html>
