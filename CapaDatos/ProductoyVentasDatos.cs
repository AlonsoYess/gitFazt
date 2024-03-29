﻿using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class ProductoyVentasDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ProductoyVentasDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable ProductoyVentaListar(string codigo, string ruc,string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_VentasMensualesGCProducto2";
                cmd.Parameters.Add(new SqlParameter("@codigoArticulo", codigo));
                cmd.Parameters.Add(new SqlParameter("@rucCliente", ruc));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "DespachosAlmacen");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["DespachosAlmacen"]);
        }

    }
}
