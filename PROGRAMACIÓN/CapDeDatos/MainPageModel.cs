using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public class MainPageModel : Model
    {
        public MainPageModel()
        {

        }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string SportName { get; set; }
        public string Start { get; set; }
        public int? IdEvent { get; set; }

        public List<string> TeamName { get; set; }
        public List<int?> IDTEAM { get; set; }
        public List<int?> Quant { get; set; }

        public Dictionary<int, MainPageModel> PopulateMainAsScore(int i, int s)
        {


            Dictionary<int, MainPageModel> maintemp = new Dictionary<int, MainPageModel>();
            this.Command.CommandText = "SELECT DISTINCT RESULT.ID_TM AS IDTEAM, " +
                "EVENT.ID AS IDEV, EVENT.NAME AS EVENTNAME, CONCAT_WS(',' , EVENT.STARTDATE, EVENT.ENDDATE ) AS EVENTDATE, " +
                "SPORT.NAME AS SPORTNAME, TEAM.NAME AS TEAMNAME, RESULT.QUANTITY AS QUANT " +
                " FROM ( SELECT ACTION.ID,  ID_TM,  ID_TI,  SUM(ACTION.QUANTITY) AS QUANTITY FROM ACTION  JOIN (TIME, EVENT) ON (EVENT.ID = TIME.ID_EVENT AND TIME.ID=ACTION.ID_TI) GROUP BY ID_TM , TIME.ID_EVENT)" +
                " AS RESULT JOIN (EVENT, EVENT_SPO, SPORT, TIME, TEAM) ON (EVENT.ID = EVENT_SPO.ID_EVENT AND EVENT_SPO.ID_SPO = SPORT.ID AND EVENT.ID = TIME.ID_EVENT AND TIME.ID = RESULT.ID_TI AND RESULT.ID_TM = TEAM.ID) WHERE EVENT.ID=@Id AND SPORT.ID=@Sport GROUP BY RESULT.ID_TM ORDER BY EVENT.ENDDATE";
            this.Command.Parameters.AddWithValue("@Id", i);
            this.Command.Parameters.AddWithValue("@Sport", s);
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
                MainPageModel u = maintemp.ContainsKey(int.Parse(row["IDEV"].ToString())) ? maintemp[int.Parse(row["IDEV"].ToString())]
                  : MainPageModel.FromRow(row);
                u.AddIds(row);
                maintemp[int.Parse(row["IDEV"].ToString())] = u;
            }

            return maintemp;

        }
        public Dictionary<int, MainPageModel> PopulateMainAsTimed(int i, int s)
        {
            Dictionary<int, MainPageModel> maintemp = new Dictionary<int, MainPageModel>();
            this.Command.CommandText = "SELECT DISTINCT RESULT.CAT AS CATEGORY ,RESULT.ID_TM AS IDTEAM, " +
                " EVENT.ID AS IDEV, EVENT.NAME AS EVENTNAME, CONCAT_WS(',' , EVENT.STARTDATE, EVENT.ENDDATE ) AS EVENTDATE, " +
                " EVENT.STARTDATE AS STARTDATE, SPORT.NAME AS SPORTNAME, TEAM.NAME AS TEAMNAME, RESULT.QUANTITY AS QUANT  FROM ( SELECT ACTION.ID,  ID_TM,  ID_TI,  SUM(ACTION.QUANTITY) AS QUANTITY, ACTION.CAT AS CAT, ACTION.TIME AS FINISHTIME FROM ACTION  JOIN (TIME, EVENT) ON (EVENT.ID = TIME.ID_EVENT AND TIME.ID=ACTION.ID_TI) GROUP BY ID_TM , TIME.ID_EVENT) AS RESULT JOIN (EVENT, EVENT_SPO, SPORT, TIME, TEAM) ON (EVENT.ID = EVENT_SPO.ID_EVENT AND EVENT_SPO.ID_SPO = SPORT.ID AND EVENT.ID = TIME.ID_EVENT AND TIME.ID = RESULT.ID_TI AND RESULT.ID_TM = TEAM.ID) WHERE EVENT.ID=@ID AND SPORT.ID=@SPORT GROUP BY RESULT.ID_TM ORDER BY EVENT.ENDDATE";
            this.Command.Parameters.AddWithValue("@Id", i);
            this.Command.Parameters.AddWithValue("@Sport", s);
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
                MainPageModel u = maintemp.ContainsKey(int.Parse(row["IDEV"].ToString())) ? maintemp[int.Parse(row["IDEV"].ToString())]
                  : MainPageModel.FromRow(row);
                u.AddIds(row);
                maintemp[int.Parse(row["IDEV"].ToString())] = u;
            }
            return maintemp;
        }

        public static MainPageModel FromRow(DataRow r)
        {
            MainPageModel t = new MainPageModel();
            t.IdEvent = int.Parse(r["IDEV"].ToString());
            t.EventName = r["EVENTNAME"].ToString();
            t.EventDate = r["EVENTDATE"].ToString();
            t.TeamName = new List<string>();
            t.SportName = r["SPORTNAME"].ToString();
            t.IDTEAM = new List<int?>();
            t.Quant = new List<int?>();
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Quant.Add(ParseInt(r["Quant"].ToString()));
            this.IDTEAM.Add(ParseInt(r["IdTeam"].ToString()));
            this.TeamName.Add((r["TeamName"].ToString()));
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
