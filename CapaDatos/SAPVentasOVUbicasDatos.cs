using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class SAPVentasOVUbicasDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public SAPVentasOVUbicasDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataSet SAPVentasOVUbicasDS( string ca)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "pa_SAP_OrdenVentaStock";
                cmd.Parameters.Add(new SqlParameter("@ord", ca));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_SAP_OrdenVentaStock");
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

        public DataTable SAPVentasOVUbicasDT(string ca)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_SAP_OrdenVentaStock";
                cmd.Parameters.Add(new SqlParameter("@ord", ca));


                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_SAP_OrdenVentaStock");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           return (dts.Tables["pa_SAP_OrdenVentaStock"]);
            //return (dts);
        }
    }

}