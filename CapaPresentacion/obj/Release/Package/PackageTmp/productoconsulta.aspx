<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productoconsulta.aspx.cs" Inherits="CapaPresentacion.productoconsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta name="viewport" content="width=device-width, initial-scale=1.5" />         
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script src="../style/script/jquery-1.5.2.min.js" type="text/javascript"></script>
    
    <script type="text/javascript">
    
        $(function() {

            $('#<%=grdClientes.ClientID %> .imgSelection').click(function() {

                var ProductoCod = $(this).attr('Codigo');
              
                var tr = $(this).parent().parent();
                var ProductoDes = $('td:eq(4)', tr).text();

                window.opener.$("[id*='txtValor']").val(ProductoCod);
                window.opener.$("[id*='lblDes']").text(ProductoDes);

                window.opener.$("[id*='btnBuscar']").click();

                window.close();
            })

        });
    
    </script>


    <style type="text/css">
        .auto-style8 {
            width: 423px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            color: #000099;
            text-align: left;
            height: 20px;
        }
        .auto-style10 {
            font-size: small;
            color: #000099;
        }
        .auto-style12 {
            width: 73%;
            height: 71px;
        }
        .auto-style13 {
            text-align: center;
        }
        .auto-style15 {
            color: #000099;
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
            width: 203px;
            color: #000099;
            height: 20px;
        }
        .auto-style22 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 203px;
            color: #000099;
            height: 26px;
        }
        .auto-style23 {
            width: 423px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 26px;
        }
        .auto-style24 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 153px;
            text-align: left;
            height: 26px;
        }
        .auto-style25 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 153px;
            text-align: center;
            height: 20px;
        }
        .auto-style26 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 203px;
            color: #000066;
            height: 20px;
        }
        .auto-style27 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 20px;
        }
        .auto-style28 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style32 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 147px;
            color: #000066;
            height: 20px;
        }
        .auto-style33 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 147px;
            color: #000099;
            height: 20px;
        }
        .auto-style35 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 147px;
            color: #000099;
            height: 26px;
        }
        .auto-style36 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            width: 153px;
            text-align: left;
            color: #000099;
            height: 26px;
        }
        .auto-style39 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            color: #000099;
            height: 26px;
        }
        .auto-style40 {
            color: #FF0000;
        }
        </style>

    <script type="text/javascript">
        function VentanaCambiar () {
            var openerWindow = window.opener;
            var button1 = openerWindow.document.getElementById("txtValor");
            var button2 = openerWindow.document.getElementById("txtDes");
            button1.value = document.getElementsByName("txtCod")[0].value;
            button2.value = document.getElementsByName("txtDes")[0].value;
            window.close();
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style13">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style17" colspan="4">
    
        <table align="left" class="auto-style12">
            <tbody class="auto-style20">
            <tr>
                <td class="auto-style32"></td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style8"><strong>Producto - Formulario de Ayuda</strong></td>
                <td class="auto-style25"></td>
                <td class="auto-style25">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33"></td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style27" colspan="2">
                    <span class="auto-style15">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style15" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                </td>
                <td class="auto-style27">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style35"></td>
                <td class="auto-style22"><strong>Producto Código o Descripción</strong></td>
                <td class="auto-style23">
                    <asp:TextBox ID="txtDatoHijo" runat="server" Width="190px"></asp:TextBox>
                </td>
                <td class="auto-style36">
                    &nbsp;</td>
                <td class="auto-style36">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style35">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style23">
                    <strong>
                    <asp:Button ID="btnBuscar" runat="server" BorderStyle="Solid" CssClass="auto-style10" OnClick="btnBuscar_Click" Text="Buscar" Width="90px" />
                    </strong></td>
                <td class="auto-style24">
                    </td>
                <td class="auto-style24">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39" colspan="5"><strong><em>Nota: Se puede usar % para realizar búsquedas&nbsp;&nbsp;&nbsp;&nbsp; *** <span class="auto-style40">ejemplo 1&nbsp; :&nbsp; %32x12%&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp; ***&nbsp;&nbsp; <span class="auto-style40">ejemplo 2&nbsp; :&nbsp; cana%32x12% </span></em></strong></td>
            </tr>
            </table>
    
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style28" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" Width="900px" OnSelectedIndexChanged="grdClientes_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Seleccionar">
                                <ItemTemplate>
                                        <img id="imgSelection" src="../style/images/select.png" alt="" class="imgSelection" Codigo="<%#Eval("Codigo")%>" />
                             </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="CodigoAl" HeaderText="CodigoAl" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
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
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
