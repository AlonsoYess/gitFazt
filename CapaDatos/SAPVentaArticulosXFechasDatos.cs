using Sap.Data.Hana;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class SAPVentaArticulosXFechasDatos
    {
        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPVentaArticulosXFechasDatos()
        {
            try
            {
                cnx = new HanaConnection(MiConexi.GetConex());
            }
            catch (HanaException)
            {

                throw new Exception();
            }
        }


        public DataSet VentasGeneralesDetalladaSAPDS(DateTime FechaInicial, DateTime FechaFinal)
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_VENTAXARTICULO";

                HanaParameter fechaInicio = new HanaParameter();
                HanaParameter fechaFin = new HanaParameter();

                // Parametro Fecha 1.
                fechaInicio = cmd.CreateParameter();
                fechaInicio.HanaDbType = HanaDbType.Date;
                fechaInicio.Direction = ParameterDirection.Input;
                fechaInicio.Value = FechaInicial;
                cmd.Parameters.Add(fechaInicio);

                // Parametro Fecha 2.
                fechaFin = cmd.CreateParameter();
                fechaFin.HanaDbType = HanaDbType.Date;
                fechaFin.Direction = ParameterDirection.Input;
                fechaFin.Value = FechaFinal;
                cmd.Parameters.Add(fechaFin);

                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dts, "ACSA_VEN_RPT_VENTAXARTICULO");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

            //return (dts.Tables["VentasMensualesGCDetalladoxCanal"]);
            return (dts);
            /*

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
             }*/
        }

        public DataTable VentasGeneralesDetalladaSAPDT(DateTime FechaInicial, DateTime FechaFinal)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_VENTAXARTICULO";

                HanaParameter fechaInicial = new HanaParameter();
                HanaParameter fechaFinal = new HanaParameter();

                // Parametro Fecha Inicial.
                fechaInicial = cmd.CreateParameter();
                fechaInicial.HanaDbType = HanaDbType.Date;
                fechaInicial.Direction = ParameterDirection.Input;
                fechaInicial.Value = FechaInicial;
                cmd.Parameters.Add(fechaInicial);

                // Parametro Fecha Final.
                fechaFinal = cmd.CreateParameter();
                fechaFinal.HanaDbType = HanaDbType.Date;
                fechaFinal.Direction = ParameterDirection.Input;
                fechaFinal.Value = FechaFinal; 
                cmd.Parameters.Add(fechaFinal);

                cmd.ExecuteNonQuery();
                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dt);
                return dt;
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
