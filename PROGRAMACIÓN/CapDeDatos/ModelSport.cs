using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
   public class ModelSport : Model
    {
        public DataTable table;

        #region codigo del agus
        /* public ModelSport()
         {
             table = new DataTable();
         }*/
        /* public DataTable playerTable(string PlayerName)
         {
             string NombreJugador = PlayerName;
             Command.CommandText = "SELECT PLAYER.NAME, PLAYER.LNAME1, PLAYER.LNAME2, PLAYER.STATUS, PLAYER.BIRTHDATE FROM PLAYER WHERE PLAYER.NAME = @PlayerName";
             this.Command.Parameters.AddWithValue("@PlayerName", PlayerName);
             table.Load(Command.ExecuteReader());
             table = limpiarTablaJugador(table);
             return table;
         }

         public DataTable eventTable(string EventName)
         {
             string NombreEvento = EventName;
             this.Command.CommandText = " SELECT FAMILY.NAME," +
                 "FAMILY.RECURRENCY," +
                 "FAMILY.DOMAIN," +
                 "FAMILY.TYPE," +
                 "FAMILY.PARENT_ID," +
                 "EVENT.NAME," +
                 "EVENT.DATE," +
                 "TEAM.NAME," +
                 "PLAYER.NAME," +
                 "PLAYER.LNAME1," +
                 "PLAYER.STATUS," +
                 "PLAYER.AGE," +
                 "SCORE.TYPE," +
                 "SCORE.QUANTITY," +
                 "SCORE.CONTEXT," +
                 "FOULS.TYPE," +
                 "FOULS.QUANTITY," +
                 "FOULS.CONTEXT," +
                 "JUDGE.NAME," +
                 "JUDGE.LNAME1" +
                 "FROM EVENT STRAIGHT_JOIN(TIME, TMTI, TEAM, PLYR_TM, PLAYER, PLYR_TM_TI_SC, PLYR_TM_TIME_FL, SCORE, FOULS, JUDGE, JUD_FOUL, FAMILY, EVENT_FAMILY) " +
                 "ON(EVENT.ID = TIME.ID_EVENT" +
                 "AND TIME.ID = TMTI.ID_TIME" +
                 "AND TMTI.ID_TEAM = TEAM.ID" +
                 "AND PLYR_TM.ID_TEAM = TEAM.ID" +
                 "AND PLYR_TM.ID_PLYR = PLAYER.ID" +
                 "AND TIME.ID = PLYR_TM_TI_SC.ID_TIME " +
                 "AND TEAM.ID = PLYR_TM_TI_SC.ID_TEAM" +
                 "AND SCORE.ID = PLYR_TM_TI_SC.ID_SC" +
                 "AND PLYR_TM_TIME_FL.ID_TIME = TIME.ID " +
                 "AND PLYR_TM_TIME_FL.ID_TEAM = TEAM.ID" +
                 "AND PLYR_TM_TIME_FL.ID_FL = FOULS.ID " +
                 "AND JUD_FOUL.ID_FL = FOULS.ID" +
                 "AND JUD_FOUL.ID_JUD = JUDGE.ID)" +
                 "WHERE EVENT.NAME = @EventName;";
             this.Command.Parameters.AddWithValue("@EventName", EventName);
             table.Load(Command.ExecuteReader());
             table = RenombrarTablaEvento(table);
             return table;
         }
        /* public DataTable GetEventTableForCategory(string Category)
         {
             this.Command.CommandText = " SELECT FAMILY.NAME," +
                 "FAMILY.RECURRENCY," +
                 "FAMILY.DOMAIN," +
                 "FAMILY.TYPE," +
                 "FAMILY.PARENT_ID," +
                 "EVENT.NAME," +
                 "EVENT.DATE," +
                 "TEAM.NAME," +
                 "PLAYER.NAME," +
                 "PLAYER.LNAME1," +
                 "PLAYER.STATUS," +
                 "PLAYER.AGE," +
                 "SCORE.TYPE," +
                 "SCORE.QUANTITY," +
                 "SCORE.CONTEXT," +
                 "FOULS.TYPE," +
                 "FOULS.QUANTITY," +
                 "FOULS.CONTEXT," +
                 "JUDGE.NAME," +
                 "JUDGE.LNAME1" +
                 "FROM EVENT STRAIGHT_JOIN(TIME, TMTI, TEAM, PLYR_TM, PLAYER, PLYR_TM_TI_SC, PLYR_TM_TIME_FL, SCORE, FOULS, JUDGE, JUD_FOUL, FAMILY, EVENT_FAMILY) " +
                 "ON(EVENT.ID = TIME.ID_EVENT" +
                 "AND TIME.ID = TMTI.ID_TIME" +
                 "AND TMTI.ID_TEAM = TEAM.ID" +
                 "AND PLYR_TM.ID_TEAM = TEAM.ID" +
                 "AND PLYR_TM.ID_PLYR = PLAYER.ID" +
                 "AND TIME.ID = PLYR_TM_TI_SC.ID_TIME " +
                 "AND TEAM.ID = PLYR_TM_TI_SC.ID_TEAM" +
                 "AND SCORE.ID = PLYR_TM_TI_SC.ID_SC" +
                 "AND PLYR_TM_TIME_FL.ID_TIME = TIME.ID " +
                 "AND PLYR_TM_TIME_FL.ID_TEAM = TEAM.ID AND PLYR_TM_TIME_FL.ID_FL = FOULS.ID " +
                 "AND JUD_FOUL.ID_FL = FOULS.ID AND JUD_FOUL.ID_JUD = JUDGE.ID) " +
                 "WHERE EVENT.ID = EVENT_SPO.ID_Spo;";

             this.Command.Parameters.AddWithValue("@EventName", EventName);
             table.Load(Command.ExecuteReader());
             table = RenombrarTablaEvento(table);
             return table;
         }
         public DataTable RenombrarTablaEvento(DataTable t)
         {
             t.Columns[1].ColumnName = "NOMBRE FAMILIA";
             t.Columns[2].ColumnName = "RECURRENCIA FAMILIA";
             t.Columns[3].ColumnName = "DOMINIO FAMILIA";
             t.Columns[4].ColumnName = "TIPO DE FAMILIA";
             t.Columns[5].ColumnName = "FAMILIA ARRIBA";
             t.Columns[6].ColumnName = "NOMBRE EVENTO";
             t.Columns[7].ColumnName = "FECHA EVENTO";
             t.Columns[8].ColumnName = "NOMBRE EQUIPO";
             t.Columns[9].ColumnName = "NOMBRE JUGADOR";
             t.Columns[10].ColumnName = "APELLIDO";
             t.Columns[11].ColumnName = "STATUS";
             t.Columns[12].ColumnName = "EDAD";
             t.Columns[13].ColumnName = "TIPO PUNTAJE";
             t.Columns[14].ColumnName = "CONTEXTO PUNTAJE";
             t.Columns[15].ColumnName = "TIPO FOUL";
             t.Columns[16].ColumnName = "CANT FOUL";
             t.Columns[17].ColumnName = "CONTEXTO FOUL";
             t.Columns[18].ColumnName = "NOMBRE ARBITRO";
             t.Columns[19].ColumnName = "APELL ARBITRO";

             return t;
         }
         #region limpiar tabla
         public DataTable limpiarTabla(DataTable t)
         {
             t.Columns[0].ColumnName = "TORNEO";
             t.Columns[1].ColumnName = "EVENTO";
             t.Columns[2].ColumnName = "PUNTAJE";
             t.Columns[3].ColumnName = "EQUIPO";

             return t;
         }
         public DataTable limpiarTablaJugador(DataTable t)
         {
             t.Columns[0].ColumnName = "NOMBRE JUGADOR";
             t.Columns[1].ColumnName = "APELLIDO";
             t.Columns[2].ColumnName = "SEG. APELLIDO";
             t.Columns[3].ColumnName = "ESTATUS";
             t.Columns[4].ColumnName = "EDAD";

             return t;
         }
         #endregion
         public DataTable GetAllEventDataForTable()
         {
             this.Command.CommandText = "SELECT * FROM EVENT ";
             table.Load(Command.ExecuteReader());
             table = limpiarTabla(table);
             return table;
         }*/

        #endregion

        public int Id;
        public string Name { get; set; }
        public string Type { get; set; }

        public ModelSport(int id) => this.GetSportData(id);
        public ModelSport()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else
            {
                insert();
                insertType();
            }

        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "SPORT (Name) " +
                   $"VALUES ('{Name}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void insertType()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "T_SPO (ID_SP,TYPE) " +
                   $"VALUES ({GetId(Name)},'{Type}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            this.Command.CommandText = "UPDATE SPORT,T_SPO SET " +
                 $"NAME = '{Name}'," +
                 $"TYPE = '{Type}'" +
                 $"WHERE SPORT.ID = T_SPO.ID_SP AND SPORT.ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }
        public void  Delete (int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete T_SPO.* from T_SPO where ID_SP= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"Delete SPORT.* from SPORT where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetSportData(int id)
        {
            this.Command.CommandText = $"Select SPORT.*,T_SPO.TYPE From SPORT LEFT JOIN T_SPO ON SPORT.ID = T_SPO.ID_SP where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.Type = this.DataReader["TYPE"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetSportDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT SPORT.*,T_SPO.TYPE FROM SPORT LEFT JOIN T_SPO on SPORT.ID = T_SPO.ID_SP";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM SPORT WHERE NAME  = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool ExistSport(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM SPORT WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                exist = this.DataReader.HasRows;
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (exist) return true;
            else return false;
        }
        public bool HaveChange(int id)
        {
            string Type;
            try
            {
                this.Command.CommandText = $"SELECT SPORT.*,T_SPO.TYPE FROM SPORT LEFT JOIN T_SPO on SPORT.ID = T_SPO.ID_SP where SPORT.ID = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Type = this.DataReader["TYPE"].ToString();
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Type == "n") return true;
            else return false;
        }    
    }
}

