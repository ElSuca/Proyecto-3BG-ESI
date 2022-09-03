using MySql.Data.MySqlClient;

namespace CapaLoogica
{
    public class AplicationControler
    {

        public MySqlConnection ConectDatabase()
        {
            MySqlConnection conexion = new MySqlConnection(
            "server = 127.0.0.1; " +
            "uid = bd_adm;" +
            "pwd=password;" +
            "database=olympus"
            );

            conexion.Open();
            return conexion;
        }


    }
}
