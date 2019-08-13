using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class ClienteDetalleDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ClienteDetalleDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable ClienteDetalleConsultarCAB(DateTime fechaInicial,DateTime fechaFinal, string codigoCliente, string codigoEmpresa)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "PA_VentaDetalladaXClienteCab";
                cmd.Parameters.Add(new SqlParameter("@fechaInicial", fechaInicial));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", fechaFinal));
                cmd.Parameters.Add(new SqlParameter("@cliente", codigoCliente));
                cmd.Parameters.Add(new SqlParameter("@codigoEmpresa", codigoEmpresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ClienteCabecera");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["ClienteCabecera"]);

        }
    }

}