<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tomainv.aspx.cs" Inherits="CapaPresentacion.tomainv" %>

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
            width: 366px;
            color: #000099;
        }
        .auto-style43 {
            width: 410px;
        }
        .auto-style45 {
            width: 235px;
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
            width: 366px;
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
            width: 410px;
            text-align: left;
            height: 26px;
        }
        .auto-style62 {
            width: 665px;
        }
        .auto-style63 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 366px;
            color: #000099;
            height: 26px;
        }
        .auto-style64 {
            width: 235px;
            height: 26px;
        }
        .auto-style65 {
            color: #336699;
            font-weight: bold;
        }
        .auto-style66 {
            font-family: Arial, Helvetica, sans-serif;
            color: #0000FF;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        TOMA DE INVENTARIO - GENERAR INVENTARIO<br />
        <span class="auto-style11">
                
                    <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="tomainvmenu.aspx">Menú Toma de Inventario</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style63">Usuario :</td>
                <td class="auto-style61"><strong>
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="auto-style65" ReadOnly="True" Width="187px"></asp:TextBox>
                    </strong>
                </td>
                <td class="auto-style64">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style63">Fecha de Toma de Inventario :</td>
                <td class="auto-style61"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha0" runat="server" CssClass="auto-style53" Width="187px" TextMode="Date">01/11/2018</asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style64">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style63">Fecha Inicio del Inventario :</td>
                <td class="auto-style61"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="187px" TextMode="Date">01/11/2018</asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style64"></td>
            </tr>
            <tr>
                <td class="auto-style42">Fecha Final del Inventario :</td>
                <td class="auto-style43"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="187px" TextMode="Date">30/11/2018</asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style45">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Almacen a Inventariar :</strong></td>
                <td class="auto-style61">
                    <asp:DropDownList ID="ddlList" runat="server" CssClass="auto-style60" Font-Bold="True" Height="25px" Width="314px">
                    </asp:DropDownList>
                    </td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Responsable de Inventario :</strong></td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtResponsable" runat="server" Width="306px"></asp:TextBox>
                </td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Estado :</strong></td>
                <td class="auto-style61">
                    <strong>
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="auto-style65" Enabled="False" Height="23px" Width="197px">
                        <asp:ListItem>Inicial</asp:ListItem>
                        <asp:ListItem>Autorizado</asp:ListItem>
                        <asp:ListItem>Aperturado</asp:ListItem>
                    </asp:DropDownList>
                    </strong>
                </td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Observaciones :</strong><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtObs" runat="server" Width="306px"></asp:TextBox>
                </td>
                <td class="auto-style48"></td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Respuesta :</strong></td>
                <td class="auto-style61">
                    <strong>
                    <asp:HyperLink ID="hpLink" runat="server" CssClass="auto-style66" NavigateUrl="tomainvEstados.aspx">.</asp:HyperLink>
                    </strong></td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style59">&nbsp;</td>
                <td class="auto-style61">
                    <strong>
        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Generar Toma de Inventario" CssClass="auto-style49" Width="196px" Font-Bold="True" BorderStyle="Solid" />
                    </strong>
                </td>
                <td class="auto-style48">&nbsp;</td>
            </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>
