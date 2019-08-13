using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class TEstadoDetalleDatos
    {
        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public TEstadoDetalleDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable TomaIEstadosDetalleDT( int nInventario)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_tomaInventarioDetalleListar";
                cmd.Parameters.Add(new SqlParameter("@inv", nInventario));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "TEstados");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["TEstados"]);
        }
        public DataSet TomaIEstadosDetalleDS(int nInventario)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_tomaInventarioDetalleListar";
                cmd.Parameters.Add(new SqlParameter("@inv", nInventario));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "TEstados");
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
