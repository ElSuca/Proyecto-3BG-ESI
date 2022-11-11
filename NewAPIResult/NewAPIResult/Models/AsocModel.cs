using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class AsocModel : Model
    {
        public DataTable PopulateAsocByPage(int i)
        {
            this.command.CommandText = "SELECT ASOC.*, CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES " +
 "ASOC_STATUS.SPORT AS SPORTSTAT, ASOC_STATUS.CAT CATSTAT," +
 "ASOC_STATUS.QUANT AS STATQUANT, ASOC_PLAYER.ID_PLYR AS PLAYER, MANA_ASOC.ID_MANA AS MANAGER, TM_ASOC.ID_TEAM AS TEAM , ASOC_SPO.ID_SPO AS SPORT" +
 "CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE, ASOC_PLYR.ENDDATE) AS PLAYERDATES," +
 "CONCAT_WS(' - ' , MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS MANAGERDATES" +
 "FROM ASOC LEFT JOIN(ASOC_STATUS, ASOC_PLYR, MANA_ASOC, TM_ASOC, ASOC_SPO) " +
 "ON(ASOC.ID=ASOC_STATUS.ID_ASOC" +
 "AND(ASOC.ID=ASOC_SPO.ID_ASOC) " +
 "AND(ASOC.ID=MANA_ASOC.ID_ASOC) " +
 "AND(ASOC.ID=ASOC_PLYR.ID_ASOC) " +
 "AND(ASOC.ID=TM_ASOC.ID_ASOC)) WHERE ASOC.ID<=@Id AND ASOC.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulateAsocById(int i)
        {
            this.command.CommandText = "SELECT ASOC.*, CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES " +
"ASOC_STATUS.SPORT AS SPORTSTAT, ASOC_STATUS.CAT CATSTAT," +
"ASOC_STATUS.QUANT AS STATQUANT, ASOC_PLAYER.ID_PLYR AS PLAYER, MANA_ASOC.ID_MANA AS MANAGER, TM_ASOC.ID_TEAM AS TEAM , ASOC_SPO.ID_SPO AS SPORT" +
"CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE, ASOC_PLYR.ENDDATE) AS PLAYERDATES," +
"CONCAT_WS(' - ' , MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS MANAGERDATES" +
"FROM ASOC LEFT JOIN(ASOC_STATUS, ASOC_PLYR, MANA_ASOC, TM_ASOC, ASOC_SPO) " +
"ON(ASOC.ID=ASOC_STATUS.ID_ASOC" +
"AND(ASOC.ID=ASOC_SPO.ID_ASOC) " +
"AND(ASOC.ID=MANA_ASOC.ID_ASOC) " +
"AND(ASOC.ID=ASOC_PLYR.ID_ASOC) " +
"AND(ASOC.ID=TM_ASOC.ID_ASOC)) WHERE ASOC.ID=@Id";
            this.command.Parameters.AddWithValue("@Id", i);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
    }
}
