using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class TeamModel : Model
    {
        public DataTable PopulateTeamByPage(int i)
        {
            this.command.CommandText = "SELECT TEAM.*, " +
 "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
 "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO" +
 "FROM TEAM LEFt JOIN(TM_ASOC, PLYR_TI, MANA_TEAM, TM_SPO) " +
 "ON(TEAM.ID=TM_ASOC.ID_ASOC" +
 "AND(TM_SPO.ID_TEAM=TEAM.ID) " +
 "AND(MANA_TEAM.ID_TEAM=TEAM.ID) " +
 "AND(PLYR_TI.ID_TEAM=TEAM.ID) " +
 ") WHERE TEAM.ID<=@Id AND TEAM.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulateTeamById(int i)
        {
            this.command.CommandText = "SELECT TEAM.*, " +
 "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
 "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO" +
 "FROM TEAM LEFT JOIN(TM_ASOC, PLYR_TI, MANA_TEAM, TM_SPO) " +
 "ON(TEAM.ID=TM_ASOC.ID_ASOC" +
 "AND(TM_SPO.ID_TEAM=TEAM.ID) " +
 "AND(MANA_TEAM.ID_TEAM=TEAM.ID) " +
 "AND(PLYR_TI.ID_TEAM=TEAM.ID) " +
") WHERE TEAM.ID=@Id";
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
