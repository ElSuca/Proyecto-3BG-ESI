using MySql.Data.MySqlClient;
using System;

namespace CapaDeDatos
{
    public abstract class Model
    {
        public string IpDataBase;
        public string UserDataBase;
        public string PasswordDataBase;
        public string NameDataBase;
        public string DataBasePort;
        public MySqlConnection Conection;
        public MySqlCommand Command;
        public MySqlCommand Commanditou;
        public MySqlDataReader DataReader;
        


        public Model()
        {
            conectDataBase();
            inicializarComando();
        }
        private void inicializarComando()
        {
            this.Command = new MySqlCommand();
            this.Command.Connection = this.Conection;
            this.Commanditou = new MySqlCommand();
            this.Commanditou.Connection = this.Conection;
        }
        private void conectDataBase()
        {
            this.startConection();
            try
            {
                this.Conection = new MySqlConnection(
                    $"server={this.IpDataBase};" +
                    $"userid={this.UserDataBase};" +
                    $"password={this.PasswordDataBase};" +
                    $"database={this.NameDataBase};" +
                    $"port={this.DataBasePort}"
                );
            }
            catch
            {
                throw new Exception("Data Base Not Found");
            }
            this.Conection.Open();
        }
        private void startConection()
        {
            #region credenciales
            /*  this.IpDataBase = "192.168.5.50";
              this.NameDataBase = "ptahtechnologies";
              this.UserDataBase = "santiago.garcia";
              this.PasswordDataBase = "54605454";
              this.DataBasePort = "3306";*/
            #endregion
            #region credenciales casa

            this.IpDataBase = "127.0.0.1";
              this.NameDataBase = "olympus";
              this.UserDataBase = "bd_adm";
              this.PasswordDataBase = "password";
              this.DataBasePort = "3306";
         
            #endregion
        }
    }
}
