using CapaDeDatos;
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
        public Dictionary<int,TeamTemp> PopulateTeamByPage(int i)
        {
            Dictionary<int, TeamTemp> teamtemp = new Dictionary<int, TeamTemp>();
            this.Command.CommandText = "SELECT DISTINCT TEAM.*, " +
 "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
 "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO " +
 "FROM TEAM LEFT JOIN PLYR_TI ON PLYR_TI.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_ASOC ON TEAM.ID=TM_ASOC.ID_ASOC " +
 "LEFT JOIN MANA_TEAM ON MANA_TEAM.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_SPO ON TM_SPO.ID_TEAM=TEAM.ID " +
 " WHERE TEAM.ID<=@Id AND TEAM.ID>=@I ";
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
                TeamTemp u = teamtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? teamtemp[int.Parse(row["ID"].ToString())]
                  : TeamTemp.FromRow(row);
                u.AddIds(row);
                teamtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return teamtemp;
        }
        public Dictionary<int, TeamTemp> PopulateTeamById(int i)
        {
            Dictionary<int, TeamTemp> teamtemp = new Dictionary<int, TeamTemp>();

            this.Command.CommandText = "SELECT DISTINCT TEAM.*, " +
 "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
 "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO " +
 "FROM TEAM LEFT JOIN PLYR_TI ON PLYR_TI.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_ASOC ON TEAM.ID=TM_ASOC.ID_ASOC " +
 "LEFT JOIN MANA_TEAM ON MANA_TEAM.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_SPO ON TM_SPO.ID_TEAM=TEAM.ID " +
"  WHERE TEAM.ID=@Id";
            this.Command.Parameters.AddWithValue("@Id", i);
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
                TeamTemp u = teamtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? teamtemp[int.Parse(row["ID"].ToString())]
                  : TeamTemp.FromRow(row);
                u.AddIds(row);
                teamtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return teamtemp;
        }
    }
    public class TeamTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<int?> Id_Asoc { get; set; }
        public List<int?> Id_Time { get; set; }
        public List<int?> Id_Plyr { get; set; }
        public List<int?> Id_Mana { get; set; }
        public List<int?> Id_Spo { get; set; }

        public static TeamTemp FromRow (DataRow r)
        {
            TeamTemp t = new TeamTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.City = r["City"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.Id_Asoc = new List<int?>();
            t.Id_Time = new List<int?>();
            t.Id_Plyr = new List<int?>();
            t.Id_Mana = new List<int?>();
            t.Id_Spo = new List<int?>();
            t.AddIds(r);
            return t;
          }
        public void AddIds (DataRow r)
        {
            this.Id_Asoc.Add(ParseInt(r["Id_Asoc"].ToString()));
            this.Id_Time.Add(ParseInt(r["Id_Time"].ToString()));
            this.Id_Plyr.Add(ParseInt(r["Id_Plyr"].ToString()));
            this.Id_Mana.Add(ParseInt(r["Id_Mana"].ToString()));
            this.Id_Spo.Add(ParseInt(r["Id_Spo"].ToString()));

        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
