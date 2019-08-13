using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class VentasGeneralesDetalleDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public VentasGeneralesDetalleDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataSet VentasGeneralesDetalleConsultarDS(DateTime f1, DateTime f2, string ca)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "pa_VentasDetalladaTotalparaExcel";
                cmd.Parameters.Add(new SqlParameter("@f1", f1));
                cmd.Parameters.Add(new SqlParameter("@f2", f2));
                cmd.Parameters.Add(new SqlParameter("@ca", ca));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paVentasDetalladaTotalparaExcel");
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

        public DataTable VentasGeneralesDetalleConsultarDT(DateTime f1, DateTime f2, string ca)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_VentasDetalladaTotalparaExcel";
                cmd.Parameters.Add(new SqlParameter("@f1", f1));
                cmd.Parameters.Add(new SqlParameter("@f2", f2));
                cmd.Parameters.Add(new SqlParameter("@ca", ca));


                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paVentasDetalladaTotalparaExcel");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           return (dts.Tables["paVentasDetalladaTotalparaExcel"]);
            //return (dts);
        }
    }

}