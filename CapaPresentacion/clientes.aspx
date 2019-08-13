<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="CapaPresentacion.clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  

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
            font-size: small;
        }
        .auto-style3 {
            font-size: small;
            color: #003399;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            color: #990000;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #003399;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style13">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style17" colspan="3">
    
        <table align="left" class="auto-style12">
            <tbody class="auto-style20">
            <tr>
                <td class="auto-style4" colspan="2"><strong>Cliente - Consulta y Ventas</strong></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="3">
                    <span class="auto-style5">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style15" NavigateUrl="menup.aspx" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399">Menú Principal</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong><span class="auto-style3">Dato del Cliente (RUC o Razón Social) </span> </strong><span class="auto-style3">:</span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtDato" runat="server" Width="190px" CssClass="auto-style5"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style23">
                    <strong>
                    <asp:Button ID="btnBuscar" runat="server" BorderStyle="Solid" CssClass="auto-style10" OnClick="btnBuscar_Click" Text="Buscar" Width="90px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399" />
                    <input id="Button1" type="button" value="Cerrar Ventana" onclick ="VentanaCambiar()" class="auto-style5" /></strong></td>
                <td class="auto-style24">
                    </td>
            </tr>
            </table>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="3">
                    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style28" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" Width="900px" OnSelectedIndexChanged="grdClientes_SelectedIndexChanged" style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small" OnRowCreated="grdClientes_RowCreated" OnRowDataBound="grdClientes_RowDataBound">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="Emp" HeaderText="Empresa" />
                            <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                            <asp:BoundField DataField="Cod" HeaderText="Codigo" />
                            <asp:BoundField DataField="Raz" HeaderText="Razon Social" />
                            <asp:BoundField DataField="Dir" HeaderText="Dirección" />
                            <asp:CommandField HeaderText="Ventas" SelectText="Ver Detalle" ShowSelectButton="True">
                            <ControlStyle Width="100px" />
                            <ItemStyle HorizontalAlign="Left" />
                            </asp:CommandField>
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
