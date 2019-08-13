<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAPSeguimientoOC1.aspx.cs" Inherits="CapaPresentacion.SAPSeguimientoOC1" %>

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

         .auto-style13 {
            height: 23px;
            font-family: Arial;
            font-size: 9px;
            
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
        }
        .auto-style43 {
            width: 269px;
        }
        .auto-style24 {
            background-color: #FFFFFF;
        }
        .auto-style46 {
            color: #0033CC;
            background-color: #FFFFFF;
        }
        .auto-style48 {
            width: 289px;
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
            width: 801px;
        }
        .auto-style64 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            font-weight: bold;
            width: 408px;
            color: #000099;
            height: 26px;
        }
        .auto-style66 {
            width: 448px;
            text-align: left;
            height: 26px;
        }
        .auto-style67 {
            width: 448px;
        }
        </style>
</head>
<body>
 <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        Seguimiento de OC<br />
        <span class="auto-style11">
                <span class="auto-style24">Click aquí para regresar al </span>
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style46" NavigateUrl="menup.aspx">Menú Principal</asp:HyperLink>
                <br />
            </span>
        </span><span class="auto-style57">*</span></strong></div>
   
        <table class="auto-style62">
            <tr>
                <td class="auto-style64">Fecha Inicial :</td>
                <td class="auto-style61"><strong><span class="auto-style4">
                    <span class="auto-style1">
                    <span class="auto-style11">
                    <asp:TextBox ID="txtFecha1" runat="server" CssClass="auto-style53" Width="150px" TextMode="Date"></asp:TextBox>
        </span>
        </span>
            </span>
        </strong>
                </td>
                <td class="auto-style64">Solicitud :</td>
                <td class="auto-style66">
                    <asp:TextBox ID="txtsolicitud" runat="server" CssClass="auto-style53" Width="110px"></asp:TextBox>
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="#DDD755" ReadOnly="True" Width="50px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style42">Fecha Final :</td>
                <td class="auto-style43"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtFecha2" runat="server" CssClass="auto-style53" Width="150px" TextMode="Date"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style64">Orden :</td>
                <td class="auto-style66">
                    <asp:TextBox ID="txtOrden" runat="server" CssClass="auto-style53" Width="110px"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" BackColor="#C5F8F2" ReadOnly="True" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <strong>
                        <asp:Button ID="btnDescargarExcel" runat="server" CssClass="auto-style49" Text="Descargar EXCEL" Width="132px" OnClick="btnDescargarExcel_Click" Font-Bold="True"/>
                    </strong>
                 </td>
            </tr>
            <tr>
                <td class="auto-style59"><strong>Código Proveedor :</strong></td>
                <td class="auto-style61"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtxCodProveedor" runat="server" CssClass="auto-style53" Width="150px"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                
                <td class="auto-style59"><strong>Entrada :</strong></td>
                <td class="auto-style67">
                    <asp:TextBox ID="txtEntrada" runat="server" CssClass="auto-style53" Width="110px"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" BackColor="#FF8040" ReadOnly="True" Width="50px"></asp:TextBox>
                </td>
                <td class="auto-style48">
                    <strong>
                        <asp:Button ID="btnVentaPBuscar" runat="server" OnClick="btnVentaPBuscar_Click" Text="Buscar" CssClass="auto-style49" Width="132px" Font-Bold="True" />
                    </strong>
                </td>
            </tr>
            <tr>
                 <td class="auto-style59"><strong>Nombre Proveedor :</strong></td>
                <td class="auto-style61"><strong><span class="auto-style11">
                    <span class="auto-style4">
                    <asp:TextBox ID="txtNomProveedor" runat="server" CssClass="auto-style53" Width="150px"></asp:TextBox>
            </span>
        </span>
        </strong>
                </td>
                <td class="auto-style59"><strong>Factura :</strong></td>
                <td class="auto-style67">
                    <asp:TextBox ID="txtFactura" runat="server" CssClass="auto-style53" Width="110px"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" BackColor="#FBDDD5" ReadOnly="True" Width="50px"></asp:TextBox>
                 </td>
            </tr>
            </table>
        <div>
            <asp:GridView ID="grdSeguimiento" runat="server" AutoGenerateColumns="False" Width="2100px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Caption="Seguimiento de OC" CaptionAlign="Left" CellPadding="3" CssClass="auto-style13" AllowPaging="True" EmptyDataText="No se encontraron registros" OnPageIndexChanging="grdSeguimiento_PageIndexChanging" PageSize="50">
                <Columns>
                    <asp:BoundField DataField="CardCode" HeaderText="Cod.Proveedor" SortExpression="CardCode" />
                    <asp:BoundField DataField="CardName" HeaderText="Proveedor" SortExpression="CardName" />
                    <asp:BoundField DataField="FechaSolicitud" HeaderText="FechaSolicitud" SortExpression="FechaSolicitud" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#DDD755" />
                    <ItemStyle BackColor="#DDD755" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaNecesariaSolicitud" HeaderText="FechaNecesariaSolicitud" SortExpression="FechaNecesariaSolicitud" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#DDD755" />
                    <ItemStyle BackColor="#DDD755" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NombreSolicitud" HeaderText="Solicitante" SortExpression="NombreSolicitud" >
                    <HeaderStyle BackColor="#DDD755" />
                    <ItemStyle BackColor="#DDD755" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroSolicitud" HeaderText="Nro.Sol" SortExpression="NumeroSolicitud" >
                    <HeaderStyle BackColor="#DDD755" />
                    <ItemStyle BackColor="#DDD755" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaOC" HeaderText="FechaOC" SortExpression="FechaOC" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaEntregaOC" HeaderText="FechaEntregaOC" SortExpression="FechaEntregaOC" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroOC" HeaderText="NroOC" SortExpression="NumeroOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TipoProveedorOC" HeaderText="Tipo Prov." SortExpression="TipoProveedorOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TipoOC" HeaderText="Tipo OC" SortExpression="TipoOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AlmacenOC" HeaderText="Alm.OC" SortExpression="AlmacenOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="MonedaOC" HeaderText="Moneda" SortExpression="MonedaOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="EstadoOC" HeaderText="Estado OC" SortExpression="EstadoOC" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalOC" HeaderText="Total OC" SortExpression="TotalOC" DataFormatString="{0: 0.00}" >
                    <HeaderStyle BackColor="#C5F8F2" />
                    <ItemStyle BackColor="#C5F8F2" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaEM" HeaderText="FechaEM" SortExpression="FechaEM" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#FF8040" />
                    <ItemStyle BackColor="#FF8040" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroEM" HeaderText="NumeroEM" SortExpression="NumeroEM" >
                    <HeaderStyle BackColor="#FF8040" />
                    <ItemStyle BackColor="#FF8040" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ReferenciaEM" HeaderText="ReferenciaEM" SortExpression="ReferenciaEM" >
                    <HeaderStyle BackColor="#FF8040" />
                    <ItemStyle BackColor="#FF8040" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalEM" HeaderText="TotalEM" SortExpression="TotalEM" DataFormatString="{0: 0.00}" >
                    <HeaderStyle BackColor="#FF8040" />
                    <ItemStyle BackColor="#FF8040" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroFactura" HeaderText="NroFactura" SortExpression="NumeroFactura" >
                    <HeaderStyle BackColor="#FBDDD5" />
                    <ItemStyle BackColor="#FBDDD5" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FechaFactura" HeaderText="FechaFac." SortExpression="FechaFactura" DataFormatString="{0:dd/MM/yyyy}" >
                    <HeaderStyle BackColor="#FBDDD5" />
                    <ItemStyle BackColor="#FBDDD5" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ReferenciaFactura" HeaderText="Ref.Fac" SortExpression="ReferenciaFactura" >
                    <HeaderStyle BackColor="#FBDDD5" />
                    <ItemStyle BackColor="#FBDDD5" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroSunat" HeaderText="NroSunat" SortExpression="NumeroSunat" >
                    <HeaderStyle BackColor="#FBDDD5" />
                    <ItemStyle BackColor="#FBDDD5" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalFactura" HeaderText="TotalFactura" SortExpression="TotalFactura" DataFormatString="{0: 0.00}" >
                    <HeaderStyle BackColor="#FBDDD5" />
                    <ItemStyle BackColor="#FBDDD5" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>