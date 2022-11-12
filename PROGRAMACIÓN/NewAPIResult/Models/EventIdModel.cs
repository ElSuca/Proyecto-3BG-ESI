using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class EventIdModel : Model
    {
        public HashSet<int?> PopulatePlayer(int s, int p)
        {
            HashSet<int?> a = new HashSet<int?>();
            this.Command.CommandText = $"SELECT DISTINCT ID FROM EVENT LEFT JOIN (EVENT_SPO) ON (EVENT.ID = EVENT_SPO.ID_EVENT) WHERE EVENT_SPO.ID_SPO=@S ORDER BY EVENT.STARTDATE LIMIT 5 OFFSET @P";
            this.Command.Parameters.AddWithValue("@S", s);
            this.Command.Parameters.AddWithValue("@P", p);
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
                a.Add(ParseInt(row["ID"].ToString()));
            }
            return a;
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
