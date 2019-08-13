using System;
using CapaNegocio;
using CapaEntidad;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel; 


namespace CapaPresentacion
{
    public partial class clientes : System.Web.UI.Page

    {
        ClienteNegocio ClienteNego = new ClienteNegocio();
        ClienteEntidad ClienteEnti = new ClienteEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        DataTable tab = new DataTable();
        //String Ruta = AppDomain.CurrentDomain.BaseDirectory + "otros.xlsx";
        private Excel.Application ApExcel;

        string CodigoOperacion;



        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "Clientes");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Clientes');window.location.href ='menup.aspx';</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
             ListarDatos();
            //txtCotizacion.Focus();
        }

        private void ListarDatos()
        {
            //SLDocument slDoc = new SLDocument();

            try
            {   //tab = ClienteNego.ClienteConsultar(txtDato.Text);
                grdClientes.DataSource = ClienteNego.ClienteConsultar(txtDato.Text);
                grdClientes.DataBind();
            }
            catch (Exception)
            {

            }

            //slDoc.ImportDataTable(1, 1, tab, true);
            //slDoc.SaveAs(Ruta);

 /*           
        // Creamos un objeto Excel.
            Excel.Application Mi_Excel = default(Excel.Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            Excel.Workbook LibroExcel = default(Excel.Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            Excel.Worksheet HojaExcel = default(Excel.Worksheet);


            // Iniciamos una instancia a Excel, y Hacemos visibles para ver como se va creando el reporte, 
            // podemos hacerlo visible al final si se desea.
            Mi_Excel = new Excel.Application();
            Mi_Excel.Visible = true;

            //Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
            //documento en la cual crearemos nuestro informe. 
            
            // Creamos una instancia del Workbooks de excel.            

            LibroExcel = Mi_Excel.Workbooks.Add();
            // Creamos una instancia de la primera hoja de trabajo de excel            
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible;

            // Hacemos esta hoja la visible en pantalla 
            // (como seleccionamos la primera esto no es necesario
            // si seleccionamos una diferente a la primera si lo
            // necesitariamos).
            HojaExcel.Activate();

            // Crear el subencabezado de nuestro informe
            HojaExcel.Range["A2:E2"].Merge();
            HojaExcel.Range["A2:E2"].Value = "CONSULTA DE CLIENTES";
            HojaExcel.Range["A2:E2"].Font.Italic = true;
            HojaExcel.Range["A2:E2"].Font.Size = 10;

            Excel.Range 
            
                objCelda = HojaExcel.Range["A3", Type.Missing];
                objCelda.Value = "EMPRESA";

                objCelda = HojaExcel.Range["B3", Type.Missing];
                objCelda.Value = "RUC";

                objCelda = HojaExcel.Range["C3", Type.Missing];
                objCelda.Value = "CODIGO";
                objCelda.ToString();


                objCelda = HojaExcel.Range["D3", Type.Missing];
                objCelda.Value = "RAZON SOCIAL";

                objCelda = HojaExcel.Range["E3", Type.Missing];
                objCelda.Value = "DIRECCION";

            //objCelda.EntireColumn.NumberFormat = "###,###,###.00";
            int i = 5;

            foreach (System.Data.DataRow fila in tab.Rows)
            {
                TextBox1.Text = fila[1].ToString();
                

                // Asignar los valores de los registros a las celdas
                HojaExcel.Cells[i, "A"] = fila[0].ToString();  // EMPRESA
                HojaExcel.Cells[i, "B"] = "'"+fila[1].ToString();  // RUC
                HojaExcel.Cells[i, "C"] = "'"+Convert.ToString((fila[2].ToString()));  // CODIGO
                HojaExcel.Cells[i, "D"] = fila[3].ToString();  // RAZON SOCIAL
                HojaExcel.Cells[i, "E"] = fila[4].ToString();  // DIRECCION

                // Avanzamos una fila
                i++;
            }
            // Seleccionar todo el bloque desde A1 hasta D #de filas.
            //Excel.Range Rango = HojaExcel.Range["A3:E" + (i - 1).ToString()];

            // Selecionado todo el rango especificado
            //Rango.Select();

            // Ajustamos el ancho de las columnas al ancho máximo del
            // contenido de sus celdas
            //Rango.Columns.AutoFit();

            // Asignar filtro por columna
            //Rango.AutoFilter(1);
            */
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void grdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tclientedet");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("clientedetalle.aspx?datos1=" + this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[0].Text + "&datos2=" + this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[2].Text + "&datos3=" + this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[3].Text);

                /*Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() 
                    + "&datos2=" + Label2.Text.ToString()
                    + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text 
                    + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text 
                    + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);*/
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tclientedet');</script>");
                Response.Redirect("sico.aspx");
            }
        }

        protected void grdClientes_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {

            
            
        }

        protected void grdClientes_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            
        }
    }
}