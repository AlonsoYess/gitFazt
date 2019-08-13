using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SAPVentasGCDatos
    {

        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPVentasGCDatos()
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

        public DataTable VentasGCSAPConsultar(DateTime fecha1, DateTime fecha2, string Canal)
        {           

            DataTable dt = new DataTable();
             try
             {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VTAS_WEB_VentaGC";
                
                HanaParameter f1 = new HanaParameter();
                HanaParameter f2 = new HanaParameter();
                HanaParameter pc = new HanaParameter();
                
                // Parametro Fecha 1.
                f1 = cmd.CreateParameter();
                f1.HanaDbType = HanaDbType.Date;
                f1.Direction = ParameterDirection.Input;
                f1.Value =fecha1;
                cmd.Parameters.Add(f1);
                
                // Parametro Fecha 2.
                f2 = cmd.CreateParameter();
                f2.HanaDbType = HanaDbType.Date;
                f2.Direction = ParameterDirection.Input;
                f2.Value = fecha2; ;
                cmd.Parameters.Add(f2);
               
                // Parametro Canal.
                pc = cmd.CreateParameter();
                pc.HanaDbType = HanaDbType.VarChar;
                pc.Direction = ParameterDirection.Input;
                pc.Value = Canal;
                cmd.Parameters.Add(pc);


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
