using CapaDeDatos;
using System.Data;

namespace CapDeDatos
{
   public class ModelSport : Model
    {
        public DataTable table;

        public ModelSport()
        {
            table = new DataTable();
        }
        public DataTable playerTable(string PlayerName)
        {
            string NombreJugador = PlayerName;
            command.CommandText = "SELECT PLAYER.NAME, PLAYER.LNAME1, PLAYER.LNAME2, PLAYER.STATUS, PLAYER.AGE FROM PLAYER WHERE PLAYER.NAME = @PlayerName";
            this.command.Parameters.AddWithValue("@PlayerName", PlayerName);
            table.Load(command.ExecuteReader());
            table = limpiarTablaJugador(table);
            return table;
        }
        public DataTable eventTable(string EventName)
        {
            string NombreEvento = EventName;
            this.command.CommandText = " SELECT FAMILY.NAME , FAMILY.RECURRENCY, FAMILY.DOMAIN, " +
                "FAMILY.TYPE, FAMILY.PARENT_ID, EVENT.NAME, EVENT.DATE, TEAM.NAME, PLAYER.NAME, " +
                "PLAYER.LNAME1, PLAYER.STATUS, PLAYER.AGE, SCORE.TYPE, SCORE.QUANTITY, " +
                "SCORE.CONTEXT, FOULS.TYPE, FOULS.QUANTITY, FOULS.CONTEXT, JUDGE.NAME, JUDGE.LNAME1 " +
                "FROM OLYMPUS.EVENT STRAIGHT_JOIN(TIME, TMTI, TEAM, PLYR_TM, " +
                "PLAYER, PLYR_TM_TI_SC, PLYR_TM_TIME_FL, SCORE, FOULS, JUDGE, JUD_FOUL, FAMILY, EVENT_FAMILY) " +
                "ON(EVENT.ID = TIME.ID_EVENT AND TIME.ID = TMTI.ID_TIME AND TMTI.ID_TEAM = TEAM.ID " +
                "AND PLYR_TM.ID_TEAM = TEAM.ID AND PLYR_TM.ID_PLYR = PLAYER.ID AND TIME.ID = PLYR_TM_TI_SC.ID_TIME " +
                "AND TEAM.ID = PLYR_TM_TI_SC.ID_TEAM AND SCORE.ID = PLYR_TM_TI_SC.ID_SC AND PLYR_TM_TIME_FL.ID_TIME = TIME.ID " +
                "AND PLYR_TM_TIME_FL.ID_TEAM = TEAM.ID AND PLYR_TM_TIME_FL.ID_FL = FOULS.ID " +
                "AND JUD_FOUL.ID_FL = FOULS.ID AND JUD_FOUL.ID_JUD = JUDGE.ID) WHERE EVENT.NAME = @EventName;";
            this.command.Parameters.AddWithValue("@EventName", EventName);
            table.Load(command.ExecuteReader());
            table = limpiarTablaEvento(table);
            return table;
        }
        public DataTable limpiarTablaEvento(DataTable t)
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
            t.Columns[11].ColumnName = "ESTATUS";
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
        public DataTable ejecutarComando()
        {
            this.command.CommandText = "SELECT FAMILY.NAME ," +
                " EVENT.NAME ," +
                " SCORE.QUANTITY ," +
                " TEAM.NAME FROM OLYMPUS.EVENT STRAIGHT_JOIN ( TIME, TMTI, TEAM, PLYR_TM_TI_SC, SCORE, EVENT_FAMILY, FAMILY) ON " +
                "(EVENT.ID = TIME.ID_EVENT AND TMTI.ID_TIME = TIME.ID AND TMTI.ID_TEAM = TEAM.ID AND PLYR_TM_TI_SC.ID_TIME = TIME.ID AND PLYR_TM_TI_SC.ID_TEAM" +
                " = TEAM.ID AND PLYR_TM_TI_SC.ID_SC = SCORE.ID AND EVENT.ID = EVENT_FAMILY.ID_EVENT AND EVENT_FAMILY.ID_FAM = FAMILY.ID) LIMIT 5000; ";
            table.Load(command.ExecuteReader());
            table = limpiarTabla(table);
            return table;
        }
    }
}
