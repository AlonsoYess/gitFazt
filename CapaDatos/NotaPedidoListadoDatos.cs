using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class NotaPedidoListadoDatos
    {
        SqlConnection cnx;
        NotaPedidoListadoEntidad muEntidad = new NotaPedidoListadoEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public NotaPedidoListadoDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }


        public DataTable NotaPedidoListadoConsultarDT(DateTime  feci, DateTime  fecf, string alma, string nota)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_NotaPedidoListado";
                cmd.Parameters.Add(new SqlParameter("@f1", feci));
                cmd.Parameters.Add(new SqlParameter("@f2", fecf));
                cmd.Parameters.Add(new SqlParameter("@al", alma));
                cmd.Parameters.Add(new SqlParameter("@np", nota));
              

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paNotaPedidoListado");
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
            return (dts.Tables["paNotaPedidoListado"] );

        }

        public DataSet NotaPedidoListadoConsultarDS(DateTime  feci, DateTime  fecf, string alma, string nota)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_NotaPedidoListado";
                cmd.Parameters.Add(new SqlParameter("@f1", feci));
                cmd.Parameters.Add(new SqlParameter("@f2", fecf));
                cmd.Parameters.Add(new SqlParameter("@al", alma));
                cmd.Parameters.Add(new SqlParameter("@np", nota));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paNotaPedidoListado");
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