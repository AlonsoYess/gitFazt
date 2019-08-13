using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class ComprasDocsDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ComprasDocsDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable ComprasDocsDT(DateTime  fecha1, DateTime  fecha2, string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ComprasFacturaReporte";
                cmd.Parameters.Add(new SqlParameter("@f1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@f2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "CompraDocs");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["CompraDocs"]);
        }
        public DataSet ComprasDocsDS(DateTime fecha1, DateTime  fecha2, string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ComprasFacturaReporte";
                cmd.Parameters.Add(new SqlParameter("@f1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@f2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "CompraDocs");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            //return (dts.Tables["LogisticaStockMin"]);
            return (dts);
        }

    }
}
