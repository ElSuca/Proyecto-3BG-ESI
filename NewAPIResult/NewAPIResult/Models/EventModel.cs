using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class EventModel : Model
    {
        public DataTable PopulateEventByPage(int i)
        {
            this.command.CommandText = "SELECT EVENT.*, PRE_EVENT.*, " +
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO," +
 "STAGE.*, TIME.ID, TIME.NUM, TIME.DESCR " +
 "FROM EVENT LEFT JOIN(PRE_EVENT, EVENT_FAMILY, EVENT_SPO, STAGE, TIME) " +
 "ON(((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "AND(EVENT.STAGE = STAGE.ID) " +
 "AND(TIME.ID_EVENT = EVENT.ID) " +
 "AND(EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "AND(EVENT_FAMILY.ID_EVENT = EVENT.ID)) WHERE EVENT.ID<=@Id AND EVENT.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
        public DataTable PopulateEventById(int i)
        {
            this.command.CommandText = "SELECT EVENT.*, PRE_EVENT.*, " +
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO," +
 "STAGE.*, TIME.ID, TIME.NUM, TIME.DESCR " +
 "FROM EVENT LEFT JOIN(PRE_EVENT, EVENT_FAMILY, EVENT_SPO, STAGE, TIME) " +
 "ON(((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "AND(EVENT.STAGE = STAGE.ID) " +
 "AND(TIME.ID_EVENT = EVENT.ID) " +
 "AND(EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "AND(EVENT_FAMILY.ID_EVENT = EVENT.ID)) WHERE EVENT.ID=@Id ";
            this.command.Parameters.AddWithValue("@Id", i );
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
    }
}
