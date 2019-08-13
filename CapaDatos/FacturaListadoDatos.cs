using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class FacturaListadoDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public FacturaListadoDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }


        public DataTable FacturaListadoConsultarDT(DateTime fei, DateTime fev, string emp, string pun)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_FacturaListado2";
                
                cmd.Parameters.Add(new SqlParameter("@fechaInicial", fei));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", fev));
                cmd.Parameters.Add(new SqlParameter("@emp", emp));
                //cmd.Parameters.Add(new SqlParameter("@sed", sed));
                cmd.Parameters.Add(new SqlParameter("@puntoSerie", pun));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paFacturaListado");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

            //return (dts.Tables["paFacturaListado"]);
            return (dts.Tables["paFacturaListado"] );

        }

        public DataSet FacturaListadoConsultarDS(DateTime fei, DateTime fev, string emp, string pun)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_FacturaListado2";
                cmd.Parameters.Add(new SqlParameter("@fechaInicial", fei));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", fev));
                cmd.Parameters.Add(new SqlParameter("@emp", emp));
                //cmd.Parameters.Add(new SqlParameter("@sed", sed));
                cmd.Parameters.Add(new SqlParameter("@puntoSerie", pun));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paFacturaListado");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           

            //return (dts.Tables["paFacturaListado"]);
            return (dts);

        }
    }

}