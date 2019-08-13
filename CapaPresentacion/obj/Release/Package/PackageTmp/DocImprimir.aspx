<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocImprimir.aspx.cs" Inherits="CapaPresentacion.DocImprimir" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 159px;
        }
        .auto-style3 {
            width: 159px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            height: 21px;
            width: 178px;
        }
        .auto-style6 {
            width: 178px;
        }
        .auto-style7 {
            width: 159px;
            height: 26px;
        }
        .auto-style8 {
            width: 178px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 73px;">
            <tr>
                <td class="auto-style3"><strong style="text-align: center">Imprimir Facturas</strong></td>
                <td class="auto-style5"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style7">Empresa</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="dropEmpresa" runat="server" Height="18px" Width="167px">
                        <asp:ListItem>ACS</asp:ListItem>
                        <asp:ListItem>CTS</asp:ListItem>
                        <asp:ListItem>VMS</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo de Documento</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dropDocumento" runat="server" Height="18px" Width="167px">
                        <asp:ListItem>FAAF</asp:ListItem>
                        <asp:ListItem>BOVT</asp:ListItem>
                        <asp:ListItem>NCAF</asp:ListItem>
                        <asp:ListItem>NDAF</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Numero de Documento</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNumDoc" runat="server" Width="156px">2000000007163</asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnImprimir" runat="server" OnClick="btnImprimir_Click" Text="VISTA PREVIA" Width="163px" />
                </td>
            </tr>
            </table>

    </div>
    </form>
</body>
</html>
