<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menup.aspx.cs" Inherits="CapaPresentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
              
        <table align="center" class="auto-style5">
            <tr>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="ListaPrecios0" runat="server" BackColor="Red" BorderStyle="None" CssClass="auto-style17" ForeColor="White"  Text="VENTAS - OPCIONES" Width="280px" style="font-weight: bold" />
                </td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="ListaPrecios1" runat="server" BackColor="Red" BorderStyle="None" CssClass="auto-style17" ForeColor="White"  Text="LOGISTICA - OPCIONES" Width="280px" style="font-weight: bold" />
                </td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="Button1" runat="server" BackColor="Red" BorderStyle="None" CssClass="auto-style17" ForeColor="White"  Text="Contabilidad - OPCIONES" Width="280px" style="font-weight: bold" />
                </td>
            </tr>
            </strong><strong>
            <tr>
                <td class="auto-style3">
                    </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="ConsultarStockMarca" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White" OnClick="ConsultarStockMarca_Click" Text="CONSULTA STOCK  X MARCA[SAP]" Width="280px" style="color: #000000; font-weight: bold; background-color: #FFFF00" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="facturalistado" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="DOCUMENTOS - FACTURAS" Width="280px" OnClick="facturalistado_Click" style="color: #FFFFFF; background-color: #000099; font-size: small;" Height="22px" />
                    </td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="logsiticastockmin" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="STOCK MINIMO" Width="280px" OnClick="logsiticastockmin_Click"  />
                </td>
                <td class="auto-style7">
                    <strong>
                    <asp:Button ID="Button2" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="Borrar Logs" Width="280px" OnClick="borrarLog_Click"  />
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <strong>
                    <asp:Button ID="VentasGeneral" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="F9 - VENTAS X PRODUCTOS" Width="280px" OnClick="VentasGeneral_Click" />
                </td>
                <td class="auto-style20">
                    <strong>
                    <asp:Button ID="stockConsultar" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White" OnClick="stockConsultar_Click" Text="CONSULTA STOCK [SAP / STARSOFT]" Width="280px" style="color: #000000; font-weight: bold; background-color: #FFFF00" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="VentasGC" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="VENTAS [SAP / STARSOFT]" Width="280px" OnClick="VentasGC_Click" style="background-color: #FFFF00; color: #000000; font-weight: bold;"  />
                    </strong>
                </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="stockConsultar0" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White" OnClick="stockConsultar0_Click" Text="ORDEN VENTA / UBICACIONES" Width="280px" style="color: #000000; font-weight: bold; background-color: #FFFF00" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="VentasGCExcel" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="VENTAS EXCEL [SAP / STARSOFT]" Width="280px" OnClick="VentasGCExcel_Click" style="margin-top: 0px; background-color: #FFFF00; color: #000000; font-weight: bold;"  />
                    </strong>
                </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="ComprasCotiz" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White" OnClick="ComprasCotiz_Click" Text="ORD. COMP. VS COTIZACION" Width="280px" Height="20px" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="VentasGCExcel0" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="LISTA DE PRECIO [SAP]" Width="280px" OnClick="VentasGCExcel0_Click" style="margin-top: 0px; background-color: #FFFF00; color: #000000; font-weight: bold;"  />
                    </strong>
                    </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="GuiaRemision" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="GUIAS - PENDIENTES X FACT" Width="280px" OnClick="GuiaRemision_Click"  />
                    </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <strong>
                    <asp:Button ID="VentasGCFP" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style13" ForeColor="White"  Text="VENTAS X FORMA DE PAGO" Width="280px" OnClick="VentasGCFP_Click" />
                    </td>
                <td class="auto-style20">
                    <strong>
                    <asp:Button ID="OrdenCompra" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="ORDEN DE COMPRA : ESTADO" Width="280px" OnClick="OrdenCompra_Click" style="font-weight: bold; background-color: #000099"  />
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">
                 
                    <asp:Button ID="CostoInventario" runat="server" Text="Costos Inventario" Width="280px" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White" OnClick="CostoInventario_Click"/>
                 
                </td>
                <td class="auto-style2">
                    <strong>
                    <asp:Button ID="GuiaRemision0" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="COMPRAS X EMPRESA" Width="280px" OnClick="GuiaRemision0_Click"  />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="VentasGCMARCA" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style14" ForeColor="White"  Text="VENTAS X MARCA" Width="280px" OnClick="VentasGCMARCA_Click"  />
                    </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="OrdenxNotaPedido" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="ORD. COMP. VS NOTA PEDIDO" Width="280px"  Height="20px" OnClick="OrdenxNotaPedido_Click" Visible="False" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="vendedorclientes" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="CLIENTE - FACTURAS" Width="280px" OnClick="vendedorclientes_Click"  />
                    </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="NotaPedidoListar" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="NOTA DE PEDIDO VS ALMACEN" Width="280px" OnClick="NotaPedidoListar_Click" Visible="False"  />
                    </td>
            </tr>
            <tr>
                <!--<td class="auto-style3">
                    <strong>
                    <asp:Button ID="cotizacioncliente" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="CLIENTE COTIZ Y N PEDIDO" Width="280px" OnClick="cotizacioncliente_Click1"   />
                    </td>-->
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="SeguimientoSA" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="SEGUIMIENTO DE DESPACHO" Width="280px" OnClick="SeguimientoSA_Click" Visible="False"  />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="clientevendedor" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="VENDEDOR Y  CLIENTES" Width="280px" OnClick="cotizacioncliente_Click1" style="font-weight: bold; color: #FFFFFF; background-color: #000099"   />
                 </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="TomaInventario" runat="server" BackColor="#000099" BorderStyle="None" CssClass="auto-style16" ForeColor="White"  Text="TOMA DE INVENTARIO" Width="280px" OnClick="TomaInventario_Click" style="font-weight: bold; background-color: #000099;color: #000000" Visible="False"  />
                 </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="btnVenXFecArt" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="VENTAS X FECHAS Y ARTICULOS" Width="280px" OnClick="VenXFecArt_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                    
                 </td>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="btnDocAutorizados" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="FLUJO ORDEN DE VENTA" Width="280px" OnClick="DocAutorizados_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                  
                    
                 </td>
            </tr>
             <tr>
                <td class="auto-style3">
                    <strong>
                    <asp:Button ID="btnVentasCliente" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="TOTAL VENTAS X ULTIMOS CLIENTES" Width="280px" OnClick="VentasCliente_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                    
                 </td>
                 
                 <td class="auto-style3">
                 
                    <strong>
                    <asp:Button ID="btnQuiebreStock" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="QUIEBRE DE STOCK" Width="280px" OnClick="btnQuiebreStock_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                  
                    
                 </td>
                   
                        
            </tr>
                  
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnSeguimientoOC" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="Seguimiento OC" Width="280px" OnClick="btnSeguimientoOC_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                </td>
                <td></td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnSeguimientoOCIMP" runat="server" BackColor="Yellow" BorderStyle="None" CssClass="auto-style12" ForeColor="White"  Text="Seguimiento OC Importación" Width="280px" OnClick="btnSeguimientoOCIMP_Click" style="font-weight: bold; background-color: #FFFF00;color: #000000" Visible="True"  />
                </td>
                <td></td>
            </tr>
               
            <tr>
                <td class="auto-style1" colspan="3">
                    <strong>
                    <asp:Label ID="lblBien" runat="server" CssClass="auto-style19" Text="Bienvenido :" style="font-family: Arial, Helvetica, sans-serif; color: #003399"></asp:Label>
                    </strong>
                    </td>
            </tr>

            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
   
    
    </div>
    </form>
</body>
</html>
