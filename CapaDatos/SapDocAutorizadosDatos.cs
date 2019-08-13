using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SapDocAutorizadosDatos
    {
        HanaConnection cnx;
        SapDocAutorizadosEntidad docAutorizadosEntidad = new SapDocAutorizadosEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        HanaCommand cmd = new HanaCommand();

        public SapDocAutorizadosDatos()
        {
            try
            {
                cnx = new HanaConnection(MiConexi.GetConex());
            }
            catch
            {
                throw new Exception();
            }
        }

        public DataTable DocumentosAutorizadosConsultar(DateTime fechaInicial,DateTime fechaFinal, string numSAP, string codCliente, string codAlmacen)
        {
            DataTable dt = new DataTable();

            try
            {
                cnx.Open();
                HanaCommand cmd = new HanaCommand("", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_VEN_RPT_FLUJODEOVS";
                
                HanaParameter FechaInicio = new HanaParameter();
                HanaParameter FechaFin = new HanaParameter();
                HanaParameter NumSAP = new HanaParameter();
                HanaParameter CodCliente = new HanaParameter();
                HanaParameter CodAlmacen = new HanaParameter();
                // Parametro Fecha 1.
                FechaInicio = cmd.CreateParameter();
                FechaInicio.HanaDbType = HanaDbType.Date;
                FechaInicio.Direction = ParameterDirection.Input;
                FechaInicio.Value = fechaInicial;
                cmd.Parameters.Add(FechaInicio);

                // Parametro Fecha 2.
                FechaFin = cmd.CreateParameter();
                FechaFin.HanaDbType = HanaDbType.Date;
                FechaFin.Direction = ParameterDirection.Input;
                FechaFin.Value = fechaFinal; ;
                cmd.Parameters.Add(FechaFin);

                // Parametro Numero de Orden de Venta.
                NumSAP = cmd.CreateParameter();
                NumSAP.HanaDbType = HanaDbType.VarChar;
                NumSAP.Direction = ParameterDirection.Input;
                NumSAP.Value = numSAP;
                cmd.Parameters.Add(NumSAP);

                // Parametro Cliente.
                CodCliente = cmd.CreateParameter();
                CodCliente.HanaDbType = HanaDbType.VarChar;
                CodCliente.Direction = ParameterDirection.Input;
                CodCliente.Value = codCliente;
                cmd.Parameters.Add(CodCliente);

                // Parametro Almacen.
                CodAlmacen = cmd.CreateParameter();
                CodAlmacen.HanaDbType = HanaDbType.VarChar;
                CodAlmacen.Direction = ParameterDirection.Input;
                CodAlmacen.Value = codAlmacen;
                cmd.Parameters.Add(CodAlmacen);

                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dt);
                return dt;
            }
            catch
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
