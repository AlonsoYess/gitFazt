using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class CompraDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public CompraDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable CompraCotizListar(string cotiz, string orden)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ComprasVsCotizaciones";
                cmd.Parameters.Add(new SqlParameter("@cot", cotiz));
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

        public CompraEntidad CompraConsultar(string cotiz, string orden)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ComprasVsCotizaciones";
                cmd.Parameters.Add(new SqlParameter("@cot", cotiz));
                cmd.Parameters.Add(new SqlParameter("@ord", orden));
                cmd.Parameters["@cot"].Value = cotiz;
                cmd.Parameters["@ord"].Value = orden;

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                dtr = cmd.ExecuteReader();
                
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    muEntidad.tbCodigo      = dtr.GetString(0);
                    muEntidad.tbDescripcion = Convert.ToString(dtr[1]);
                    muEntidad.tbUnidad      = Convert.ToString(dtr[2]);
                    muEntidad.tbCostoSoles  = Convert.ToString(dtr[3]);
                    muEntidad.tbVentaSoles  = Convert.ToString(dtr[4]);
                    muEntidad.tbPorcentaje  = Convert.ToString(dtr[5]);
                }
                cnx.Close();
                cmd.Parameters.Clear();
                return muEntidad;
            }
            catch (SqlException)
            {
                throw new Exception();
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
        }
    }

}