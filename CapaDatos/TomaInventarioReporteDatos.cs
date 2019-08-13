using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class TomaInventarioReporteDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public TomaInventarioReporteDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataSet TomaInventarioReporteDS(string NroInventario)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioReporteGeneral";
                cmd.Parameters.Add(new SqlParameter("@inv", NroInventario));


                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paTomaInventarioReporteGeneral");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

            //return (dts.Tables["VentasMensualesGCDetalladoxCanal"]);
            return (dts);
        }

        public DataTable TomaInventarioReporteDT(string NroInventario)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioReporteGeneral";
                cmd.Parameters.Add(new SqlParameter("@inv", NroInventario));



                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paTomaInventarioReporteGeneral");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           return (dts.Tables["paTomaInventarioReporteGeneral"]);
            //return (dts);
        }
    }

}