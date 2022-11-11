using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class MainPageModel : Model
    {
        

        public MainPageModel() : base()
        {
            base.connectDataBase();
        }
        public DataTable PopulateMainAsScore(int i, int s)
        {
            this.command.CommandText = $"SELECT DISTINCT RESULT.ID_TM AS IDTEAM, EVENT.ID AS IDEV, EVENT.NAME AS EVENTNAME, CONCAT_WS(',' , EVENT.STARTDATE, EVENT.ENDDATE ) AS EVENTDATE, SPORT.NAME AS SPORTNAME, TEAM.NAME AS TEAMNAME, RESULT.QUANTITY AS QUANT  FROM ( SELECT ACTION.ID,  ID_TM,  ID_TI,  SUM(ACTION.QUANTITY) AS QUANTITY FROM ACTION  JOIN (TIME, EVENT) ON (EVENT.ID = TIME.ID_EVENT AND TIME.ID=ACTION.ID_TI) GROUP BY ID_TM , TIME.ID_EVENT) AS RESULT JOIN (EVENT, EVENT_SPO, SPORT, TIME, TEAM) ON (EVENT.ID = EVENT_SPO.ID_EVENT AND EVENT_SPO.ID_SPO = SPORT.ID AND EVENT.ID = TIME.ID_EVENT AND TIME.ID = RESULT.ID_TI AND RESULT.ID_TM = TEAM.ID) WHERE EVENT.ID=@Id AND SPORT.ID=@Sport GROUP BY RESULT.ID_TM ORDER BY EVENT.ENDDATE";
            this.command.Parameters.AddWithValue("@Id" ,i);
            this.command.Parameters.AddWithValue("@Sport", s);
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
        public DataTable PopulateMainAsTimed(int i, int s)
        {
            this.command.CommandText = $"SELECT DISTINCT RESULT.CAT AS CATEGORY ,RESULT.ID_TM AS IDTEAM, EVENT.ID AS IDEV, EVENT.NAME AS EVENTNAME, CONCAT_WS(',' , EVENT.STARTDATE, EVENT.ENDDATE ) AS EVENTDATE, EVENT.STARTDATE AS START, SPORT.NAME AS SPORTNAME, TEAM.NAME AS TEAMNAME, RESULT.QUANTITY AS QUANT  FROM ( SELECT ACTION.ID,  ID_TM,  ID_TI,  SUM(ACTION.QUANTITY) AS QUANTITY, ACTION.CAT AS CAT, ACTION.TIME AS FINISHTIME FROM ACTION  JOIN (TIME, EVENT) ON (EVENT.ID = TIME.ID_EVENT AND TIME.ID=ACTION.ID_TI) GROUP BY ID_TM , TIME.ID_EVENT) AS RESULT JOIN (EVENT, EVENT_SPO, SPORT, TIME, TEAM) ON (EVENT.ID = EVENT_SPO.ID_EVENT AND EVENT_SPO.ID_SPO = SPORT.ID AND EVENT.ID = TIME.ID_EVENT AND TIME.ID = RESULT.ID_TI AND RESULT.ID_TM = TEAM.ID) WHERE EVENT.ID=@ID AND SPORT.ID=@SPORT GROUP BY RESULT.ID_TM ORDER BY EVENT.ENDDATE";
            this.command.Parameters.AddWithValue("@Id", i);
            this.command.Parameters.AddWithValue("@Sport", s);
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
