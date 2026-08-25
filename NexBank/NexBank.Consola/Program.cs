using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using NexBank.Logica;
namespace NexBank.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prueba de conexión
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.crearInstancia().CrearConexion();

            try
            {
                SqlCon.Open();
                Console.WriteLine("Conexión exitosa!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexión fallida");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
