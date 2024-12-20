﻿using CapaDeDatos;
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
        public int? Id;
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
           // base.connectDataBase();
        }
        public Dictionary<int, PlayerTemp> PopulatePlayer(int i)
        {
            Dictionary<int, PlayerTemp> playertemp = new Dictionary<int, PlayerTemp>();
            this.Command.CommandText = "SELECT DISTINCT PLAYER.*,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.ID <= @Id AND PLAYER.ID >=@I";
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
                PlayerTemp u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : PlayerTemp.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }
        public Dictionary<int, PlayerTemp> PopulatePlayer(string s)
        {
            Dictionary<int, PlayerTemp> playertemp = new Dictionary<int, PlayerTemp>();
            this.Command.CommandText = "SELECT DISTINCT PLAYER.*,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.NAME=@S OR PLAYER.LNAME1=@S OR PLAYER.LNAME2=@S";
            this.Command.Parameters.AddWithValue("@S", s);
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
                PlayerTemp u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : PlayerTemp.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }
        public Dictionary<int, PlayerTemp> PopulatePlayerById(int i)
        {
            Dictionary<int, PlayerTemp> playertemp = new Dictionary<int, PlayerTemp>();
            this.Command.CommandText = "SELECT DISTINCT PLAYER.* ,ASOC_PLYR.ID_ASOC, " +
                "CONCAT_WS(',', ASOC_PLYR.STARTDATE ,ASOC_PLYR.ENDDATE) AS PARTDATE, ID_MANA AS MANAGER, " +
                "ID_TEAM AS TEAM FROM " +
                "PLAYER LEFT JOIN ASOC_PLYR ON PLAYER.ID = ASOC_PLYR.ID_PLYR  " +
                "LEFT JOIN PLYR_TI ON PLAYER.ID=PLYR_TI.ID_PLYR  " +
                "LEFT JOIN MANA_PLYR ON PLAYER.ID=MANA_PLYR.ID_PLYR  " +
                " WHERE PLAYER.ID = @Id";
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
                PlayerTemp u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : PlayerTemp.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }
    }
    public class PlayerTemp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Lname2 { get; set; }
        public string Status { get; set; }
        public string Birthdate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public List<int?> Id_Asoc { get; set; }
        public List<string> Times_Asoc { get; set; }
        public List<int?> Id_Team { get; set; }
        public List<int?> Id_Mana { get; set; }

        public static PlayerTemp FromRow(DataRow r)
        {
            PlayerTemp t = new PlayerTemp();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.Lname = r["LNAME1"].ToString();
            t.Lname2 = r["Lname2"].ToString();
            t.City = r["City"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.Id_Asoc = new List<int?>();
            t.Id_Mana = new List<int?>();
            t.Id_Team = new List<int?>();
            t.Times_Asoc = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Asoc.Add(ParseInt(r["Id_Asoc"].ToString()));
            this.Id_Team.Add(ParseInt(r["TEAM"].ToString()));
            this.Id_Mana.Add(ParseInt(r["MANAGER"].ToString()));
            this.Times_Asoc.Add((r["Partdate"].ToString()));

        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}

