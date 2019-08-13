using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class TomaInventariosRegistroConteoDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public TomaInventariosRegistroConteoDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public int TomaInventariosRegistrarConteo(int Numero, String Usuario,  String Conteo, String Codigo, decimal Cantidad, DateTime Fecha,DateTime Hora, int Ubicacion)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioConteoGuardar";

                cmd.Parameters.Add(new SqlParameter("@inv", Numero));
                cmd.Parameters.Add(new SqlParameter("@usu", Usuario));
                cmd.Parameters.Add(new SqlParameter("@nct", Conteo));
                cmd.Parameters.Add(new SqlParameter("@cod", Codigo));
                cmd.Parameters.Add(new SqlParameter("@qtd", Cantidad));
                cmd.Parameters.Add(new SqlParameter("@fec", Fecha));
                cmd.Parameters.Add(new SqlParameter("@hor", Hora));
                cmd.Parameters.Add(new SqlParameter("@ubi", Ubicacion));

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            catch (SqlException ex)
            {
                //throw new Exception(Convert.ToString (ex.Number));

                if (ex.Number ==2627)
                { return (ex.Number); }
                


            }
            finally
            {
                cmd.Parameters.Clear();
                
            }
            return (1);
        }

        public int TomaInventariosRegistrarConteoUpdate(int Numero, String Usuario, String Conteo, String Codigo, decimal Cantidad, DateTime Fecha, DateTime Hora, int Ubicacion)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioConteoUpdate";

                cmd.Parameters.Add(new SqlParameter("@inv", Numero));
                cmd.Parameters.Add(new SqlParameter("@usu", Usuario));
                cmd.Parameters.Add(new SqlParameter("@nct", Conteo));
                cmd.Parameters.Add(new SqlParameter("@cod", Codigo));
                cmd.Parameters.Add(new SqlParameter("@qtd", Cantidad));
                cmd.Parameters.Add(new SqlParameter("@fec", Fecha));
                cmd.Parameters.Add(new SqlParameter("@hor", Hora));
                cmd.Parameters.Add(new SqlParameter("@ubi", Ubicacion));

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                cmd.ExecuteNonQuery();
                cnx.Close();

            }
            catch (SqlException ex)
            {
                //throw new Exception(Convert.ToString (ex.Number));

                if (ex.Number == 2627)
                { return (ex.Number); }



            }
            finally
            {
                cmd.Parameters.Clear();

            }
            return (1);
        }


    }
}
