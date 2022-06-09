using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public abstract class Class1
    {
        private void OpenConection()
        {
            MySqlConnection conexion = new MySqlConnection(
               "server = 127.0.0.1; " +
               "uid = root;" +
               "pwd=root;" +
               "database=proyecto"
              );
            conexion.Open();
        }
    }

    
}
