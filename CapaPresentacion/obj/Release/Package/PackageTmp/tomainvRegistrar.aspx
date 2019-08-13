<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tomainvRegistrar.aspx.cs" Inherits="CapaPresentacion.tomainvRegistrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.5" />
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
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style57 {
            color: #FFFFFF;
            font-size: small;
        }
        .auto-style59 {
            width: 420px;
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
            width: 256px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style65 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #000099;
        }
        .auto-style66 {
            color: #0033CC;
            font-weight: bold;
        }
        .auto-style67 {
            color: #000099;
        }
        .auto-style68 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        TOMA DE INVENTARIO - Detalle<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para </span>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="tomainvEstados.aspx">Retornar a Pagna Anterior</asp:HyperLink>
        <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style59"><strong>Conteo :</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlList0" runat="server" Height="17px" Width="128px" CssClass="auto-style66" AutoPostBack="True" OnSelectedIndexChanged="ddlList0_SelectedIndexChanged" >
                        <asp:ListItem>Conteo 1</asp:ListItem>
                        <asp:ListItem>Conteo 2</asp:ListItem>
                        <asp:ListItem>Conteo 3</asp:ListItem>
                        <asp:ListItem>Conteo 4</asp:ListItem>
                        <asp:ListItem>Conteo 5</asp:ListItem>
                        <asp:ListItem>Conteo 6</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Inventario Nro:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlList" runat="server" Height="16px" Width="129px" CssClass="auto-style66">
                    </asp:DropDownList>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Codigo:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:TextBox ID="txtCodigo" runat="server" Width="123px" CssClass="auto-style67" AutoPostBack="True" OnTextChanged="txtCodigo_TextChanged" OnUnload="txtCodigo_Unload"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Descripcón:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:Label ID="lblDes" runat="server" CssClass="auto-style68" Text="..."></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Cantidad Contada:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:TextBox ID="txtCantidad" runat="server" Width="123px" CssClass="auto-style67"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Ubicación:</strong></td>
                <td class="auto-style61"><strong>
                    <asp:DropDownList ID="ddlList1" runat="server" Height="17px" Width="130px" CssClass="auto-style66" AutoPostBack="True" OnSelectedIndexChanged="ddlList0_SelectedIndexChanged" >
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>
                    <asp:Button ID="btnTomaInvActualizarC" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="btnTomaInvActualizarC_Click" Text="Actualizar Conteo" Width="130px" Visible="False" />
                    </strong></td>
                <td class="auto-style61"><strong>
                    <asp:Button ID="btnTomaInvActualizar" runat="server" BorderStyle="Solid" CssClass="auto-style65" OnClick="Button1_Click" Text="Registrar Conteo" Width="130px" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="717px" CssClass="auto-style63">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="invcodigo" HeaderText="Nro. Toma Inv" >
                </asp:BoundField>
                <asp:BoundField DataField="invfecha" DataFormatString="{0:d}" HeaderText="Inv.Fecha" />
                <asp:BoundField DataField="invusuario" HeaderText="Usuario" />
                <asp:BoundField DataField="invresponsable" HeaderText="Responsable" />
                <asp:BoundField DataField="invfechainicio" DataFormatString="{0:d}" HeaderText="Fecha Inicio" />
                <asp:BoundField DataField="invfechafin" DataFormatString="{0:d}" HeaderText="Fecha Fin" />
                <asp:BoundField DataField="invalmacen" HeaderText="Almacen Cod." />
                <asp:BoundField DataField="invalmacendes" HeaderText="Almacen Des" />
                <asp:BoundField DataField="investado" HeaderText="Estado" />
                <asp:BoundField DataField="invdproducto" HeaderText="Cod. Producto" />
                <asp:BoundField DataField="invddescripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="invdunidad" HeaderText="Unidad" />
                <asp:BoundField DataField="invdstocksis1" HeaderText="Stock Sis 1" />
                <asp:CommandField HeaderText="Detalle de Toma de Inv." SelectText="Ver Detalle" ShowSelectButton="True" >
                <HeaderStyle HorizontalAlign="Left" />
                </asp:CommandField>
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
        </div>
    </form>
</body>
</html>
