<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SapDocAutorizados.aspx.cs" Inherits="CapaPresentacion.SapDocAutorizados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Documentos Autorizados</title>
<style>
    .auto-style13 {
            height: 23px;
            font-family: Arial;
            font-size: x-small;
            
        }
    .auto-style14 {
        width: 121px;
    }
    .auto-style15 {
        width: 114px;
    }
    .auto-style16 {
        width: 241px;
    }
    .auto-style53 {}
    .auto-style54 {
        width: 141px;
    }
    .auto-style55 {
        width: 142px;
    }
</style>
    <script>
        function solonumeros(e) {
 
            var key;
 
            if (window.event) // IE
            {
                key = e.keyCode;
            }
            else if (e.which) // Netscape/Firefox/Opera
            {
                key = e.which;
            }
 
            if (key < 48 || key > 57) {
                return false;
            }
 
            return true;
        }
 
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        Flujo de ordenes de Venta<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" OnTick="Timer1_Tick1" Interval="300000">
        </asp:Timer>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style16">Fecha Inicial :</td>
                <td class="auto-style54"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="auto-style53" Width="147px" TextMode="Date"></asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style55"></td>
                <td class="auto-style14">Cotización :</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="#DDD755" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style14">Guia :</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox5" runat="server" BackColor="#FBDDD5" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Fecha Final :</td>
                <td class="auto-style54"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFechaFin" runat="server" CssClass="auto-style53" Width="147px" TextMode="Date"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style55">
                    
                </td>
                
                <td class="auto-style14">Preliminar :</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox2" runat="server" BackColor="#C5F8F2" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style14">Factura :</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox6" runat="server" BackColor="#80FF80" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Número Orden :</td>
                <td class="auto-style54">
                    <asp:TextBox ID="txtNumSAP" runat="server" Width="148px" onkeypress="javascript:return solonumeros(event)" MaxLength="10"></asp:TextBox>

                </td>
                <td class="auto-style55">
        
                </td>
                <td class="auto-style14">Autorización:</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox3" runat="server" BackColor="#FF8040" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Código Cliente :</td>
                <td class="auto-style54">
                    <asp:TextBox ID="txtCodCliente"  runat="server" Width="148px" MaxLength="12"></asp:TextBox>

                </td>
                <td class="auto-style55">
                    
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" Width="101px" />
                    
                </td>
                <td class="auto-style14">Orden de Venta:</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox4" runat="server" BackColor="Yellow" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16"> Almacén :</td>
                <td>

                    <asp:DropDownList ID="ddAlm" runat="server" Height="19px" Width="153px">
                        <asp:ListItem Selected="True" Value="0">[Todos]</asp:ListItem>
                        <asp:ListItem Value="ALMSHA">Shangrila</asp:ListItem>
                        <asp:ListItem Value="ALMAZA">Azángaro</asp:ListItem>
                        <asp:ListItem Value="ALMBAM">Bambas</asp:ListItem>
                        <asp:ListItem Value="ALMRET">Retail</asp:ListItem>
                    </asp:DropDownList>

                </td>
                <td class="auto-style16"> </td>
                <td class="auto-style14">Reserva</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox7" runat="server" BackColor="#FBFAD5" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            </table>
        <div>
            <br />
        <asp:GridView ID="grdDocAutorizados" runat="server" AutoGenerateColumns="False" CellPadding="3" OnRowDataBound="GridProductoyVentas_RowDataBound" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" ShowFooter="True" Width="2000px" CssClass="auto-style13" Caption="Listado de Ordenes" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left">
            <Columns>
                <asp:BoundField DataField="FechaCoti" HeaderText="COT-Fecha" SortExpression="FechaCoti" >
                <HeaderStyle BackColor="#DDD755" ForeColor="#003300" />
                <ItemStyle BackColor="#DDD755" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraCoti" HeaderText="COT-Hora" SortExpression="HoraCoti" >
                <HeaderStyle BackColor="#DDD755" ForeColor="#003300" />
                <ItemStyle BackColor="#DDD755" />
                </asp:BoundField>
                <asp:BoundField DataField="NumSAPCoti" HeaderText="COT-Nro" SortExpression="NumSAPCoti" >
                <HeaderStyle BackColor="#DDD755" ForeColor="#003300" />
                <ItemStyle BackColor="#DDD755" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreCoti" HeaderText="COT-Creador" SortExpression="NombreCoti" >
                <HeaderStyle BackColor="#DDD755" ForeColor="#003300" />
                <ItemStyle BackColor="#DDD755" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreBorrador" HeaderText="PRE-Creador" SortExpression="NombreBorrador" >
                <HeaderStyle BackColor="#C5F8F2" Font-Bold="True" ForeColor="#003300" />
                <ItemStyle BackColor="#C5F8F2" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaBorrador" HeaderText="PRE-Fecha" SortExpression="FechaBorrador" DataFormatString="{0:d}" >
                <HeaderStyle BackColor="#C5F8F2" ForeColor="#003300" />
                <ItemStyle BackColor="#C5F8F2" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraBorrador" HeaderText="PRE-Hora" SortExpression="HoraBorrador" >
                <HeaderStyle BackColor="#C5F8F2" ForeColor="#003300" />
                <ItemStyle BackColor="#C5F8F2" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreAutoriza" HeaderText="AUT-Autoriza" >
                <HeaderStyle HorizontalAlign="Center" BackColor="#FF8040" ForeColor="#003300" />
                
                <ItemStyle BackColor="#FF8040" />
                
                </asp:BoundField>
                <asp:BoundField DataField="FechaAutoriza" HeaderText="AUT-Fecha" SortExpression="FechaAutoriza" DataFormatString="{0:d}" >
                <HeaderStyle BackColor="#FF8040" ForeColor="#003300" />
                <ItemStyle BackColor="#FF8040" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraAutoriza" HeaderText="AUT-Hora" SortExpression="HoraAutoriza" >
                <HeaderStyle BackColor="#FF8040" ForeColor="#003300" />
                <ItemStyle BackColor="#FF8040" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaOV" HeaderText="OV-Fecha" SortExpression="FechaOV" DataFormatString="{0:d}" >
                <HeaderStyle BackColor="Yellow" ForeColor="#003300" />
                <ItemStyle BackColor="Yellow" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraOV" HeaderText="OV-Hora" SortExpression="HoraOV" >
                <HeaderStyle BackColor="Yellow" ForeColor="#003300" />
                <ItemStyle BackColor="Yellow" />
                </asp:BoundField>
                <asp:BoundField DataField="NumSAPOV" HeaderText="OV-Nro" SortExpression="NumSAPOV" >
                <HeaderStyle BackColor="Yellow" ForeColor="#003300" />
                <ItemStyle BackColor="Yellow" />
                </asp:BoundField>
                <asp:BoundField DataField="Almacen" HeaderText="OV-Almacén" SortExpression="Almacen">
                <HeaderStyle BackColor="Yellow" ForeColor="#003300" />
                <ItemStyle BackColor="Yellow" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreOV" HeaderText="OV-Creador" SortExpression="NombreOV">
                <HeaderStyle BackColor="Yellow" ForeColor="#003300" />
                <ItemStyle BackColor="Yellow" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaReserva" DataFormatString="{0:d}" HeaderText="F.RES-Fecha" SortExpression="FechaReserva">
                <HeaderStyle BackColor="#FBFAD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBFAD5" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraReserva" HeaderText="F.RES-Hora" SortExpression="HoraReserva">
                <HeaderStyle BackColor="#FBFAD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBFAD5" />
                </asp:BoundField>
                <asp:BoundField DataField="NumSAPReserva" HeaderText="F.RES-Nro" SortExpression="NumSAPReserva">
                <HeaderStyle BackColor="#FBFAD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBFAD5" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreReserva" HeaderText="F.RES-Creador" SortExpression="NombreReserva">
                <HeaderStyle BackColor="#FBFAD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBFAD5" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaGuia" HeaderText="GUÍA-Fecha" SortExpression="FechaGuia" DataFormatString="{0:d}" >
                <HeaderStyle BackColor="#FBDDD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBDDD5" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraGuia" HeaderText="GUÍA-Hora" SortExpression="HoraGuia" >
                <HeaderStyle BackColor="#FBDDD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBDDD5" />
                </asp:BoundField>
                <asp:BoundField DataField="NumSAPGuia" HeaderText="GUÍA-Nro" SortExpression="NumSAPGuia" >
                <HeaderStyle BackColor="#FBDDD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBDDD5" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreGuia" HeaderText="GUÍA-Creador" SortExpression="NombreGuia" >
                <HeaderStyle BackColor="#FBDDD5" ForeColor="#003300" />
                <ItemStyle BackColor="#FBDDD5" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaFactura" HeaderText="FACT-Fecha" SortExpression="FechaFactura">
                <HeaderStyle BackColor="#80FF80" ForeColor="#003300" />
                <ItemStyle BackColor="#80FF80" />
                </asp:BoundField>
                <asp:BoundField DataField="HoraFactura" HeaderText="FACT-Hora" SortExpression="HoraFactura">
                <HeaderStyle BackColor="#80FF80" ForeColor="#003300" />
                <ItemStyle BackColor="#80FF80" />
                </asp:BoundField>
                <asp:BoundField DataField="NumSAPFactura" HeaderText="FACT-Nro" SortExpression="NumSAPFactura">
                <HeaderStyle BackColor="#80FF80" ForeColor="#003300" />
                <ItemStyle BackColor="#80FF80" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreFactura" HeaderText="FACT-Creador" SortExpression="NombreFactura">
                <HeaderStyle BackColor="#80FF80" ForeColor="#003300" />
                <ItemStyle BackColor="#80FF80" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="Yellow" Font-Bold="True" ForeColor="#000066" BorderColor="#003366" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </div>
    </form>
</body>
</html>
