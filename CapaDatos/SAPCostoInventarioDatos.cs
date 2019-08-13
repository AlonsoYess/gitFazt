using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SapCostosInventarioDatos
    {

        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SapCostosInventarioDatos()
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

        public DataSet CostoInvetarioDS(DateTime FechaInicio, DateTime FechaFin, string CodCliente, string Canal)
        {

            DataSet dts = new DataSet();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_CON_RPT_INVENTARIO";

                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();
                HanaParameter cc = new HanaParameter();
                HanaParameter c = new HanaParameter();
                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value = FechaInicio;
                cmd.Parameters.Add(f1);

                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = FechaFin; ;
                cmd.Parameters.Add(f2);

                // Parametro Cliente.
                cc = cmd.CreateParameter();
                cc.HanaDbType = HanaDbType.VarChar;
                cc.Direction = ParameterDirection.Input;
                cc.Value = CodCliente;
                cmd.Parameters.Add(cc);

                // Parametro Canal.
                c = cmd.CreateParameter();
                c.HanaDbType = HanaDbType.VarChar;
                c.Direction = ParameterDirection.Input;
                c.Value = Canal;
                cmd.Parameters.Add(c);


                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dts, "ACSA_CON_RPT_INVENTARIO");

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

        public DataTable CostoInvetarioDSDT(DateTime FechaInicio, DateTime FechaFin, string CodCliente, string Canal)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_CON_RPT_INVENTARIO";

                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();
                HanaParameter cc = new HanaParameter();
                HanaParameter c = new HanaParameter();

                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value = FechaInicio;
                cmd.Parameters.Add(f1);

                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = FechaFin; ;
                cmd.Parameters.Add(f2);

                // Parametro Cliente.
                cc = cmd.CreateParameter();
                cc.HanaDbType = HanaDbType.VarChar;
                cc.Direction = ParameterDirection.Input;
                cc.Value = CodCliente;
                cmd.Parameters.Add(cc);

                // Parametro Canal.
                c = cmd.CreateParameter();
                c.HanaDbType = HanaDbType.VarChar;
                c.Direction = ParameterDirection.Input;
                c.Value = Canal;
                cmd.Parameters.Add(c);


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
