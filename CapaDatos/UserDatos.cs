using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class UserDatos
    {
        SqlConnection cnx;
        UserEntidad muEntidad = new UserEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public UserDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public UserEntidad UserConsultar(string user, string clave)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_UserConsultar";
                cmd.Parameters.Add(new SqlParameter("@usr", user));
                cmd.Parameters.Add(new SqlParameter("@key", clave));
                cmd.Parameters["@usr"].Value = user;
                cmd.Parameters["@key"].Value = clave;

                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                dtr = cmd.ExecuteReader();
                
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    muEntidad.tbusuario = dtr.GetString(0);
                    muEntidad.tbclave = Convert.ToString(dtr[1]);
                    muEntidad.tbnombre = Convert.ToString(dtr[2]);
                    muEntidad.tbapellido = Convert.ToString(dtr[3]);
                    muEntidad.tbobserva = Convert.ToString(dtr[4]);
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