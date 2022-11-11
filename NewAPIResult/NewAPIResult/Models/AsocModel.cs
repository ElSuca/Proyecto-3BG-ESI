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
        public Dictionary<int, AsocTemp> PopulateAsocByPage(int i)
        {
            Dictionary<int, AsocTemp> asoctemp = new Dictionary<int, AsocTemp>();
            this.command.CommandText = "SELECT DISTINCT ASOC.*, CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES, " +
"ASOC_STATUS.SPORT AS SPORTSTAT, ASOC_STATUS.CAT AS CATSTAT, " +
"ASOC_STATUS.QUANTITY AS STATQUANT, ASOC_PLYR.ID_PLYR AS PLAYER, MANA_ASOC.ID_MANA AS MANAGER, TM_ASOC.ID_TEAM AS TEAM , ASOC_SPO.ID_SPO AS SPORT, " +
" CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE , ASOC_PLYR.ENDDATE) AS PLAYERDATES, " +
" CONCAT_WS(' - ' , MANA_ASOC.STARTDATE , MANA_ASOC.ENDDATE) AS MANAGERDATES " +
" FROM ASOC LEFT JOIN ASOC_STATUS ON ASOC.ID=ASOC_STATUS.ID_ASOC " +
" LEFT JOIN ASOC_SPO ON ASOC.ID=ASOC_SPO.ID_ASOC " +
"LEFT JOIN MANA_ASOC ON   ASOC.ID=MANA_ASOC.ID_ASOC " +
"LEFT JOIN ASOC_PLYR ON   ASOC.ID=ASOC_PLYR.ID_ASOC " +
" LEFT JOIN TM_ASOC ON  ASOC.ID=TM_ASOC.ID_ASOC " +
 " WHERE ASOC.ID<=@Id AND ASOC.ID>=@I ";
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
            foreach (DataRow row in t.Rows)
            {
                AsocTemp u = asoctemp.ContainsKey(int.Parse(row["ID"].ToString())) ? asoctemp[int.Parse(row["ID"].ToString())]
                  : AsocTemp.FromRow(row);
                u.AddIds(row);
                asoctemp[int.Parse(row["Id"].ToString())] = u;
            }
            return asoctemp;
        }
        public Dictionary<int, AsocTemp> PopulateAsocById(int i)
        {
            Dictionary<int, AsocTemp> asoctemp = new Dictionary<int, AsocTemp>();
            this.command.CommandText = "SELECT DISTINCT ASOC.*, CONCAT_WS(', ', ASOC_STATUS.STARTDATE, ASOC_STATUS.ENDDATE) AS DATES, " +
"ASOC_STATUS.SPORT AS SPORTSTAT, ASOC_STATUS.CAT AS CATSTAT, " +
"ASOC_STATUS.QUANTITY AS STATQUANT, ASOC_PLYR.ID_PLYR AS PLAYER, MANA_ASOC.ID_MANA AS MANAGER, TM_ASOC.ID_TEAM AS TEAM , ASOC_SPO.ID_SPO AS SPORT, " +
" CONCAT_WS(' - ' , ASOC_PLYR.STARTDATE , ASOC_PLYR.ENDDATE) AS PLAYERDATES, " +
" CONCAT_WS(' - ' , MANA_ASOC.STARTDATE , MANA_ASOC.ENDDATE) AS MANAGERDATES " +
" FROM ASOC LEFT JOIN ASOC_STATUS ON ASOC.ID=ASOC_STATUS.ID_ASOC " +
" LEFT JOIN ASOC_SPO ON ASOC.ID=ASOC_SPO.ID_ASOC " +
"LEFT JOIN MANA_ASOC ON   ASOC.ID=MANA_ASOC.ID_ASOC " +
"LEFT JOIN ASOC_PLYR ON   ASOC.ID=ASOC_PLYR.ID_ASOC " +
" LEFT JOIN TM_ASOC ON  ASOC.ID=TM_ASOC.ID_ASOC " +
"WHERE ASOC.ID=@Id";
            this.command.Parameters.AddWithValue("@Id", i);
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
            foreach (DataRow row in t.Rows)
            {
                AsocTemp u = asoctemp.ContainsKey(int.Parse(row["ID"].ToString())) ? asoctemp[int.Parse(row["ID"].ToString())]
                  : AsocTemp.FromRow(row);
                u.AddIds(row);
                asoctemp[int.Parse(row["Id"].ToString())] = u;
            }
            return asoctemp;
        }
    }
    public class AsocTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string StreetNum { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<string> Dates { get; set; }
        public List<string> SportStats { get; set; }
        public List<string> CatStat { get; set; }
        public List<string> StatQuant { get; set; }

        public List<int?> Player { get; set; }
        public List<int?> Manager { get; set; }
        public List<int?> Team { get; set; }
        public List<int?> Sport { get; set; }

        public List<string> PlayerDates { get; set; }
        public List<string> Managerdates { get; set; }

        public static AsocTemp FromRow(DataRow r)
        {
            AsocTemp t = new AsocTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.Street = r["LNAME1"].ToString();
            t.StreetNum = r["Lname2"].ToString();
            t.Status = r["City"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.City = r["CITY"].ToString();
            t.Dates = new List<string>();
            t.SportStats = new List<string>();
            t.CatStat = new List<string>();
            t.StatQuant = new List<string>();
            t.PlayerDates = new List<string>();
            t.Managerdates = new List<string>();
            t.Player = new List<int?>();
            t.Manager = new List<int?>();
            t.Team = new List<int?>();
            t.Sport = new List<int?>();

            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Player.Add(ParseInt(r["Player"].ToString()));
            this.Manager.Add(ParseInt(r["Manager"].ToString()));
            this.Team.Add(ParseInt(r["Team"].ToString()));
            this.Sport.Add(ParseInt(r["Sport"].ToString()));
            this.SportStats.Add((r["SportStats"].ToString()));
            this.CatStat.Add((r["CatStat"].ToString()));
            this.PlayerDates.Add((r["PlayerDates"].ToString()));
            this.Managerdates.Add((r["ManagerDates"].ToString()));
            this.StatQuant.Add((r["StatQuant"].ToString()));
            this.Dates.Add((r["Dates"].ToString()));
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
