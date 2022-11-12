using CapaDeDatos;
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
        public Dictionary<int, EventTemp> PopulateEventByPage(int i)
        {
            Dictionary<int, EventTemp> eventtemp = new Dictionary<int, EventTemp>();
            this.Command.CommandText = "SELECT DISTINCT EVENT.*, PRE_EVENT.*, " +
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO, " +
 " STAGE.ID AS STAGEID, STAGE.NAME AS STAGENAME, STAGE.CITY, STAGE.STREET, STAGE.NUM AS STREETNUM, STAGE.STATE AS STAGESTATE, STAGE.COUNTRY AS STAGECOUNTRY , TIME.ID AS TIMEID, TIME.NUM, TIME.DESCR " +
 "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
 "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID)" +
 "WHERE EVENT.ID<=@Id AND EVENT.ID>=@I ";
            this.Command.Parameters.AddWithValue("@Id", i * 5);
            this.Command.Parameters.AddWithValue("@I", ((i - 1) * 5) + 1);
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.DataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.DataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.DataReader[col.ColumnName];
                }
            }
            foreach (DataRow row in t.Rows)
            {
                EventTemp u = eventtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? eventtemp[int.Parse(row["ID"].ToString())]
                  : EventTemp.FromRow(row);
                u.AddIds(row);
                eventtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return eventtemp;
        }
        public Dictionary<int, EventTemp> PopulateEventById(int i)
        {
            Dictionary<int, EventTemp> eventtemp = new Dictionary<int, EventTemp>();
            this.Command.CommandText = "SELECT DISTINCT EVENT.*, PRE_EVENT.*, " +
 "EVENT_FAMILY.ID_FAM, EVENT_SPO.ID_SPO, " +
 " STAGE.ID AS STAGEID, STAGE.NAME AS STAGENAME, STAGE.CITY, STAGE.STREET, STAGE.NUM AS STREETNUM, STAGE.STATE AS STAGESTATE, STAGE.COUNTRY AS STAGECOUNTRY , TIME.ID AS TIMEID, TIME.NUM AS TIMENUM, TIME.DESCR AS TIMEDES " +
 "FROM EVENT LEFT JOIN PRE_EVENT ON ((EVENT.ID = PRE_EVENT.ID_CHILD) OR(EVENT.ID = PRE_EVENT.ID_PARENT)) " +
 "LEFT JOIN STAGE ON (EVENT.STAGE = STAGE.ID) " +
 "LEFT JOIN TIME ON (TIME.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_SPO ON (EVENT_SPO.ID_EVENT = EVENT.ID) " +
 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_EVENT = EVENT.ID)" +
 " WHERE EVENT.ID=@Id ";
            this.Command.Parameters.AddWithValue("@Id", i );
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            DataTable t = new DataTable();
            DataTable schema = this.DataReader.GetSchemaTable();
            foreach (DataRow row in schema.Rows)
            {
                string colname = row.Field<string>("ColumnName");
                Type ty = row.Field<Type>("DataType");
                t.Columns.Add(colname, ty);
            }
            while (this.DataReader.Read())
            {
                var newRow = t.Rows.Add();
                foreach (DataColumn col in t.Columns)
                {
                    newRow[col.ColumnName] = this.DataReader[col.ColumnName];
                }
            }
            foreach (DataRow row in t.Rows)
            {
                EventTemp u = eventtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? eventtemp[int.Parse(row["ID"].ToString())]
                  : EventTemp.FromRow(row);
                u.AddIds(row);
                eventtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return eventtemp;
        }
    }

    public class EventTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public List<int?> Id_Child { get; set; }
        public List<int?> Id_Parent { get; set; }
        public List<string> Type { get; set; }
        public List<string> Info { get; set; }

        public int? StageId { get; set; }
        public string StageName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNum { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<int?> TimeID { get; set; }
        public List<int?> TimeNum { get; set; }
        public List<string> TimeDes { get; set; }

        public static EventTemp FromRow(DataRow r)
        {
            EventTemp t = new EventTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.StartDate = r["StartDate"].ToString();
            t.EndDate = r["EndDate"].ToString();
            t.StageId = ParseInt(r["StageId"].ToString());
            t.City = r["City"].ToString();
            t.Street = r["Street"].ToString();
            t.StreetNum = r["StreetNum"].ToString();
            t.State = r["StageState"].ToString();
            t.Country = r["StageCountry"].ToString();
            t.Id_Child = new List<int?>();
            t.Id_Parent = new List<int?>();
            t.TimeID = new List<int?>();
            t.Type = new List<string>();
            t.Info = new List<string>();
            t.TimeNum = new List<int?>();
            t.TimeDes = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Child.Add(ParseInt(r["Id_Child"].ToString()));
            this.Id_Parent.Add(ParseInt(r["Id_Parent"].ToString()));
            this.TimeID.Add(ParseInt(r["TimeId"].ToString()));
            this.TimeNum.Add(ParseInt(r["TimeNum"].ToString()));
            this.Type.Add(r["Type"].ToString());
            this.Info.Add(r["Info"].ToString());
            this.TimeDes.Add(r["TimeDes"].ToString());
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
