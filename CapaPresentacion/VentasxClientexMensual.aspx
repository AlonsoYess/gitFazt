<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentasxClientexMensual.aspx.cs" Inherits="CapaPresentacion.VentasxClientexMensual" %>

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
        .auto-style42 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 154px;
            color: #000099;
            height: 26px;
        }
        .auto-style43 {
            width: 269px;
            height: 26px;
        }
        .auto-style45 {
            width: 235px;
            height: 26px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #CC3300;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 235px;
            color: #0033CC;
            height: 26px;
        }
        .auto-style49 {
            color: #000099;
            }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style59 {
            width: 154px;
            color: #000099;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            height: 26px;
        }
        .auto-style61 {
            width: 269px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 654px;
            height: 89px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            color: #CC3300;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        VENDEDOR Y CLIENTES - </span><span class="auto-style64">
        GESTION 2018</span><span class="auto-style51"><br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style42">FECHA INICIO : </td>
                <td class="auto-style43">
                    <asp:TextBox ID="txtFechaInicio" runat="server" Width="170px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style42">Cliente</td>
                <td>
                    <asp:TextBox ID="txtCliente" runat="server" Width="125px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>FECHA FIN&nbsp; :</strong></td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtFechaFin" runat="server" Width="170px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style42">Empresa</td>
                <td>

                    <asp:DropDownList ID="ddEmpresa" runat="server" Height="16px" Width="125px">
                        <asp:ListItem>ACSA</asp:ListItem>
                        <asp:ListItem>PROMATISA</asp:ListItem>
                        <asp:ListItem>TODOS</asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td class="auto-style42">VENDEDOR :</td>
                <td class="auto-style61">
                    <asp:DropDownList ID="ddVendedor" runat="server" Height="22px" Width="178px">
                        <asp:ListItem Value="CR">CRISTIAN REYNAGA</asp:ListItem>
                        <asp:ListItem Value="KE">Kevin Escobar Ruiz</asp:ListItem>
                        <asp:ListItem Value="AB">Antonio Aguilar Benito</asp:ListItem>
                        <asp:ListItem Value="JH">JOSE HUAMAN ZAMBRANO</asp:ListItem>
                        <asp:ListItem Value="LS">LUIS ARTEMIO SEPULVEDA MOLINA</asp:ListItem>
                        <asp:ListItem Value="MP">VENDEDOR MAYORISTA PROVINCIA</asp:ListItem>
                        <asp:ListItem Value="BC">Consuelo Casapaico</asp:ListItem>
                        <asp:ListItem Value="SN">Sandy Castillo</asp:ListItem>
                        <asp:ListItem Value="BD">Fernando Rivas Lazo</asp:ListItem>
                        <asp:ListItem Value="CZ">Cesar Chumpitaz</asp:ListItem>
                        <asp:ListItem Value="D3">KATHERINE CALIXTRO</asp:ListItem>
                        <asp:ListItem Value="F4">RICHARD CARRILLO</asp:ListItem>
                        <asp:ListItem Value="JP">JUAN PEREZ</asp:ListItem>
                        <asp:ListItem Value="RV">RONALD VALENCIA</asp:ListItem>
                        <asp:ListItem Value="WM">Williams Marreros</asp:ListItem>
                        <asp:ListItem Value="VF">RAFAEL SARMIENTO</asp:ListItem>
                        <asp:ListItem Value="96">Luis Gomez</asp:ListItem>
                        <asp:ListItem Value="22" Selected="True">DENNIS BENITES</asp:ListItem>
                        <asp:ListItem Value="14">MOISES RUIZ</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td><strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click1" Text="Buscar" CssClass="auto-style49" Width="127px" Font-Bold="True" />
                    </strong>

                </td>
                <td></td>
            </tr>
            </table>
        <div>
        </div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="1500px" CssClass="auto-style63" EmptyDataText="No se encontraron registros">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="CodCliente" HeaderText="Ruc" >
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="Cliente" HeaderText="Razon Social" />
                <asp:BoundField DataField="Enero" HeaderText="Enero" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Febrero" HeaderText="Febrero" DataFormatString="{0:###,###.00}" />
                <asp:BoundField DataField="Marzo" DataFormatString="{0:###,###.00}" HeaderText="Marzo" />
                <asp:BoundField DataField="Abril" DataFormatString="{0:###,###.00}" HeaderText="Abril" />
                <asp:BoundField DataField="Mayo" DataFormatString="{0:###,###.00}" HeaderText="Mayo" />
                <asp:BoundField DataField="Junio" DataFormatString="{0:###,###.00}" HeaderText="Junio" />
                <asp:BoundField DataField="Julio" DataFormatString="{0:###,###.00}" HeaderText="Julio" />
                <asp:BoundField DataField="Agosto" DataFormatString="{0:###,###.00}" HeaderText="Agosto" />
                <asp:BoundField DataField="Septiembre" DataFormatString="{0:###,###.00}" HeaderText="Septiembre" />
                <asp:BoundField DataField="Octubre" DataFormatString="{0:###,###.00}" HeaderText="Octubre" />
                <asp:BoundField DataField="Noviembre" DataFormatString="{0:###,###.00}" HeaderText="Noviembre" />
                <asp:BoundField DataField="Diciembre" DataFormatString="{0:###,###.00}" HeaderText="Diciembre" />
                <asp:BoundField DataField="TOTAL" DataFormatString="{0:###,###.00}" HeaderText="Total" />
                <asp:CommandField SelectText="¿Que le Vendiste?" ShowSelectButton="True" Visible="False" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="False" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
