using MySql.Data.MySqlClient;

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
        public MySqlCommand commanditou;
                

        public Model()
        {
            conectDataBase();
            inicializarComando();
        }
        private void inicializarComando()
        {
            this.command = new MySqlCommand();
            this.command.Connection = this.conection;
            this.commanditou = new MySqlCommand();
            this.commanditou.Connection = this.conection;

        }
        private void conectDataBase()
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
            /*this.IpDataBase = "192.168.5.50";
                this.NameDataBase = "ptahtechnologies";
                this.UserDataBase = "santiago.garcia";
                this.PasswordDataBase = "54605454";
                this.PuertoDataBase = "3306";*/
            #endregion
            #region credenciales casa
            
                 this.IpDataBase = "127.0.0.1";
                 this.NameDataBase = "olympus";
                 this.UserDataBase = "bd_adm";
                 this.PasswordDataBase = "password";
                 this.PuertoDataBase = "3306";
            
            #endregion
        }
    }
}
