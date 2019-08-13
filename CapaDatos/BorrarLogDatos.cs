using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class BorrarLogDatos
    {
        SqlConnection cnx;
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public BorrarLogDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public int BorrarLog()
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "[180.100.0.6].[PROMATISACORP].dbo.PA_REDUCIRBASEDEDATOS";
                cnx.Open();
                int valor = cmd.ExecuteNonQuery();
                cnx.Close();
                return valor;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
