using CapDeDatos;
using MySql.Data.MySqlClient;

namespace CapaLoogica
{
    public class AplicationControler
    {
        public void setLanguage(int l) => new SafeSystemBuffer().SetLanguage(l);
        public int getLanguage() => new SafeSystemBuffer().GetLanguage();

       /* public MySqlConnection ConectDatabase()
        {
            MySqlConnection conexion = new MySqlConnection(
            "server = 127.0.0.1; " +
            "uid = bd_adm;" +
            "pwd=password;" +
            "database=olympus"
            );

            conexion.Open();
            return conexion;
        }*/
    }
}
