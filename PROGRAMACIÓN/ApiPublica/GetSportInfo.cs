using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ApiPublica
{
    public class GetSportInfo
    {
        public string IpDataBase;
        public string UserDataBase;
        public string PasswordDataBase;
        public string NameDataBase;
        public string PuertoDataBase;
        public MySqlConnection conection;
        public MySqlCommand command;
        public MySqlDataReader dataReader;
        public DataTable table;
        public GetSportInfo()
        {
            conectDataBase();
            inicializarComando();
            table = new DataTable();

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
        public DataTable ejecutarComando()
        {
            this.command.CommandText = "SELECT FAMILY.NAME , EVENT.NAME , SCORE.QUANTITY , TEAM.NAME FROM OLYMPUS.EVENT STRAIGHT_JOIN ( TIME, TMTI, TEAM, PLYR_TM_TI_SC, SCORE, EVENT_FAMILY, FAMILY) ON (EVENT.ID = TIME.ID_EVENT AND TMTI.ID_TIME = TIME.ID AND TMTI.ID_TEAM = TEAM.ID AND PLYR_TM_TI_SC.ID_TIME = TIME.ID AND PLYR_TM_TI_SC.ID_TEAM = TEAM.ID AND PLYR_TM_TI_SC.ID_SC = SCORE.ID AND EVENT.ID = EVENT_FAMILY.ID_EVENT AND EVENT_FAMILY.ID_FAM = FAMILY.ID); ";
            table.Load(command.ExecuteReader());
            table = limpiarTabla(table);
            return table;
        }
        private DataTable limpiarTabla(DataTable t)
        {
            t.Columns[0].ColumnName = "TORNEO";
            t.Columns[1].ColumnName = "EVENTO";
            t.Columns[2].ColumnName = "PUNTAJE";
            t.Columns[3].ColumnName = "EQUIPO";

            return t;
        }
        private void startConection()
        {
            this.IpDataBase = "127.0.0.1";
            this.NameDataBase = "olympus";
            this.UserDataBase = "admin";
            this.PasswordDataBase = "password";
            this.PuertoDataBase = "3306";
        }

    }
}
