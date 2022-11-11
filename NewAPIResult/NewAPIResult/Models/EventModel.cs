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
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO, " +
 " STAGE.ID AS STAGEID, STAGE.NAME AS STAGENAME, STAGE.CITY, STAGE.STREET, STAGE.NUM AS STREETNUM, STAGE.STATE AS STAGESTATE, STAGE.COUNTRY AS STAGECOUNTRY , TIME.ID AS TIMEID, TIME.NUM, TIME.DESCR " +
 "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
 "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID))" +
 "WHERE EVENT.ID<=@Id AND EVENT.ID>=@I ";
            this.command.Parameters.AddWithValue("@Id", i * 5);
            this.command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.dataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.dataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.dataReader[col.ColumnName];
                }
            }
            return t;
        }
        public DataTable PopulateEventById(int i)
        {
            this.command.CommandText = "SELECT EVENT.*, PRE_EVENT.*, " +
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO, " +
 " STAGE.ID AS STAGEID, STAGE.NAME AS STAGENAME, STAGE.CITY, STAGE.STREET, STAGE.NUM AS STREETNUM, STAGE.STATE AS STAGESTATE, STAGE.COUNTRY AS STAGECOUNTRY , TIME.ID AS TIMEID, TIME.NUM, TIME.DESCR " +
 "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
 "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID)" +
 " WHERE EVENT.ID=@Id ";
            this.command.Parameters.AddWithValue("@Id", i );
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.dataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.dataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.dataReader[col.ColumnName];
                }
            }
            return t;
        }
    }
}
