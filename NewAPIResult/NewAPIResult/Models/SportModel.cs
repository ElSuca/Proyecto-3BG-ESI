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
        public DataTable PopulateSportByPage(int i)
        {
            this.command.CommandText = "SELECT SPORT.*, " +
 "T_SPO.TYPE " +
 "FROM SPORT LEFT JOIN(T_SPO) " +
 "ON(T_SPO.ID_SP = SPORT.ID) " +
 " WHERE SPORT.ID<=@Id AND SPORT.ID>=@I ";
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
        public DataTable PopulateSportById(int i)
        {
            this.command.CommandText = "SELECT SPORT.*, " +
"T_SPO.TYPE " +
"FROM SPORT LEFT JOIN(T_SPO) " +
"ON(T_SPO.ID_SP = SPORT.ID) " +
"  WHERE SPORT.ID=@Id";
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
            return t;
        }
    }
}
