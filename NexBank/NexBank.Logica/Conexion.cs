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
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                            "; Database=" + this.Base +
                                            "; User Id=" + this.Usuario +
                                            "; Password=" + this.Clave +
                                            "; TrustServerCertificate=True;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion crearInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }

            return Con;
        }
    }
}
