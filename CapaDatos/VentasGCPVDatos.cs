using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class VentasGCPVDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public VentasGCPVDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable VentasGCPVListarCDatos(string punto,DateTime fecha1, DateTime  fecha2)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_VentasMensualesGCPuntoVendedor";
                cmd.CommandTimeout = 0;
                cmd.Parameters.Add(new SqlParameter("@pv", punto));
                cmd.Parameters.Add(new SqlParameter("@f1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@f2", fecha2));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "VentaGCPV");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["VentaGCPV"]);
        }

    }
}
