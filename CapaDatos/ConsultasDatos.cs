using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class ConsultasDatos
    {
        SqlConnection cnx;
        ConsultasEntidad muEntidad = new ConsultasEntidad();
        invConteoEntidad muConteo = new invConteoEntidad();




        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ConsultasDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public ConsultasEntidad AlmacenCodigo()
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_InventarioCod";


                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    muEntidad.tbValor = Convert.ToInt16(dtr[0].ToString());

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

        public invConteoEntidad invConteo(int Numero, String Usuario, String Conteo, String Codigo, decimal Cantidad, DateTime Fecha, DateTime Hora, int Ubicacion)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_TomaInventarioConteoVerificar";
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

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    muConteo.tbcontador = Convert.ToInt16(dtr[0].ToString());

                }
                cnx.Close();
                cmd.Parameters.Clear();
                return muConteo;
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
