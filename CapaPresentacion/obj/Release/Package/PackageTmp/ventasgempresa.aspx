<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="ventasgempresa.aspx.cs" Inherits="CapaPresentacion.ventasgempresa"  %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
  <link type="text/css"rel="stylesheet"
     href="http://jquery-ui.googlecode.com/svn/tags/1.7/themes/redmond/jquery-ui.css" />   
  <script type="text/javascript"
     src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.min.js"></script>
  <script type="text/javascript"
     src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.7.2/jquery-ui.min.js"></script>
    <script>

 $.datepicker.regional['es'] = {
 closeText: 'Cerrar',
 prevText: '  < Ant ] ',
 nextText: '  [ Sig > ',
 currentText: 'Hoy',
 monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
 monthNamesShort: ['Ene','Feb','Mar','Abr', 'May','Jun','Jul','Ago','Sep', 'Oct','Nov','Dic'],
 dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
 dayNamesShort: ['Dom','Lun','Mar','Mié','Juv','Vie','Sáb'],
 dayNamesMin: ['Do','Lu','Ma','Mi','Ju','Vi','Sá'],
 weekHeader: 'Sm',
 dateFormat: 'dd/mm/yy',
 firstDay: 7,
 isRTL: false,
 showMonthAfterYear: false,
 yearSuffix: '-'
 };
 $.datepicker.setDefaults($.datepicker.regional['es']);
$(function () {
    $("#TextBox1").datepicker();
    $("#TextBox3").datepicker();
});
</script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  </head>
<body>
    <form id="form1" runat="server">
         <div></div>
    <div class="auto-style1">
    
        <div class="auto-style16">
            <span class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <br class="auto-style15" />
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style9">Desde : </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style12">01/01/2018</asp:TextBox>
                </td>
                <td class="auto-style7">Hasta :</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style12">02/01/2018</asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style12" OnClick="Button1_Click" Text="Ver Reporte" Width="189px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style12" OnClick="Button2_Click" Text="Exportar Excel" Width="194px" Visible="False" />
                </td>
            </tr>
            </table>
    
    </div>
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server" Visible="False">
            <Report FileName="rVentasEmpresaGenerales.rpt">
            </Report>
        </CR:CrystalReportSource>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" OnInit="CrystalReportViewer1_Init" ReportSourceID="CrystalReportSource1" ToolPanelView="None" ReuseParameterValuesOnRefresh="True" Visible="False" />
    </form>
</body>
</html>
