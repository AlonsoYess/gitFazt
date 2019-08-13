using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class CompraNPDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public CompraNPDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }


        public DataTable CompraNPListar(string empre, string notap, string orden)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_OrdeCxNotaPedido";
                cmd.Parameters.Add(new SqlParameter("@emp", empre));
                cmd.Parameters.Add(new SqlParameter("@not", notap));
                cmd.Parameters.Add(new SqlParameter("@ord", orden));
     
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "CompraCotiz");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["CompraCotiz"]);
        }

       
        }
    

}