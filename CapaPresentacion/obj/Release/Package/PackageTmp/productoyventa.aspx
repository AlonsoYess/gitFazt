<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productoyventa.aspx.cs" Inherits="CapaPresentacion.productoyventa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  
    <style type="text/css">
        .auto-style1 {
            font-size: xx-small;
        }
        .auto-style2 {
            font-size: x-small;
            font-family: Verdana, Geneva, Tahoma, sans-serif;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            font-size: small;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
            color: #000099;
        }
        .auto-style8 {
            font-family: Arial, Helvetica, sans-serif;
            color: #000099;
            font-size: small;
        }
        .auto-style9 {
            width: 51px;
        }
    </style>
  <script>
        function solonumeros(e) {
 
            var key;
 
            if (window.event) // IE
            {
                key = e.keyCode;
            }
            else if (e.which) // Netscape/Firefox/Opera
            {
                key = e.which;
            }
 
            if (key < 48 || key > 57) {
                return false;
            }
 
            return true;
        }
 
    </script>
    <script>
        function validar() {
            var codigo = document.getElementById("txtCodigo").value;
            var tm = codigo.length;
            console.log(tm);
            if (tm < 5) {
                alert("[ALERTA] - Còdigo de artìculo debe tener al menos 5 caràcteres");
                document.getElementById("txtCodigo").value = "";
            }
        }
        

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style4"><strong><span class="auto-style6">&gt;&gt;&gt;&gt;&gt;&gt;&nbsp; PRODUCTO Y SUS ULTIMAS VENTAS - NO INCLUYE IGV</span></strong></span><br class="auto-style8" />
    
    </div>
        <span class="auto-style4"><span class="auto-style11">
        <table align="left" class="auto-style35">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style32" colspan="6">
                    <span class="auto-style6">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style33" NavigateUrl="menup.aspx" style="font-family: Arial, Helvetica, sans-serif; color: #000099">Menú Prinicipal</asp:HyperLink>
                </td>
            </tr>
            </span><span class="auto-style34">
            <tr>
                <td class="auto-style27">
                    <span class="auto-style6">
            </span></span><strong><span class="auto-style6">
                    Código:</span></strong></span></span><span class="auto-style1"><span class="auto-style4"><span class="auto-style11"></td>
                <strong>
                <td class="auto-style22">
                    <asp:TextBox ID="txtCodigo" runat="server" onblur="" minlength="5" CssClass="auto-style26" Width="140px" onkeypress="javascript:return solonumeros(event)" style="font-family: Arial, Helvetica, sans-serif; color: #000099; font-size: small" MaxLength="5"></asp:TextBox>
                </td>
        </strong>
        </span>
        </span>
                <span class="auto-style4">
                <strong>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
        <span class="auto-style1">
                <td class="auto-style24"><strong><span class="auto-style4"><span class="auto-style6">
                    Ruc:</span></span></strong></td>
                <td class="auto-style1">
                    <strong><span class="auto-style4">
                    <asp:TextBox ID="txtRuc"  runat="server" CssClass="auto-style26" onkeypress="javascript:return solonumeros(event)" Width="140px" style="font-family: Arial, Helvetica, sans-serif; color: #000099; font-size: small" MaxLength="11"></asp:TextBox>
            </span>
        </strong>
                </td>
            <td class="auto-style24"><strong><span class="auto-style4"><span class="auto-style6">
                    Empresa:</span></span></strong></td>
            <td class="auto-style9">
                <asp:DropDownList ID="ddEmpresa" runat="server">
                    <asp:ListItem Selected="True" Value="SAP">ACSA-SAP</asp:ListItem>
                    <asp:ListItem Value="LISA">ACSA</asp:ListItem>
                    <asp:ListItem>PROMATISA</asp:ListItem>
                </asp:DropDownList>


            </td>
                <td class="auto-style1">
                    <strong><span class="auto-style4">
                    <span class="auto-style11">
                    <asp:Button ID="btnVentaPBuscar" runat="server" BorderStyle="Solid" Height="23px"  Text="Buscar" Width="198px" CssClass="auto-style30" OnClick="btnVentaPBuscar_Click" style="font-family: Arial, Helvetica, sans-serif; color: #000099; font-size: small"  />
        </span>
            </span>
        </strong>
                </td>
            </tr>
        </span>
        </strong>
            </span>
        <span class="auto-style1"><span class="auto-style11">
            </table>
        </span>
        <span class="auto-style4">
        <br class="auto-style8" />
        <br class="auto-style3" />
        </span>
        <br />
        </span>
        <br />
        <table align="left" class="auto-style2">
            <tr class="auto-style12">
                <strong><span class="auto-style11">
                <td class="auto-style1">
        </strong>
        </strong>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron resultados.." CellPadding="4" CssClass="auto-style2" Width="1400px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Right">
            <Columns>
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                <asp:BoundField DataField="VenDes" HeaderText="Vendedor" />
                <asp:BoundField DataField="RUC" HeaderText="RUC" />
                <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha" />
                <asp:BoundField DataField="Doc" HeaderText="Doc" />
                <asp:BoundField DataField="NumeroDoc" HeaderText="NumeroDoc" />
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                <asp:BoundField DataField="Cantidad" DataFormatString="{0:f}" HeaderText="Cantidad" />
                <asp:BoundField DataField="PVenta" DataFormatString="{0:f}" HeaderText="Precio Lista" />
                <asp:BoundField DataField="Descuento" DataFormatString="{0:f}" HeaderText="Descuento" />
                <asp:BoundField DataField="Precio" DataFormatString="{0:f}" HeaderText="Precio Venta" />
                <asp:BoundField DataField="STotal" DataFormatString="{0:f}" HeaderText="Sub-Total" />
                <asp:BoundField DataField="FormaPago" HeaderText="FormaPago" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
                    <strong>
                    <br />
                    <br />
                    <br />
                    <br />
        </strong>
                </td>
        </span>
        </strong>
            </tr>
        </table>
    </form>
</body>
</html>
