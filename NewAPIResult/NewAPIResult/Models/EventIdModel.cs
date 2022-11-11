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
        public DataTable PopulatePlayer(int s, int p)
        {
            this.command.CommandText = $"SELECT ID FROM EVENT LEFT JOIN (EVENT_SPO) ON (EVENT.ID = EVENT_SPO.ID_EVENT) WHERE EVENT_SPO.ID_SPO=@S ORDER BY EVENT.STARTDATE LIMIT 5 OFFSET @P";
            this.command.Parameters.AddWithValue("@S", s);
            this.command.Parameters.AddWithValue("@P", p);
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
