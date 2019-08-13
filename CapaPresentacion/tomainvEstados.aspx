<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tomainvEstados.aspx.cs" Inherits="CapaPresentacion.tomainvEstados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
        .auto-style48 {
            width: 235px;
            color: #0033CC;
            height: 26px;
        }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style59 {
            width: 408px;
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
            width: 476px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        TOMA DE INVENTARIO - ESTADOS<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al 
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="tomainvmenu.aspx">Menú Toma de Inventario</asp:HyperLink>
        </span>
            </span>
        </span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="717px" CssClass="auto-style63" OnRowCommand="GridProductoyVentas_RowCommand">
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
                <asp:TemplateField HeaderText="Detalle de Toma de Inv." ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Ver Detalle"></asp:LinkButton>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:CommandField HeaderText="A Excel" ShowSelectButton="True" />
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
