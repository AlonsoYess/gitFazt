<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultastock.aspx.cs" Inherits="CapaPresentacion.consultastock" %>

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
            width: 59px;
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
            width: 63%;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style19 {
            width: 59px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style63 {
            font-family: Arial;
            font-size: x-small;
        }
        .auto-style64 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #003399;
        }
        .auto-style65 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #FF0000;
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
    
                        <strong><span class="auto-style64">STOCK POR CODIGO DE PRODUCTO / </span><span class="auto-style65">LOS PRECIOS INCLUYEN IGV</span></td>
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
                        CODIGO</td>
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
                <tr>
                    <td class="auto-style19"></td>
                    <td>
        <span class="auto-style4">
                        <strong>
        <span class="auto-style1">
                        <asp:Button ID="btnStockBuscar" runat="server" BorderStyle="Solid" Height="22px"  Text="Ayuda" Width="110px"  CssClass="auto-style17"  style="font-family: Arial, Helvetica, sans-serif; font-size: small" OnClick="btnStockBuscar_Click1" />
                        </span>
                        </td>
                    <td></td>
                </tr>
                </table>
        </p>
 
        <asp:GridView ID="GridVStockDatos" runat="server" AutoGenerateColumns="False" CellPadding="3" CssClass="auto-style13"  Width="1250px" OnRowDataBound="GridVStockDatos_RowDataBound" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Caption="PRECIOS INCLUYEN IGV - PROMATISA - STARSOFT" Font-Bold="False" OnSelectedIndexChanged="GridVStockDatos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" >
                <ControlStyle ForeColor="#CC0000" />
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="AlmacenDes" HeaderText="Almacen Nom" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="Stock" HeaderText="Stock" DataFormatString="{0:f}" >
                <HeaderStyle BackColor="Yellow" ForeColor="Black" />
                <ItemStyle BackColor="Yellow" HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Comprometido">
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" >
                <ItemStyle Width="30px" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" >
                <ItemStyle Width="400px" />
                </asp:BoundField>
                <asp:BoundField DataField="AlmacenCod" HeaderText="Almacen Cod" >
                <HeaderStyle HorizontalAlign="Center" Width="100px" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioSTARSOFT" HeaderText="P S/. INC/IGV" DataFormatString="{0:###,###.00}" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioSd1" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D25%" />
                <asp:BoundField DataField="PrecioSd2" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D28%" />
                <asp:BoundField DataField="PrecioSd3" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D30%" />
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
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="3"  ShowFooter="True" Width="1250px" CssClass="auto-style63" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Caption="PRECIOS INCLUYEN IGV - ACSA CORP - SAP BUSSINES ONE">
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" >
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="AlmacenNom" HeaderText="Almacen Nom" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="Stock" DataFormatString="{0:###,###.00}" HeaderText="Stock">
                <HeaderStyle HorizontalAlign="Center" BackColor="Yellow" Font-Bold="True" ForeColor="Black" />
                <ItemStyle BackColor="Yellow" Width="100px" HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Disponible" DataFormatString="{0:###,###.00}" HeaderText="Comprometido">
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" >
                <ItemStyle Width="30px" />
                </asp:BoundField>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle Width="400px" />
                </asp:BoundField>
                <asp:BoundField DataField="AlmacenCod" HeaderText="Almacen Cod" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioSol" HeaderText="P S/. INC/IGV" DataFormatString="{0:###,###.00}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="PrecioSol1" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D25%" />
                <asp:BoundField DataField="PrecioSol2" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D28%" />
                <asp:BoundField DataField="PrecioSol3" DataFormatString="{0:###,###.00}" HeaderText="P S/. INC/IGV D30%" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
   
        <br />
   
    </form>
</body>
</html>
