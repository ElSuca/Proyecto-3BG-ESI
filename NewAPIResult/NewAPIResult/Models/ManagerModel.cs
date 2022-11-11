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
        public DataTable PopulateManagerByPage(int i)
        {
            this.command.CommandText = "SELECT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES ," +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM , " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT " +
 "FROM MANAGER " +
 "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA " +
 "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
 "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
 "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA" +
 " WHERE MANAGER.ID<=@Id AND MANAGER.ID>=@I ";
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
        public DataTable PopulateManagerById(int i)
        {
            this.command.CommandText = "SELECT MANAGER.*, CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES , " +
 "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM ,  " +
 "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT  " +
 "FROM MANAGER  " +
 "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA  " +
 "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
 "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
 "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA " +
 " WHERE MANAGER.ID=@Id";
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
