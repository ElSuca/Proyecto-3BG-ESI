using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ApiResults

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
        public string PuertoDataBase;
        [JsonIgnore]
        public MySqlConnection conection;
        [JsonIgnore]
        public MySqlCommand command;
        [JsonIgnore]
        public MySqlDataReader dataReader;
        [JsonIgnore]
        public MySqlCommand commanditou;


        public Model()
        {
            connectDataBase();
            inicializarComando();
        }
        private void inicializarComando()
        {
            this.command = new MySqlCommand();
            this.command.Connection = this.conection;
            this.commanditou = new MySqlCommand();
            this.commanditou.Connection = this.conection;

        }
        public void connectDataBase()
        {
            this.startConection();
            try
            {
                this.conection = new MySqlConnection(
                    $"server={this.IpDataBase};" +
                    $"userid={this.UserDataBase};" +
                    $"password={this.PasswordDataBase};" +
                    $"database={this.NameDataBase};" +
                    $"port={this.PuertoDataBase}"
                );

            }
            catch
            {

            }
            this.conection.Open();
        }
        private void startConection()
        {
            #region credenciales
           /* this.IpDataBase = "192.168.5.50";
            this.NameDataBase = "ptahtechnologies";
            this.UserDataBase = "santiago.garcia";
            this.PasswordDataBase = "54605454";
            this.PuertoDataBase = "3306";*/
            #endregion
            #region credenciales casa

              this.IpDataBase = "127.0.0.1";
              this.NameDataBase = "olympus";
              this.UserDataBase = "root";
              this.PasswordDataBase = "adxitspaydaygangadx12";
              this.PuertoDataBase = "3306";
         
            #endregion
        }
        public void endConnection()
        {
            this.command.Connection.Close();
        }
    }
}
