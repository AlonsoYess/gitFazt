<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAPQuiebreStock.aspx.cs" Inherits="CapaPresentacion.SAPQuiebreStock" %>

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
            color: black;
            font-size: 12px;
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
        .auto-style62 {
            width: 627px;
        }
        .auto-style64 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 294px;
            color: #000099;
            height: 27px;
        }
        .auto-style65 {
            width: 244px;
            height: 27px;
        }
        .auto-style67 {
            width: 244px;
            color: #0033CC;
            height: 26px;
            font-size: x-small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style69 {
            width: 249px;
            text-align: left;
            height: 27px;
        }
        .auto-style49 {
            color: #006600;
            background-color: #FFFF00;
        }
        .headerStyle {
            color: blue;
            font-size : 15px;
        }

        .auto-style13 {
            height: 23px;
            font-family: Arial;
            font-size: x-small;
            
        }
        .auto-style70 {
            width: 294px;
            color: #000099;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 26px;
        }
        </style>
<!--<script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
<script language="javascript" type="text/javascript"> 
      $(document).ready(function() { 
          $(".auto-style13 tr:has(td)").each(function () {
           var t = $(this).text().toLowerCase();  
                $("<td class='indexColumn'></td>") 
                .hide().text(t).appendTo(this); 
            });
            //Agregar el comportamiento al texto (se selecciona por el ID) 
          $("#txtBuscar").keyup(function () {
              
                var s = $(this).val().toLowerCase().split(" "); 
                $(".auto-style13 tr:hidden").show();
                $.each(s, function() { 
                    $(".auto-style13 tr:visible .indexColumn:not(:contains('"
                     + this + "'))").parent().hide(); 
                });  
            });  
        });
     </script>-->
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        LOGISTICA INVENTARIO -&nbsp; QUIEBRE DE STOCK<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style64">&nbsp;</td>
                <td class="auto-style69"><strong>
        <asp:Button ID="btnDescargarExcel" runat="server" OnClick="btnDescargarExcel_Click" Text="Archivo en Excel [ QUIEBRE STOCK ]" CssClass="auto-style49" Width="331px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" style="height: 26px" />
                    </strong>
                </td>
                <td class="auto-style65"></td>
            </tr>
           
            <tr>
                <td class="auto-style70">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Buscar :
                </td>
                <td class="auto-style59">
                <asp:TextBox ID="txtBuscar" runat="server" OnTextChanged="txtBuscar_TextChanged" Width="204px" AutoPostBack="True"></asp:TextBox>
                </td>
                <td class="auto-style67">&nbsp;</td>
            </tr>
            </table>
        <div>
            <asp:GridView ID="grdListado" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdListado_PageIndexChanging" PageSize="50" Width="2100px" CssClass="auto-style13" OnPageIndexChanged="grdListado_PageIndexChanged">
                <Columns>
                    <asp:BoundField DataField="CODIGOARTICULO" HeaderText="Código" SortExpression="CODIGOARTICULO" >
                    </asp:BoundField>
                    <asp:BoundField DataField="ARTICULO" HeaderText="Artículo" SortExpression="ARTICULO" />
                    <asp:BoundField DataField="CodigoMarca" HeaderText="Código Marca" SortExpression="CodigoMarca" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                    <asp:BoundField DataField="StockFisicoArticulo" HeaderText="Stock Fisico Art." SortExpression="StockFisicoArticulo"  />
                    <asp:BoundField DataField="ArticuloReceta" HeaderText="Art.Receta" SortExpression="ArticuloReceta" />
                    <asp:BoundField DataField="StockFisicoReceta" HeaderText="Stock Físico Rec." SortExpression="StockFisicoReceta"  />
                    <asp:BoundField DataField="ProporcionReceta" HeaderText="ProporcionReceta" SortExpression="ProporcionReceta" />
                    <asp:BoundField DataField="StockFisicoTotalReceta" HeaderText="Stock Tot. Receta" SortExpression="StockFisicoTotalReceta" />
                    <asp:BoundField DataField="StockPromatisa" HeaderText="Stk.Pro" SortExpression="StockPromatisa" />
                    <asp:BoundField DataField="StockFisicoTotalArticulo" HeaderText="StkFis.Tot.Art." SortExpression="StockFisicoTotalArticulo"  />
                    <asp:BoundField DataField="StockMinimoArticulo" HeaderText="Stk.Min.Art" SortExpression="StockMinimoArticulo" />
                    <asp:BoundField DataField="StockFisicoDiferencia" HeaderText="Stk.Fis.Dif" SortExpression="StockFisicoDiferencia" />
                    <asp:BoundField DataField="Leadtime" HeaderText="Leadtime" SortExpression="Leadtime" />
                    <asp:BoundField DataField="PedidoSAP" HeaderText="Pedido" SortExpression="PedidoSAP" />
                    <asp:BoundField DataField="TiempoDecidir" HeaderText="TiempoDecidir" SortExpression="TiempoDecidir" />
                    <asp:BoundField DataField="PedidoSAP" HeaderText="PedidoSAP" SortExpression="PedidoSAP" />
                    <asp:BoundField DataField="FechaContabilizacionSAP" HeaderText="FC.SAP" SortExpression="FechaContabilizacionSAP" />
                    <asp:BoundField DataField="FechaEntregaSAP" HeaderText="FE-SAP" SortExpression="FechaEntregaSAP" />
                    <asp:BoundField DataField="CantidadSAP" HeaderText="Cant.SAP" SortExpression="CantidadSAP" />
                    <asp:BoundField DataField="OCPromatisa" HeaderText="OCProma" SortExpression="OCPromatisa" />
                    <asp:BoundField DataField="FechaPromatisa" HeaderText="FechaPromatisa" SortExpression="FechaPromatisa" />
                    <asp:BoundField DataField="FechaEntradaPromatisa" HeaderText="FEPromatisa" SortExpression="FechaEntradaPromatisa" />
                    <asp:BoundField DataField="CantidadPromatisa" HeaderText="Cant.Promatisa" SortExpression="CantidadPromatisa" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

