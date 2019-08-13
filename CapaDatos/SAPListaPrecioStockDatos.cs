using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SAPListaPrecioStockDatos
    {

        HanaConnection cnx;
        
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPListaPrecioStockDatos()
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
        

        public DataTable SapListaPrecioDetalleDT(string Lista)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VTAS_WEB_LISTA_PRECIO_DETALLES";

                HanaParameter List = new HanaParameter();

                // Parametro Canal.
                List = cmd.CreateParameter();
                List.HanaDbType = HanaDbType.VarChar;
                List.Direction = ParameterDirection.Input;
                List.Value = Lista;
                cmd.Parameters.Add(List);


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

        public DataTable SapListaPrecioDT()
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VTAS_WEB_LISTA_PRECIO";

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
