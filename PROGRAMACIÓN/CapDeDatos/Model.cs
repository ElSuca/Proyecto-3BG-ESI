using Newtonsoft.Json;
using MySqlConnector;
using System;

namespace CapaDeDatos
{
    public abstract class Model
    {
        [JsonIgnore]
        public string IpDataBase;
        [JsonIgnore]
        public string UserDataBase;
        [JsonIgnore]
        public string PasswordDataBase;
        [JsonIgnore]
        public string NameDataBase;
        [JsonIgnore]
        public string DataBasePort;
        [JsonIgnore]
        public MySqlConnection Conection;
        [JsonIgnore]
        public MySqlCommand Command;
        [JsonIgnore]
        public MySqlDataReader DataReader;
        [JsonIgnore]
        public MySqlCommand Commanditou;




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

                this.Conection.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
               // throw new TimeoutException("DatabaseNotFound");
            }
        }
        private void startConection()
        {
            #region credenciales
            this.IpDataBase = "192.168.5.50";
            this.NameDataBase = "ptahtechnologies";
            this.UserDataBase = "santiago.garcia";
            this.PasswordDataBase = "54605454";
            this.DataBasePort = "3306";
            #endregion
            //#region credenciales casa

            //this.IpDataBase = "127.0.0.1";
            //this.NameDataBase = "olympus";
            //this.UserDataBase = "bd_adm";
            //this.PasswordDataBase = "password";
            //this.DataBasePort = "3306";

            //#endregion
        }
        public void endConnection()
        {
            this.Command.Connection.Close();
        }
    }
}
