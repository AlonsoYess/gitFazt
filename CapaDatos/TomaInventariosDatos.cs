using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class TomaInventariosDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public TomaInventariosDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public int TomaInventariosInsertar(int Numero, DateTime Fecha, String Usuario, String Responsable, DateTime FechaInicio, DateTime FechaFinal, String Almacen, String Estado, String Observaciones)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioInsertar";
               
                cmd.Parameters.Add(new SqlParameter("@nti", Numero));
                cmd.Parameters.Add(new SqlParameter("@fec", Fecha));
                cmd.Parameters.Add(new SqlParameter("@usu", Usuario));
                cmd.Parameters.Add(new SqlParameter("@res", Responsable));
                cmd.Parameters.Add(new SqlParameter("@fei", FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fef", FechaFinal));
                cmd.Parameters.Add(new SqlParameter("@alm", Almacen));
                cmd.Parameters.Add(new SqlParameter("@est", Estado));
                cmd.Parameters.Add(new SqlParameter("@obs", Observaciones));

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                
            }
            return (1);
        }
   

    }
}
