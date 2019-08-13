using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SAPVentasClientesDatos
    {

        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPVentasClientesDatos()
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

        public DataSet VentaClienteDS(DateTime fechaInicial, DateTime fechaFinal)
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_VENTACLIENTES";

                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();

                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value = fechaInicial;
                cmd.Parameters.Add(f1);

                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = fechaFinal; ;
                cmd.Parameters.Add(f2);



                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dts, "ACSA_VEN_RPT_VENTACLIENTES");

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



        public DataTable VentaClienteDT(DateTime fechaInicial, DateTime fechaFinal)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_VENTACLIENTES";

                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();

                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value = fechaInicial;
                cmd.Parameters.Add(f1);

                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = fechaFinal; ;
                cmd.Parameters.Add(f2);

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


        public DataTable ClienteCartera (DateTime fechaInicial, DateTime fechaFinal)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_CARTERACLIENTES";

                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();

                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value = fechaInicial;
                cmd.Parameters.Add(f1);

                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = fechaFinal; ;
                cmd.Parameters.Add(f2);

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
