using System;
using CapaNegocio;
using CapaEntidad;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI.HtmlControls;
using SpreadsheetLight;


namespace CapaPresentacion
{
       
        public partial class facturalistado : System.Web.UI.Page

    {
        FacturaListadoNegocio FacturaListadoNego = new FacturaListadoNegocio();
        FacturaListadoEntidad FacturaListadoEnti = new FacturaListadoEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        DataTable tab = new DataTable();
        //String Ruta = AppDomain.CurrentDomain.BaseDirectory + "otros.xlsx";
        private Excel.Application ApExcel;

        //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();


        public void CrearExcel()
        {
            try
            {
                //creamos el objeto SLDocument el cual creara el excel
                SLDocument slDoc = new SLDocument();

                //creamos las celdas en diagonal
                //utilizando la función setcellvalue pueden navegar sobre el documento
                //primer parametro es la fila el segundo la columna y el tercero el dato de la celda
                for (int j = 1; j <= 10; ++j)
                {
                    slDoc.SetCellValue(j,j,j);
                    
                }


                // SetCellValue(i, i, "patito " + i);

                //Guardar como, y aqui ponemos la ruta de nuestro archivo
                slDoc.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "/" + "pato.xls");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio una Excepción: " + ex.Message);
            }

        }



        protected void Page_Load(object sender, EventArgs e)
        {
            //txtFei.Text  =  Convert.ToString(DateTime.Today);
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "facturalistado");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Consulta - Listado de Facturas');window.location.href ='menup.aspx';</script>");
            }

            if (!Page.IsPostBack)
            {
                //Text = DateTime.Now.ToString("yyyy-MM-dd");

                txtFef.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = DateTime.Now;

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFei.Text = FechaI.ToString("yyyy-MM-dd");
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
            {                
                grdClientesCotiz.DataSource = FacturaListadoNego.FacturaListadoConsultarDT(Convert.ToDateTime(txtFei.Text), Convert.ToDateTime(txtFef.Text),ddlEmp.Text,"0");
                grdClientesCotiz.DataBind();
               // tab = FacturaListadoNego.FacturaListadoConsultar(ddlEmp.Text, ddlSerie.Text, txtFei.Text, txtFef.Text);
            }
            catch (Exception)
            {

            }            
        }
    /*    private void FacturaListadoExcel()
        {
            //SLDocument slDoc = new SLDocument();

            try
            {
                tab = FacturaListadoNego.FacturaListadoConsultarDT(ddlEmp.Text, ddlSerie.Text, txtFei.Text, txtFef.Text);
            }
            catch (Exception)
            {

            }

            //slDoc.ImportDataTable(1, 1, tab, true);
            //slDoc.SaveAs(Ruta);


            // Creamos un objeto Excel.
            Excel.Application Mi_Excel = default(Excel.Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            Excel.Workbook LibroExcel = default(Excel.Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            Excel.Worksheet HojaExcel = default(Excel.Worksheet);

            // Iniciamos una instancia a Excel, y Hacemos visibles para ver como se va creando el reporte, 
            // podemos hacerlo visible al final si se desea.
            Mi_Excel = new Excel.Application();
 
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
            HojaExcel.Range["A2:E2"].Value = "REPORTE DE DOCUMENTOS  - FACTURAS Y BOLETAS";
            //HojaExcel.Range["A2:E2"].Font.Italic = true;
            HojaExcel.Range["A2:E2"].Font.Size = 12;

            Excel.Range

            objCelda = HojaExcel.Range["A3", Type.Missing];
            objCelda.Value = "CODIGO";

            objCelda = HojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "VENDEDOR";

            objCelda = HojaExcel.Range["C3", Type.Missing];
            objCelda.Value = "FECHA DE EMISION";
            objCelda.ToString();


            objCelda = HojaExcel.Range["D3", Type.Missing];
            objCelda.Value = "FECHA DE VENCIMIENTO";

            objCelda = HojaExcel.Range["E3", Type.Missing];
            objCelda.Value = "RUC";

            objCelda = HojaExcel.Range["F3", Type.Missing];
            objCelda.Value = "RAZON SOCIAL";

            objCelda = HojaExcel.Range["G3", Type.Missing];
            objCelda.Value = "DOC";

            objCelda = HojaExcel.Range["H3", Type.Missing];
            objCelda.Value = "NUMERO";

            objCelda = HojaExcel.Range["I3", Type.Missing];
            objCelda.Value = "MONEDA";

            objCelda = HojaExcel.Range["J3", Type.Missing];
            objCelda.Value = "TOTAL";

            objCelda = HojaExcel.Range["K3", Type.Missing];
            objCelda.Value = "IGV";

            objCelda = HojaExcel.Range["L3", Type.Missing];
            objCelda.Value = "FORMA PAG. CODIGO";

            objCelda = HojaExcel.Range["M3", Type.Missing];
            objCelda.Value = "FORMA DE PAGO";

            objCelda.EntireColumn.NumberFormat = "###,###,###.00";
            int i = 5;

            foreach (System.Data.DataRow fila in tab.Rows)
            {
                //TextBox1.Text = fila[1].ToString();

                // Asignar los valores de los registros a las celdas

                HojaExcel.Cells[i, "A"] = "'" + fila[0].ToString();  // CODIGO DE VENDEDOR
                HojaExcel.Cells[i, "B"] = "'" + fila[1].ToString();  // VENDEDOR
                HojaExcel.Cells[i, "C"] = Convert.ToDateTime(fila[2].ToString());  // FECHA DE EMISION
                HojaExcel.Cells[i, "D"] = Convert.ToDateTime(fila[3].ToString());  // FECHA DE VENCIMIENTO
                HojaExcel.Cells[i, "E"] = "'" + fila[4].ToString();  // RUC
                HojaExcel.Cells[i, "F"] = "'" + fila[5].ToString();  // RAZON SOCIAL
                HojaExcel.Cells[i, "G"] = "'" + fila[6].ToString();  // DOC
                HojaExcel.Cells[i, "H"] = "'" + fila[7].ToString();  // NUMERO
                HojaExcel.Cells[i, "I"] = "'" + fila[8].ToString();  // MONEDA
                HojaExcel.Cells[i, "J"] = fila[9].ToString();  // TOTAL
                HojaExcel.Cells[i, "K"] = fila[10].ToString();  // IGV
                HojaExcel.Cells[i, "L"] = "'" + fila[11].ToString();  // FORMA DE PAGO CODIGO
                HojaExcel.Cells[i, "M"] = "'" + fila[12].ToString();  // FORMA DE PAGO


                // HojaExcel.Cells[i, "C"] = "'"+Convert.ToString((fila[2].ToString()));  // CODIGO 

                // Avanzamos una fila
                i++;
            }

            Mi_Excel.Visible = true; 

            // Seleccionar todo el bloque desde A1 hasta D #de filas.
            //Excel.Range Rango = HojaExcel.Range["A3:E" + (i - 1).ToString()];

            // Selecionado todo el rango especificado
            //Rango.Select();

            // Ajustamos el ancho de las columnas al ancho máximo del
            // contenido de sus celdas
            //Rango.Columns.AutoFit();

            // Asignar filtro por columna
            //Rango.AutoFilter(1);


        }*/
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

       
        protected void grdClientesCotiz_SelectedIndexChanged(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "clientecotizdet");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("cotizacioncliente.aspx?datos1=" + this.grdClientesCotiz.Rows[grdClientesCotiz.SelectedIndex].Cells[1].Text + "&datos2=" + this.grdClientesCotiz.Rows[grdClientesCotiz.SelectedIndex].Cells[3].Text);

                /*Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() 
                    + "&datos2=" + Label2.Text.ToString()
                    + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text 
                    + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text 
                    + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);*/
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - clientecotizdet');</script>");
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            // Creamos el archivo
            String Nombre = "ResporteSicoNet"
                + Convert.ToString(DateTime.Now.Day)
                + Convert.ToString(DateTime.Now.Month)
                + Convert.ToString(DateTime.Now.Year)
                + Convert.ToString(DateTime.Now.Hour)
                + Convert.ToString(DateTime.Now.Minute)
                + Convert.ToString(DateTime.Now.Second) + ".xls";

            String RutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\" + Nombre;

            String RutadeArchivo = @RutaArchivo;

            // FacturaListadoExcel();
            //ExportDataTableToExcel("sico"+ Convert.ToString(DateTime.Now) + ".xls", tab = FacturaListadoNego.FacturaListadoConsultarDT(ddlEmp.Text, ddlSerie.Text, txtFei.Text, txtFef.Text));
            //Response.WriteFile(Server.MapPath("sico"+ Convert.ToString(DateTime.Now) + ".xls"));
            ExcelLibrary.DataSetHelper.CreateWorkbook(RutaArchivo  , FacturaListadoNego.FacturaListadoConsultarDS(Convert.ToDateTime(txtFei.Text), Convert.ToDateTime(txtFef.Text), ddlEmp.Text, "0"));
            //Response.WriteFile(Server.MapPath("/reporte.xls"));
            //Response.TransmitFile(Server.MapPath("/reporte.xls"));
            Response.Redirect("/" + Nombre);
            //Exportar_Excel();
            // CrearExcel();
        }


       public static void ExportDataTableToExcel(string fileName, DataTable datatable)
        {
            String style = @"<style> .textmode { mso-number-format:\@; } </script> ";
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", fileName));
            HttpContext.Current.Response.ContentType = "application/ms-excel";

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    // Crear una tabla que va a contener unos datos.
                    Table table = new Table();
                    TableRow row = new TableRow();

                    for (int j = 0; j < datatable.Columns.Count; j++)
                    {
                        TableHeaderCell headerCell = new TableHeaderCell();
                        headerCell.Text = "-"+Convert.ToString(datatable.Columns[j].ColumnName);
                        row.Cells.Add(headerCell);
                    }
                    // Adiciona el encabezado
                    table.Rows.Add(row);

                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        row = new TableRow();
                        // for (int j = 0; j < datatable.Columns.Count; j++)
                        // {
                        TableCell cell = new TableCell();

                        cell.Text = "'" + Convert.ToString(datatable.Rows[i][4].ToString());
                        cell.Text = cell.Text.Trim();
                    
                        cell.ToString();
                        row.Cells.Add(cell);
                        //}
                        // Adiciona las filas a la tabla
                        table.Rows.Add(row);
                    }

                    //  render the table into the htmlwriter
                    table.RenderControl(htw);

                    ///Type text
                    HttpContext.Current.Response.Write(style);
                    //  render the htmlwriter into the response
                    HttpContext.Current.Response.Write(sw.ToString());
                    HttpContext.Current.Response.End();
                }
            }
        }


        protected void Exportar_Excel()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter sw = new System.IO.StringWriter(sb);
            System.Web.UI.HtmlTextWriter htw = new System.Web.UI.HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            grdClientesCotiz.DataSource = FacturaListadoNego.FacturaListadoConsultarDT(Convert.ToDateTime(txtFei.Text), Convert.ToDateTime(txtFef.Text), ddlEmp.Text, "0");
            grdClientesCotiz.DataBind();

            grdClientesCotiz.EnableViewState = true;

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = true;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(grdClientesCotiz);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=DATA.xls");
            Response.Charset = "UTF-8";
            // Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }
        /*
                private  void DocumentosaXls()
                {
                    Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                    if (xlApp == null)
                    {
                        //MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }


                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    xlWorkSheet.Cells[1, 1] = "ID";
                    xlWorkSheet.Cells[1, 2] = "Name";
                    xlWorkSheet.Cells[2, 1] = "01";
                    xlWorkSheet.Cells[2, 2] = "One";
                    xlWorkSheet.Cells[3, 1] = "2";
                    xlWorkSheet.Cells[3, 2] = "Two";



                    xlWorkBook.SaveAs("x.xlsx", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);



                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);


                    //MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
                }*/
    }
}