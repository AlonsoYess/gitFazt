<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cotizaciondetcliente.aspx.cs" Inherits="CapaPresentacion.cotizaciondetcliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: left;
            color: #000099;
            height: 20px;
        }
        .auto-style12 {
            width: 73%;
            height: 71px;
        }
        .auto-style13 {
            text-align: center;
        }
        .auto-style17 {
            height: 114px;
        }
        .auto-style19 {
            height: 148px;
        }
        .auto-style20 {
            text-align: left;
        }
        .auto-style21 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: right;
            color: #000099;
        }
        .auto-style22 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 151px;
            text-align: right;
            color: #000099;
            height: 26px;
        }
        .auto-style23 {
            width: 253px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 26px;
        }
        .auto-style24 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: left;
            height: 26px;
        }
        .auto-style25 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 10px;
            text-align: center;
            height: 20px;
        }
        .auto-style26 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            color: #000066;
            height: 20px;
        }
        .auto-style27 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        .auto-style28 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style31 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: justify;
            color: #000099;
            height: 20px;
        }
        .auto-style38 {
            color: #336699;
            font-size: small;
        }
        .auto-style42 {
            color: #990000;
        }
        .auto-style43 {
            color: #003399;
            font-size: medium;
        }
        </style>

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
                <td class="auto-style26" colspan="2">
            <span class="auto-style43"><strong>DETALLE DE COTIZACIONES / NOTAS DE PEDIDO</strong></span><br />
                    <strong><span class="auto-style43">
                    EMPRESA&nbsp; : <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style42"></asp:Label>
            &nbsp;DOC :&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style42"></asp:Label>

        &nbsp;NUMERO :<asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style42"></asp:Label>

                    <br />

        </span></strong></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style27" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31" colspan="2"><strong>
                    <span class="auto-style38">
            <a href="javascript:window.history.back();">&laquo; Volver a Resultado Anterior</a></span></strong></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style24">
                    </td>
            </tr>
            </table>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="3">
                    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style28" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" Width="900px" OnSelectedIndexChanged="grdClientes_SelectedIndexChanged" OnRowDataBound="grdClientes_RowDataBound">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="Fec" DataFormatString="{0:d}" HeaderText="Fecha" />
                            <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                            <asp:BoundField DataField="Raz" HeaderText="Razon Social">
                            <ControlStyle Width="200px" />
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Num" HeaderText="Numero" />
                            <asp:BoundField DataField="Cod" HeaderText="Codigo" />
                            <asp:BoundField DataField="Dcp" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Uni" HeaderText="Unidad" />
                            <asp:BoundField DataField="Can" HeaderText="Cantidad" />
                            <asp:BoundField DataField="Pre" HeaderText="Precio" />
                            <asp:BoundField DataField="Dto" HeaderText="Descuento" />
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
