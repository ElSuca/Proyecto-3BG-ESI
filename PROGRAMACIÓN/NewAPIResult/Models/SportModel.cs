using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class SportModel : Model
    {
        public Dictionary<int, SportTemp> PopulateSportByPage(int i)
        {
            Dictionary<int, SportTemp> sporttemp = new Dictionary<int, SportTemp>();
            this.Command.CommandText = "SELECT DISTINCT SPORT.*, " +
 "T_SPO.TYPE " +
 "FROM SPORT LEFT JOIN(T_SPO) " +
 "ON(T_SPO.ID_SP = SPORT.ID) " +
 " WHERE SPORT.ID<=@Id AND SPORT.ID>=@I ";
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
                SportTemp u = sporttemp.ContainsKey(int.Parse(row["ID"].ToString())) ? sporttemp[int.Parse(row["ID"].ToString())]
                  : SportTemp.FromRow(row);
                u.AddIds(row);
                sporttemp[int.Parse(row["Id"].ToString())] = u;
            }
            return sporttemp;
        }
        public Dictionary<int, SportTemp> PopulateSportById(int i)
        {
            Dictionary<int, SportTemp> sporttemp = new Dictionary<int, SportTemp>();
            this.Command.CommandText = "SELECT DISTINCT SPORT.*, " +
"T_SPO.TYPE " +
"FROM SPORT LEFT JOIN(T_SPO) " +
"ON(T_SPO.ID_SP = SPORT.ID) " +
"  WHERE SPORT.ID=@Id";
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
                SportTemp u = sporttemp.ContainsKey(int.Parse(row["ID"].ToString())) ? sporttemp[int.Parse(row["ID"].ToString())]
                  : SportTemp.FromRow(row);
                u.AddIds(row);
                sporttemp[int.Parse(row["Id"].ToString())] = u;
            }
            return sporttemp;
        }
    }
    public class SportTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Type { get; set; }

        public static SportTemp FromRow(DataRow r)
        {
            SportTemp t = new SportTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.Type = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Type.Add((r["Type"].ToString()));
            

        }
    }
}
