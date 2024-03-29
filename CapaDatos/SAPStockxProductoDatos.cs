﻿using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;



namespace CapaDatos
{
    public class SAPStockxProductoDatos
    {

        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPStockxProductoDatos()
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

        public DataTable VentasSTOCKSAPConsultar(String CodigoStock )
        {           

            DataTable dt = new DataTable();
             try
             {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_LOG_WEB_Stock";
                HanaParameter param = new HanaParameter();
                param = cmd.CreateParameter();
                param.HanaDbType = HanaDbType.NVarChar;
                param.Direction = ParameterDirection.Input;
                param.Value = CodigoStock;
                cmd.Parameters.Add(param);
    
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
