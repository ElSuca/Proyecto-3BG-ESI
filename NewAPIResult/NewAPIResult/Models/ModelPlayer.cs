using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewAPIResult
{
    public class ModelPlayer : Model
    {
        public int? Id ;
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? IdAsoc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? IdMana { get; set; }
        public int? IdTeam { get; set; }


        public ModelPlayer() : base()
        {
            base.connectDataBase();
        }
        public DataTable PopulatePlayer(int i)
        {
            this.command.CommandText = "SELECT PLAYER.*,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.ID <= @Id AND PLAYER.ID >=@I";
            this.command.Parameters.AddWithValue( "@Id", i*5);
            this.command.Parameters.AddWithValue("@I", ((i-1)*5) +1);
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
        public DataTable PopulatePlayer(string s)
        {
            this.command.CommandText = "SELECT PLAYER.*,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.NAME=@S OR PLAYER.LNAME1=@S OR PLAYER.LNAME2=@S";
            this.command.Parameters.AddWithValue("@S", s);
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
        public DataTable PopulatePlayerById(int i)
        {
            this.command.CommandText = "SELECT PLAYER.* ,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.ID = @Id";
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

