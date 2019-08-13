using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SapStockXMarcaDatos
    {

        HanaConnection cnx;
        SAPListaPrecioStockEntidad dcentidad = new SAPListaPrecioStockEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SapStockXMarcaDatos()
        {
            try
            {
                cnx = new HanaConnection(MiConexi.GetConex());
            }
            catch (SqlException)
            {

                throw new Exception();
            }
        }

        public DataSet VentasGeneralesDetalladaSAPDS(string Marca)
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VTAS_WEB_LISTAPRECIOSTOCK";

                HanaParameter mar = new HanaParameter();


                // Parametro Canal.
                mar = cmd.CreateParameter();
                mar.HanaDbType = HanaDbType.VarChar;
                mar.Direction = ParameterDirection.Input;
                mar.Value = Marca;
                cmd.Parameters.Add(mar);


                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dts, "ACSA_VTAS_WEB_LISTAPRECIOSTOCK");

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

        public DataTable VentasGeneralesDetalladaSAPDT(string Marca)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VTAS_WEB_LISTAPRECIOSTOCK";

                HanaParameter mar = new HanaParameter();

                // Parametro Canal.
                mar = cmd.CreateParameter();
                mar.HanaDbType = HanaDbType.VarChar;
                mar.Direction = ParameterDirection.Input;
                mar.Value = Marca;
                cmd.Parameters.Add(mar);


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
