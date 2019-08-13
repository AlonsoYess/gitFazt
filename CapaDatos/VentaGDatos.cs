using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class VentaGDatos
    {

        SqlConnection cnx;
        VentaGEntidad dcentidad = new VentaGEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public VentaGDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable VentasGConsultar(String fechaI, String fechaF)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "VentaEmpresaGeneral";
                cmd.Parameters.Add(new SqlParameter("@feci", fechaI));
                cmd.Parameters.Add(new SqlParameter("@fecf", fechaF));
                cmd.Parameters["@feci"].Value = fechaI;
                cmd.Parameters["@fecf"].Value = fechaF;
          
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                return ds;

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
