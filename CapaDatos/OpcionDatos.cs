using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class OpcionDatos
    {
        SqlConnection cnx;
        OpcionEntidad muEntidad = new OpcionEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public OpcionDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public OpcionEntidad OpcionConsultar(string user, string funcion)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_UsuarioAcceso";
                cmd.Parameters.Add(new SqlParameter("@user", user));
                cmd.Parameters.Add(new SqlParameter("@func", funcion));
                cmd.Parameters["@user"].Value = user;
                cmd.Parameters["@func"].Value = funcion;

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
    }

}