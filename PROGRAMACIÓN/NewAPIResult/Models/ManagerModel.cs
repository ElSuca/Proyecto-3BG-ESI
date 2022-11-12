using CapaDeDatos;
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
        public Dictionary<int, ManaTemp> PopulateManagerByPage(int i)
        {
            Dictionary<int, ManaTemp> manatemp = new Dictionary<int, ManaTemp>();
            this.Command.CommandText = "SELECT DISTINCT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES ," +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM , " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT " +
 "FROM MANAGER " +
 "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA " +
 "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
 "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
 "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA" +
 " WHERE MANAGER.ID<=@Id AND MANAGER.ID>=@I ";
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
                ManaTemp u = manatemp.ContainsKey(int.Parse(row["ID"].ToString())) ? manatemp[int.Parse(row["ID"].ToString())]
                  : ManaTemp.FromRow(row);
                u.AddIds(row);
                manatemp[int.Parse(row["Id"].ToString())] = u;
            }
            return manatemp;
        }
        public Dictionary<int, ManaTemp> PopulateManagerById(int i)
        {
            Dictionary<int, ManaTemp> manatemp = new Dictionary<int, ManaTemp>();
            this.Command.CommandText = "SELECT DISTINCT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES , " +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM ,  " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT  " +
 "FROM MANAGER  " +
 "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA  " +
 "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
 "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
 "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA " +
 " WHERE MANAGER.ID=@Id";
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
                ManaTemp u = manatemp.ContainsKey(int.Parse(row["ID"].ToString())) ? manatemp[int.Parse(row["ID"].ToString())]
                  : ManaTemp.FromRow(row);
                u.AddIds(row);
                manatemp[int.Parse(row["Id"].ToString())] = u;
            }
            return manatemp;
        }
    }
    public class ManaTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Lname2 { get; set; }
        public string Status { get; set; }
        public string Birthdate { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<int?> Id_Asoc { get; set; }
        public List<string> Times_Asoc { get; set; }
        public List<int?> Id_Team { get; set; }
        public List<int?> Id_Plyr { get; set; }
        public List<int?> Id_Spo { get; set; }
        public static ManaTemp FromRow(DataRow r)
        {
            ManaTemp t = new ManaTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.Lname = r["Lname1"].ToString();
            t.Lname2 = r["Lname2"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.Id_Asoc = new List<int?>();
            t.Id_Plyr = new List<int?>();
            t.Id_Spo = new List<int?>();
            t.Id_Team = new List<int?>();
            t.Times_Asoc = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Asoc.Add(ParseInt(r["ASOC"].ToString()));
            this.Id_Team.Add(ParseInt(r["TEAM"].ToString()));
            this.Id_Plyr.Add(ParseInt(r["PLAYER"].ToString()));
            this.Id_Spo.Add(ParseInt(r["SPORT"].ToString()));
            this.Times_Asoc.Add((r["Dates"].ToString()));

        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
