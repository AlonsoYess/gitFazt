<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notapedidolistado.aspx.cs" Inherits="CapaPresentacion.notapedidolistado" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/><title></title>
    <script type="text/javascript">
        function VentanaCambiar () {
            var openerWindow = window.opener;
            var button = openerWindow.document.getElementById("txtValor");
            button.value = document.getElementsByName("txtDato")[0].value;
            //var tb = openerWindow.document.getElementById("txtValor");
            //tb.text = "7" ;
            window.close();
        }
    </script>
    
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-small;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #FF0000;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
            color: #FF0000;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
            height: 25px;
        }
        .auto-style7 {
            height: 25px;
        }
    </style>
    
    </head>
    
    <body><form id="form1" runat="server">
    <div class="auto-style13">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style17" colspan="3">
    
        <table align="left" class="auto-style18">
            <tbody class="auto-style20">
            <tr>
                <td class="auto-style5" colspan="2"><strong>Listado de Nota de Pedido Por Fecha / Almacén</strong></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="3">
                    <span class="auto-style3"><strong>Click aquí para regresar al </strong> </span>
                    <strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style15" NavigateUrl="menup.aspx" style="font-family: Arial, Helvetica, sans-serif; color: #003399; font-size: small;">Menú Principal</asp:HyperLink>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Almacén:</strong></td>
                <td class="auto-style10">
                    <strong>
                    <asp:DropDownList ID="ddlAlmacen" runat="server" CssClass="auto-style7" Width="60px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>101</asp:ListItem>
                        <asp:ListItem>102</asp:ListItem>
                        <asp:ListItem>200</asp:ListItem>
                        <asp:ListItem>201</asp:ListItem>
                        <asp:ListItem>400</asp:ListItem>
                        <asp:ListItem>401</asp:ListItem>
                    </asp:DropDownList>
                    </strong><span class="auto-style4"><strong>&quot;0&quot; - Todos Los Almacenes</strong></span></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Fecha Inicial:</strong></td>
                <td class="auto-style7">
                    <strong>
                    <asp:TextBox ID="txtFecha1" runat="server" Width="150px" CssClass="auto-style15" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold" TextMode="Date">01/11/2018</asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Fecha Final :</strong></td>
                <td class="auto-style1">
                    <strong>
                    <asp:TextBox ID="txtFecha2" runat="server" Width="150px" CssClass="auto-style15" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold" TextMode="Date">30/11/2018</asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong><span class="auto-style3">Nota de Pedido</span></strong><span class="auto-style3"><strong>:</strong></span></td>
                <td class="auto-style23">
                    <strong>
                    <asp:TextBox ID="txtNotaPedido" runat="server" Width="100px" CssClass="auto-style15" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold">0</asp:TextBox>
                    <span class="auto-style3">&nbsp;</span><span class="auto-style4">&quot;0&quot; - Tod</span></strong><span class="auto-style4"><strong>as la Notas de Pedido</strong></span></td>
                <td class="auto-style24">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style23">
                    <strong>
                    <asp:Button ID="btnBuscar" runat="server" BorderStyle="Solid" CssClass="auto-style21" OnClick="btnBuscar_Click" Text="Ver Reporte" Width="143px" style="font-family: Arial, Helvetica, sans-serif; color: #003399; font-size: small; font-weight: bold;" />
                    <asp:Button ID="btnExcel" runat="server" BorderStyle="Solid" CssClass="auto-style22" OnClick="btnExcel_Click" Text="Descargar a Excel" Width="171px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #009933; font-weight: bold;" />
                    </strong>
                    </td>
                <td class="auto-style24">
                    </td>
            </tr>
            </table>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="3">
                    <asp:GridView ID="grdClientesCotiz" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style28" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" Width="900px" OnSelectedIndexChanged="grdClientesCotiz_SelectedIndexChanged" style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Femision" HeaderText="Fecha Em" DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Nopedido" HeaderText="Nota Pedido" />
                            <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                            <asp:BoundField DataField="Razon" HeaderText="Razon Social" />
                            <asp:BoundField DataField="Moneda" HeaderText="Moneda" />
                            <asp:BoundField DataField="BaseImp" HeaderText="Base Imp" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
                            <asp:BoundField DataField="Codigo" HeaderText="VenCod" />
                            <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" />
                            <asp:BoundField DataField="AlmacenCod" HeaderText="Almacen Cod" />
                            <asp:BoundField DataField="AlmacenDes" HeaderText="Almacen Des" />
                            <asp:BoundField DataField="Facturado" HeaderText="Facturado?" />
                            <asp:BoundField DataField="OrdenCompra" HeaderText="Orden Compra" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" HorizontalAlign="Left" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
        </table>
        <div class="auto-style13">
        </div>
    
    </div>
        <div class="auto-style13">
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
    </form>
</body>
</html>
