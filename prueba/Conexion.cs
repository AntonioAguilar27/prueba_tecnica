using MySql.Data.MySqlClient;

namespace PruebaTecnica
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "pruebatecnica";
            string usuario = "root";
            string password = "";

            // Asegúrate de que haya un separador entre los parámetros
            string cadenaConexion = $"Server={servidor}; Database={bd}; User Id={usuario}; Password={password};";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
