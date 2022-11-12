using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class FamilyModel : Model
    {
        public Dictionary<int, FamTemp> PopulateFamilyByPage(int i)
        {
            Dictionary<int, FamTemp> famtemp = new Dictionary<int, FamTemp>();
            this.Command.CommandText = "SELECT DISTINCT FAMILY.*, PRE_FAMILY.ID_CHILD," +
                 " PRE_FAMILY.ID_PARENT, PRE_FAMILY.TYPE AS RTYPE, PRE_FAMILY.INFO " +
                 "EVENT_FAMILY.ID_EVENT" +
  "FROM FAMILY LEFT JOIN PRE_FAMILY ON (FAMILY.ID = PRE_FAMILY.ID_CHILD) OR FAMILY.ID = PRE_FAMILY.ID_PARENT) " +
 "LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_FAM = FAMILY.ID)" +
 "WHERE FAMILY.ID<=@Id AND FAMILY.ID>=@I ";
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
                FamTemp u = famtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? famtemp[int.Parse(row["ID"].ToString())]
                  : FamTemp.FromRow(row);
                u.AddIds(row);
                famtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return famtemp;
        }
        public Dictionary<int, FamTemp> PopulateFamilyById(int i)
        {
            Dictionary<int, FamTemp> famtemp = new Dictionary<int, FamTemp>();
            this.Command.CommandText = "SELECT DISTINCT FAMILY.*, PRE_FAMILY.ID_CHILD," +
                " PRE_FAMILY.ID_PARENT, PRE_FAMILY.TYPE AS RTYPE, PRE_FAMILY.INFO, " +
 " EVENT_FAMILY.ID_EVENT AS IDEV " +
 " FROM FAMILY LEFT JOIN PRE_FAMILY ON FAMILY.ID=PRE_FAMILY.ID_CHILD OR FAMILY.ID=PRE_FAMILY.ID_PARENT " +
 " LEFT JOIN EVENT_FAMILY ON (EVENT_FAMILY.ID_FAM = FAMILY.ID)" +
 " WHERE FAMILY.ID=@Id ";
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
                FamTemp u = famtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? famtemp[int.Parse(row["ID"].ToString())]
                  : FamTemp.FromRow(row);
                u.AddIds(row);
                famtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return famtemp;
        }
    }
    public class FamTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Recurrency { get; set; }
        public string Domain { get; set; }
        public string Type { get; set; }

        public List<int?> Id_Child { get; set; }
        public List<int?> Id_Parent { get; set; }
        public List<string> RType { get; set; }
        public List<string> Info { get; set; }

        public List<int?> IdEv { get; set; }

        public static FamTemp FromRow(DataRow r)
        {
            FamTemp t = new FamTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.Recurrency = r["Recurrency"].ToString();
            t.Domain = r["Domain"].ToString();
            t.Type = r["Type"].ToString();
            t.Id_Child = new List<int?>();
            t.Id_Parent = new List<int?>();
            t.IdEv = new List<int?>();
            t.RType = new List<string>();
            t.Info = new List<string>();
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Child.Add(ParseInt(r["Id_Child"].ToString()));
            this.Id_Parent.Add(ParseInt(r["Id_Parent"].ToString()));
            this.IdEv.Add(ParseInt(r["IdEv"].ToString()));
            this.RType.Add(r["RType"].ToString());
            this.Info.Add(r["Info"].ToString());
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
