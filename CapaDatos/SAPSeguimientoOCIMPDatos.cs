using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sap.Data.Hana;

namespace CapaDatos
{
    public class SAPSeguimientoOCIMPDatos
    {

        HanaConnection cnx;
        SAPStockxProductoEntidad dcentidad = new SAPStockxProductoEntidad();
        ConexionSAP MiConexi = new ConexionSAP();
        //HanaConnection cmd = new HanaConnection("Server =192.168.10.199:30015;User Id=SYSTEM;Password=Pr0m4t1s42017;DataBaseName=SBO_ACSA_PROD");
        HanaCommand cmd = new HanaCommand();

        public SAPSeguimientoOCIMPDatos()
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

        public DataSet SAPSeguimientoOCIMPDS(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Reserva, string Entrada, string Precio, string Transferencia)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_LOG_RPT_SEGUIMIENTO_OC_IMP";

                HanaParameter fechaI = new HanaParameter();
                HanaParameter fechaFin = new HanaParameter();
                HanaParameter codPro = new HanaParameter();
                HanaParameter nomPro = new HanaParameter();
                HanaParameter Soli = new HanaParameter();
                HanaParameter Ord = new HanaParameter();
                HanaParameter reser = new HanaParameter();
                HanaParameter entrada = new HanaParameter();
                HanaParameter precio = new HanaParameter();
                HanaParameter transferencia = new HanaParameter();
                // Parametro Fecha 1.
                fechaI = cmd.CreateParameter();
                fechaI.HanaDbType = HanaDbType.Date;
                fechaI.Direction = ParameterDirection.Input;
                fechaI.Value = FechaInicio;
                cmd.Parameters.Add(fechaI);

                // Parametro Fecha 2.
                fechaFin = cmd.CreateParameter();
                fechaFin.HanaDbType = HanaDbType.Date;
                fechaFin.Direction = ParameterDirection.Input;
                fechaFin.Value = FechaFin; ;
                cmd.Parameters.Add(fechaFin);


                codPro = cmd.CreateParameter();
                codPro.HanaDbType = HanaDbType.VarChar;
                codPro.Direction = ParameterDirection.Input;
                codPro.Value = CodProveedor;
                cmd.Parameters.Add(codPro);

                nomPro = cmd.CreateParameter();
                nomPro.HanaDbType = HanaDbType.VarChar;
                nomPro.Direction = ParameterDirection.Input;
                nomPro.Value = NomProveedor;
                cmd.Parameters.Add(nomPro);

                Soli = cmd.CreateParameter();
                Soli.HanaDbType = HanaDbType.VarChar;
                Soli.Direction = ParameterDirection.Input;
                Soli.Value = Solicitud;
                cmd.Parameters.Add(Soli);

                Ord = cmd.CreateParameter();
                Ord.HanaDbType = HanaDbType.VarChar;
                Ord.Direction = ParameterDirection.Input;
                Ord.Value = Orden;
                cmd.Parameters.Add(Ord);

                reser = cmd.CreateParameter();
                reser.HanaDbType = HanaDbType.VarChar;
                reser.Direction = ParameterDirection.Input;
                reser.Value = Reserva;
                cmd.Parameters.Add(reser);

                entrada = cmd.CreateParameter();
                entrada.HanaDbType = HanaDbType.VarChar;
                entrada.Direction = ParameterDirection.Input;
                entrada.Value = Entrada;
                cmd.Parameters.Add(entrada);

                precio = cmd.CreateParameter();
                precio.HanaDbType = HanaDbType.VarChar;
                precio.Direction = ParameterDirection.Input;
                precio.Value = Precio;
                cmd.Parameters.Add(precio);

                transferencia = cmd.CreateParameter();
                transferencia.HanaDbType = HanaDbType.VarChar;
                transferencia.Direction = ParameterDirection.Input;
                transferencia.Value = Transferencia;
                cmd.Parameters.Add(transferencia);


                cmd.ExecuteNonQuery();

                HanaDataAdapter ada = new HanaDataAdapter(cmd);
                ada.Fill(dts, "ACSA_LOG_RPT_SEGUIMIENTO_OCIMP");

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

        public DataTable SAPSeguimientoOCIMPDT(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Reserva, string Entrada, string Precio, string Transferencia)
        {

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();

                HanaCommand cmd = new HanaCommand("", cnx);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "SBO_ACSA_PROD.ACSA_LOG_RPT_SEGUIMIENTO_OC_IMP";

                HanaParameter fechaI = new HanaParameter();
                HanaParameter fechaFin = new HanaParameter();
                HanaParameter codPro = new HanaParameter();
                HanaParameter nomPro = new HanaParameter();
                HanaParameter Soli = new HanaParameter();
                HanaParameter Ord = new HanaParameter();
                HanaParameter reser = new HanaParameter();
                HanaParameter entrada = new HanaParameter();
                HanaParameter precio = new HanaParameter();
                HanaParameter transferencia = new HanaParameter();
                // Parametro Fecha 1.
                fechaI = cmd.CreateParameter();
                fechaI.HanaDbType = HanaDbType.Date;
                fechaI.Direction = ParameterDirection.Input;
                fechaI.Value = FechaInicio;
                cmd.Parameters.Add(fechaI);

                // Parametro Fecha 2.
                fechaFin = cmd.CreateParameter();
                fechaFin.HanaDbType = HanaDbType.Date;
                fechaFin.Direction = ParameterDirection.Input;
                fechaFin.Value = FechaFin; ;
                cmd.Parameters.Add(fechaFin);


                codPro = cmd.CreateParameter();
                codPro.HanaDbType = HanaDbType.VarChar;
                codPro.Direction = ParameterDirection.Input;
                codPro.Value = CodProveedor;
                cmd.Parameters.Add(codPro);

                nomPro = cmd.CreateParameter();
                nomPro.HanaDbType = HanaDbType.VarChar;
                nomPro.Direction = ParameterDirection.Input;
                nomPro.Value = NomProveedor;
                cmd.Parameters.Add(nomPro);

                Soli = cmd.CreateParameter();
                Soli.HanaDbType = HanaDbType.VarChar;
                Soli.Direction = ParameterDirection.Input;
                Soli.Value = Solicitud;
                cmd.Parameters.Add(Soli);

                Ord = cmd.CreateParameter();
                Ord.HanaDbType = HanaDbType.VarChar;
                Ord.Direction = ParameterDirection.Input;
                Ord.Value = Orden;
                cmd.Parameters.Add(Ord);

                reser = cmd.CreateParameter();
                reser.HanaDbType = HanaDbType.VarChar;
                reser.Direction = ParameterDirection.Input;
                reser.Value = Reserva;
                cmd.Parameters.Add(reser);

                entrada = cmd.CreateParameter();
                entrada.HanaDbType = HanaDbType.VarChar;
                entrada.Direction = ParameterDirection.Input;
                entrada.Value = Entrada;
                cmd.Parameters.Add(entrada);

                precio = cmd.CreateParameter();
                precio.HanaDbType = HanaDbType.VarChar;
                precio.Direction = ParameterDirection.Input;
                precio.Value = Precio;
                cmd.Parameters.Add(precio);

                transferencia = cmd.CreateParameter();
                transferencia.HanaDbType = HanaDbType.VarChar;
                transferencia.Direction = ParameterDirection.Input;
                transferencia.Value = Transferencia;
                cmd.Parameters.Add(transferencia);

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
