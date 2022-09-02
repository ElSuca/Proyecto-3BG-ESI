using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

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
