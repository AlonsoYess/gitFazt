using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class DocDatos
    {
        SqlConnection cnx;
        DocEntidad dcentidad = new DocEntidad();
        MontoLetrasEntidad montoentidad = new MontoLetrasEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        public DocDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
        public DataTable DocConsultar(string emp,string tipodoc,string numfac)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_FacturaImprimir";
                cmd.Parameters.Add(new SqlParameter("@emp", emp));
                cmd.Parameters.Add(new SqlParameter("@doc", tipodoc));
                cmd.Parameters.Add(new SqlParameter("@nro", numfac));
                cmd.Parameters["@emp"].Value = emp;
                cmd.Parameters["@doc"].Value = tipodoc;
                cmd.Parameters["@nro"].Value = numfac;
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

        public DataTable MontoLetras(string emp, string tipodoc, string numfac)
        {
            try
            {
                cmd2.Connection = cnx;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "pa_MontoLetras";
                cmd2.Parameters.Add(new SqlParameter("@emp", emp));
                cmd2.Parameters.Add(new SqlParameter("@doc", tipodoc));
                cmd2.Parameters.Add(new SqlParameter("@nro", numfac));
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
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
