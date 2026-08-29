using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace NexBank.Logica
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Servidor = "LAPTOP-0RU1SFNC\\SQLEXPRESS";
            this.Base = "bd_nexbank";
            this.Usuario = "nxb";
            this.Clave = "nxb505";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = "Server=" + this.Servidor +
                                            "; Database=" + this.Base +
                                            "; User Id=" + this.Usuario +
                                            "; Password=" + this.Clave +
                                            "; TrustServerCertificate=True;";
            }
            catch (Exception ex)
            {
                SqlCon = null;
                throw ex;
            }

            return SqlCon;
        }

        public static Conexion CrearInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }

            return Con;
        }
    }
}
