<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="facturalistado.aspx.cs" Inherits="CapaPresentacion.facturalistado" %>

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
                <td class="auto-style5" colspan="2"><strong>Listado de Documentos Por Fechas</strong></td>
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
                <td class="auto-style3"><strong>Empresa:</strong></td>
                <td class="auto-style10">
                    <strong>
                    <asp:DropDownList ID="ddlEmp" runat="server" CssClass="auto-style7" Width="60px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold">
                        <asp:ListItem>ACSA</asp:ListItem>
                        <asp:ListItem>PROMATISA</asp:ListItem>
                    </asp:DropDownList>
                    </strong>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <!--<tr>
                <td class="auto-style3"><strong><span class="auto-style3">Sede</span></strong><span class="auto-style3"><strong>:</strong></span></td>
                <td class="auto-style10">
                    <strong>
                    <asp:DropDownList ID="ddlSede" runat="server" CssClass="auto-style7" Width="60px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold">
                        <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                    </strong>
                </td>
                <td class="auto-style11"></td>
            </tr>-->
            <!--<tr>
                <td class="auto-style3"><strong>Punto de&nbsp; Facturación:</strong></td>
                <td class="auto-style10">
                    <strong>
                    <asp:DropDownList ID="ddlPunto" runat="server" CssClass="auto-style7" Width="60px" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>0</asp:ListItem>
                    </asp:DropDownList>
                    <span class="auto-style3">&nbsp;</span><span class="auto-style4">&quot;0&quot; - Todos los puntos</span></strong></td>
                <td class="auto-style11"></td>
            </tr>-->
            <tr>
                <td class="auto-style3"><strong>Fecha Inicial:</strong></td>
                <td class="auto-style10">
                    <strong>
                    <asp:TextBox ID="txtFei" runat="server" Width="166px" CssClass="auto-style15" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold" TextMode="Date"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Fecha Final :</strong></td>
                <td class="auto-style1">
                    <strong>
                    <asp:TextBox ID="txtFef" runat="server" Width="164px" CssClass="auto-style15" style="font-family: Arial, Helvetica, sans-serif; font-size: small; color: #003399; font-weight: bold" TextMode="Date"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style2">&nbsp;</td>
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
                    <asp:GridView ID="grdClientesCotiz" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style28" ForeColor="#333333" GridLines="None" HorizontalAlign="Left" Width="1500px" OnSelectedIndexChanged="grdClientesCotiz_SelectedIndexChanged" style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-small">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="DocNum" HeaderText="DocNum" SortExpression="DocNum" />
                            <asp:BoundField DataField="VenCod" HeaderText="Vend.Cod." />
                            <asp:BoundField DataField="VenDes" HeaderText="Vendedor" />
                            <asp:BoundField DataField="FechaEmision" DataFormatString="{0:d}" HeaderText="Fecha Emis." />
                            <asp:BoundField DataField="RUC" HeaderText="Ruc" />
                            <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                            <asp:BoundField DataField="Doc" HeaderText="Doc" />
                            <asp:BoundField DataField="NroFactura" HeaderText="Numero Doc." />
                            <asp:BoundField DataField="Moneda" HeaderText="Moneda" />
                            <asp:BoundField DataField="IGV" HeaderText="Igv" />
                            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" SortExpression="SubTotal" />
                            <asp:BoundField DataField="Total" HeaderText="Total" />
                            <asp:BoundField DataField="FormaPago" HeaderText="Forma de Pago" />
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
