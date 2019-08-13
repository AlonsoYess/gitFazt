<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imprimir.aspx.cs" Inherits="CapaPresentacion.Imprimir" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" BorderStyle="Ridge" OnClick="Button1_Click" style="text-align: center" Text="IMPRIMIR" />
&nbsp;<asp:Label ID="lblmonto" runat="server" Text="Label"></asp:Label>
        </div>
        <CR:CrystalReportViewer ID="crptvisor1" runat="server" AutoDataBind="True"  Height="1202px" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" ReportSourceID="CrystalReportSource1" ToolPanelView="None" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="rptimpresion.rpt">
            </Report>
        </CR:CrystalReportSource>
    </form>
</body>
</html>
