using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class ConsultasDDatos
    {
        SqlConnection cnx;
        ConsultasDEntidad muEntidad = new ConsultasDEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ConsultasDDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public ConsultasDEntidad ProductoDatos(String Codigo)
        {
            try
            {
                SqlDataReader dtr;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ProductoListar";
                cmd.Parameters.Add(new SqlParameter("@cod", Codigo));


                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    muEntidad.tbadescri = dtr[0].ToString();

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
