using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class TomaInventariosAutorizarDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public TomaInventariosAutorizarDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public int TomaInventariosActualizar(int Numero, String Usuario,  DateTime FechaInicio, DateTime FechaFinal, String EstadoA, String EstadoN, String ConteoN)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioAutorizar";

                cmd.Parameters.Add(new SqlParameter("@nti", Numero));
                cmd.Parameters.Add(new SqlParameter("@usu", Usuario));
                cmd.Parameters.Add(new SqlParameter("@fec", FechaInicio));
                cmd.Parameters.Add(new SqlParameter("@hor", FechaFinal));
                cmd.Parameters.Add(new SqlParameter("@eac", EstadoA));
                cmd.Parameters.Add(new SqlParameter("@env", EstadoN));
                cmd.Parameters.Add(new SqlParameter("@con", ConteoN));

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
