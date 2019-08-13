<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAPListaPrecioDetalle.aspx.cs" Inherits="CapaPresentacion.SAPListaPrecioDetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
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
        .auto-style51 {
            color: #000099;
            font-size: small;
        }
        .auto-style63 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: x-small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style40">
    
        <strong><span class="auto-style51">
        <br />
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;- NO INCLUYE IGV - SOLES<br />
        <span class="auto-style11">
               
                    <a href="javascript:window.history.back();">&laquo; Volver a Resultado Anterior</a></span></strong><span class="auto-style13"></div>
                <br />
            
        
   
        <div>

            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>

        </div>
        <asp:GridView ID="GridProductoyVentas" runat="server" AutoGenerateColumns="False" CellPadding="3"  ShowFooter="True" Width="800px" CssClass="auto-style63" Caption="Lista de Precios ACSA [SAP]" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CaptionAlign="Left" OnSelectedIndexChanged="GridProductoyVentas_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanged="GridProductoyVentas_PageIndexChanged" OnPageIndexChanging="GridProductoyVentas_PageIndexChanging" PageSize="50">
            <Columns>
                <asp:BoundField DataField="ItemCode" HeaderText="Còdigo" SortExpression="ListNum" />
                <asp:BoundField DataField="ItemName" HeaderText="Artìculo" SortExpression="ListName" />
                <asp:BoundField DataField="PriceList" HeaderText="Precio Lista" SortExpression="PrimCurr" />
                <asp:BoundField DataField="Price" HeaderText="Precio" SortExpression="Price" />
            </Columns>
            <FooterStyle BackColor="Yellow" Font-Bold="True" ForeColor="#000066" BorderColor="#003366" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Names="Arial" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
</body>
</html>