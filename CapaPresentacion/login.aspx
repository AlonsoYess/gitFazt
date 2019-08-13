<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CapaPresentacion.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Table1 {
            width: 185px;
        }
        .auto-style1 {
            height: 23px;
            text-align: center;
        }
        .auto-style7 {
            width: 251px;
            height: 153px;
        }
        .auto-style8 {
            height: 23px;
            text-align: right;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            color: #000080;
        }
        .auto-style10 {
            height: 23px;
            text-align: center;
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
            color: #000080;
        }
        .auto-style11 {
            font-size: small;
            color: #000080;
        }
        .auto-style12 {
            font-size: small;
            color: #000080;
            text-align: right;
            height: 6px;
        }
        .auto-style13 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #000080;
            font-weight: bold;
        }
        .auto-style14 {
            color: #FF0000;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <Table ID="Table1" runat="server" align="center" class="auto-style7">
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        <strong>
                        <asp:Label ID="lblRespuesta" runat="server" CssClass="auto-style14"></asp:Label>
                        </strong>
                        </td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        &nbsp;</td>
                </tr>
              <tr>
                    <td class="auto-style10" dir="ltr" colspan="2">
                        <strong>INICIO DE SESION</strong></td>
                </tr>
              <tr>
                    <td class="auto-style8" dir="ltr">
                        <strong>USUARIO</strong></td>
                    <td class="auto-style1" dir="ltr">
                        <asp:TextBox ID="txtUsuario" runat="server" BorderStyle="Double" CssClass="auto-style11" Width="100px"></asp:TextBox>
                    </td>
                </tr>
              <tr>
                    <td class="auto-style8" dir="ltr">
                        <strong>CONTRASEÑA</strong></td>
                    <td class="auto-style1" dir="ltr">
                        <asp:TextBox ID="txtClave" runat="server" BorderStyle="Double" CssClass="auto-style11" TextMode="Password" Width="100px"></asp:TextBox>
                    </td>
                </tr>
              <tr>
                    <td class="auto-style12" dir="ltr" colspan="2">
                        <strong>
                        <asp:Button ID="btnIngresar" runat="server" BorderStyle="Dotted" BorderWidth="2px" CssClass="auto-style13" Height="33px" OnClick="btnIngresar_Click" Text="INGRESAR" Width="250px" />
                        </strong></td>
                </tr>


        </Table>
    </form>
</body>
</html>
