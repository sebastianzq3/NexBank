using Microsoft.Data.SqlClient;
using NexBank.Logica;
using System.Data;
namespace Nexbank.Logica
{
    public class Cliente
    {
        public DataTable ListarClientes(string cBusqueda)
        {
            DataTable Tabla = null;
            try
            {
                SqlConnection SqlCon = Conexion.CrearInstancia().CrearConexion();
                using (SqlCon)
                {
                    SqlCon.Open();
                    SqlCommand SqlComm = SqlCon.CreateCommand();
                    using (SqlComm)
                    {
                        SqlComm.CommandText = "SP_LISTAR_CLIENTES";
                        SqlComm.CommandType = CommandType.StoredProcedure;

                        SqlComm.Parameters.Add("cBusqueda", SqlDbType.VarChar).Value = cBusqueda;
                        /* no utilizamos .AddWithValue pq no se podría avisar a sql qué tipo de variable
                         * le estamos enviando. Usamos .Add para especificar el valor y al final añadimos
                         * el .Value para poder asignar la variable
                         */


                        SqlDataReader SqlRead = SqlComm.ExecuteReader();
                        using (SqlRead)
                        {
                            Tabla = new DataTable();
                            Tabla.Load(SqlRead);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
            return Tabla;
        }
    }
}
