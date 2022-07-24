using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public abstract class Model
    {
        public string IpDataBase;
        public string UserDataBase;
        public string PasswordDataBase;
        public string NameDataBase;
        public string PuertoDataBase;
        public MySqlConnection conection;
        public MySqlCommand command;
        public MySqlDataReader dataReader;

        public Model()
        {
            conectDataBase();
            inicializarComando();
        }
        private void inicializarComando()
        {
            this.command = new MySqlCommand();
            this.command.Connection = this.conection;
        }
        private void conectDataBase()
        {
            this.startConection();
            this.conection = new MySqlConnection(
                $"server={this.IpDataBase};" +
                $"userid={this.UserDataBase};" +
                $"password={this.PasswordDataBase};" +
                $"database={this.NameDataBase};" +
                $"port={this.PuertoDataBase}"
            );
            this.conection.Open();
        }
        private void startConection()
        {
            this.IpDataBase = "127.0.0.1";
            this.NameDataBase = "proyecto";
            this.UserDataBase = "root";
            this.PasswordDataBase = "root";
            this.PuertoDataBase = "3306"; 
        }
    }
}
