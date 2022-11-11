using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class ManagerModel : Model
    {
        public DataTable PopulateManagerByPage(int i)
        {
            this.command.CommandText = "SELECT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES " +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM , " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT " +
 "FROM MANAGER LEFT JOIN(MANA_ASOC, MANA_TEAM, MANA_PLYR, MANA_SPO) " +
 "ON(MANAGER.ID=MANA_PLYR.ID_MANA " +
 "AND(MANAGER.ID=MANA_TEAM.ID_MANA) " +
 "AND(MANAGER.ID=MANA_ASOC) " +
 "AND(MANAGER.ID=MANA_SPO.ID_MANA) " +
 " WHERE ASOC.ID<=@Id AND ASOC.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulateManagerById(int i)
        {
            this.command.CommandText = "SELECT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES " +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM , " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT " +
 "FROM MANAGER LEFT JOIN(MANA_ASOC, MANA_TEAM, MANA_PLYR, MANA_SPO) " +
 "ON(MANAGER.ID=MANA_PLYR.ID_MANA " +
 "AND(MANAGER.ID=MANA_TEAM.ID_MANA) " +
 "AND(MANAGER.ID=MANA_ASOC) " +
 "AND(MANAGER.ID=MANA_SPO.ID_MANA) " +
 " WHERE ASOC.ID=@Id";
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
