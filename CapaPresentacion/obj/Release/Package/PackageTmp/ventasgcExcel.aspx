<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventasgcExcel.aspx.cs" Inherits="CapaPresentacion.ventasgcExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            color: #0033CC;
            font-size: x-small;
        }
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
            width: 408px;
            color: #000099;
            height: 26px;
        }
        .auto-style43 {
            width: 249px;
            color: #0033CC;
            font-size: x-small;
            height: 26px;
        }
        .auto-style45 {
            width: 244px;
            height: 26px;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 244px;
            color: #0033CC;
            height: 26px;
        }
        .auto-style49 {
            color: #006600;
            background-color: #FFFF00;
        }
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style53 {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            margin-left: 0px;
            color: #000099;
            font-weight: bold;
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
        .auto-style60 {
            color: #003399;
            font-size: small;
        }
        .auto-style61 {
            width: 249px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 627px;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        .auto-style64 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 408px;
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
        .auto-style68 {
            width: 244px;
            color: #000099;
            height: 26px;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style69 {
            width: 249px;
            text-align: left;
            height: 27px;
        }
        .auto-style71 {
            color: #FFFFFF;
            background-color: #339933;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        VENTAS GRUPO CORPORATIVO -&nbsp; DETALLADAS EN EXCEL - NO INCLUYE IGV - SOLES<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style64">Fecha Inicial :</td>
                <td class="auto-style69"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date">01/11/2018</asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style65"></td>
            </tr>
            <tr>
                <td class="auto-style42">Fecha Final :</td>
                <td class="auto-style43"><strong>
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="120px" TextMode="Date">30/11/2018</asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style45"></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Canal :</strong></td>
                <td class="auto-style61">
                    <asp:DropDownList ID="ddlList" runat="server" CssClass="auto-style60" Font-Bold="True" Height="22px" Width="125px">
                        <asp:ListItem>Total</asp:ListItem>
                        <asp:ListItem>PDV</asp:ListItem>
                        <asp:ListItem>MAYORISTAS</asp:ListItem>
                        <asp:ListItem>RETAIL</asp:ListItem>
                        <asp:ListItem>CORPORATIVOS</asp:ListItem>
                        <asp:ListItem>PROYECTOS-INGENIERIA</asp:ListItem>
                        <asp:ListItem>COTIZADORES</asp:ListItem>
                        <asp:ListItem>Oficina</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Archivo en Excel [ STARSOFT / PROMATISA ]" CssClass="auto-style49" Width="331px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" style="height: 26px" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Marca :</strong></td>
                <td class="auto-style61">
                    <asp:DropDownList ID="ddlListMarca" runat="server" CssClass="auto-style60" Font-Bold="True" Height="22px" Width="125px">
                        <asp:ListItem>Todos</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td class="auto-style48"><strong>
        <asp:Button ID="btnVentaPBuscar0" runat="server" OnClick="btnVentaPBuscar0_Click" Text="Archivo en Excel [SAP BUSSINES ONE / ACSA ]" CssClass="auto-style49" Width="331px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Cliente :</strong></td>
                <td class="auto-style61">
                    <strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtRuc" runat="server" CssClass="auto-style53" Width="120px">0</asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                    </td>
                <td class="auto-style68"><strong>&quot;0&quot; Para Todos los Clientes</strong></td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style67"><strong>
        <asp:Button ID="btnVentaPBuscar1" runat="server" Text="Archivo en Excel [ STARSOFT / ENTRE EMPRESA ]" CssClass="auto-style71" Width="331px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" style="height: 26px" OnClick="btnVentaPBuscar1_Click" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style67"><strong>
        <asp:Button ID="btnVentaPBuscar2" runat="server" Text="Archivo en Excel [SAP / ENTRE EMPRESA ]" CssClass="auto-style71" Width="331px" Font-Bold="True" BorderColor="#003399" BorderStyle="Solid" OnClick="btnVentaPBuscar2_Click" />
                    </strong></td>
            </tr>
            </table>
        <div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="500px" CssClass="auto-style63">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="CanalCod" HeaderText="Canal Cod." >
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="CanalDesc" HeaderText="Canal Desc." >
                <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
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
