using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapDeDatos
{
    public class ModelPlayer : Model
    {
        public int Id;
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
        public string Lname { get; set; }
        public string Lname2 { get; set; }    
        public string Birthdate { get; set; }
        public List<int?> Id_Asoc { get; set; }
        public List<string> Times_Asoc { get; set; }
        public List<int?> Id_Team { get; set; }
        public List<int?> Id_Mana { get; set; }

        public ModelPlayer(int id) => this.GetPlayerData(id);
        public ModelPlayer()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0")
            {
                if (IdAsoc == null) Update();
                else
                {
                    Update();
                    UpdateWithAsoc();
                }
            }
            else
            {
                if (IdAsoc == null)
                {
                    insert();
                }
                else
                {
                    insert();
                    InsertAsociation();
                }
            }
        }
        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "PLAYER (NAME,LNAME1,LNAME2,STATUS,BIRTHDATE,CITY,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName1}','{LastName2}','{Status}','{BirthDate}','{City}','{State}','{Country}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            try
            {
                this.Command.CommandText = "UPDATE PLAYER SET " +
                     $"NAME = '{Name}'," +
                     $"LNAME1 = '{LastName1}'," +
                     $"LNAME2 = '{LastName2}'," +
                     $"STATUS = '{Status}'," +
                     $"BIRTHDATE = '{BirthDate}'," +
                     $"CITY = '{City}'," +
                     $"STATE = '{State}'," +
                     $"COUNTRY = '{Country}'" +
                     $"WHERE ID = {this.Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }
  
        private void UpdateWithAsoc()
        {
            try
            {
                this.Command.CommandText = "UPDATE ASOC_PLYR SET " +       
                     $"ID_ASOC = '{IdAsoc}'," +
                     $"ID_PLYR = '{Id}'," +
                     $"STARTDATE = '{StartDate}'," +
                     $"ENDDATE = '{EndDate}' " +   
                     $"WHERE ID_ASOC = {this.IdAsoc}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete PLAYER.* from PLAYER where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetPlayerData(int id)
        {
            try
            {
                this.Command.CommandText = $"SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on (PLAYER.ID = ASOC_PLYR.ID_PLYR) where PLAYER.ID={id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.Name = this.DataReader["NAME"].ToString();
                this.LastName1 = this.DataReader["LNAME1"].ToString();
                this.LastName2 = this.DataReader["LNAME2"].ToString();
                this.Status = this.DataReader["STATUS"].ToString();
                this.BirthDate = this.DataReader["BIRTHDATE"].ToString();
                this.City = this.DataReader["CITY"].ToString();
                this.State = this.DataReader["STATE"].ToString();
                this.Country = this.DataReader["COUNTRY"].ToString();
                this.DataReader.Close();
            }
            catch(Exception)
            {

            }
        }
        public DataTable GetPlayerDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT PLAYER.*,ASOC_PLYR.ID_ASOC,ASOC_PLYR.STARTDATE,ASOC_PLYR.ENDDATE FROM PLAYER LEFT JOIN ASOC_PLYR on PLAYER.ID = ASOC_PLYR.ID_PLYR";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }
        public void InsertAsociation()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "ASOC_PLYR (ID_ASOC,ID_PLYR,STARTDATE ,ENDDATE) " +
                   $"VALUES ({IdAsoc},{GetId(Name)},'{StartDate}','{EndDate}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExistPlayer(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM PLAYER WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                exist = this.DataReader.HasRows;
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (exist) return true;
            else return false;
        }
        public bool HaveChange(int id)
        {
            string Name;
            try
            {
                this.Command.CommandText = $"SELECT * FROM PLAYER WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Name = this.DataReader["LNAME1"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Name == "n") return true;
            else return false;
        }
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM PLAYER WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //public DataTable GetNameByTeam(int id)
        //{
        //    DataTable tabla = new DataTable();
        //    Command.CommandText = "SELECT PLAYER.NAME FROM PLAYER LEFT JOIN ASOC_PLYR on PLAYER.ID = ASOC_PLYR.ID_PLYR";
        //    tabla.Load(Command.ExecuteReader());
        //    Conection.Close();
        //    return tabla;
        //}
        private string GetColumn(string key, string defaultValue = null)
        {
            int ordinal = this.DataReader.GetOrdinal(key);
            if (this.DataReader.IsDBNull(ordinal)) return defaultValue;
            return this.DataReader.GetString(ordinal);
        }

        private int GetColumnInt(string key)
        {
            int ordinal = this.DataReader.GetOrdinal(key);
            if (this.DataReader.IsDBNull(ordinal)) return -1;
            return this.DataReader.GetInt32(ordinal);
        }
        public DataTable GetNameByTeam(int id)
        {
            DataTable tabla = new DataTable();
            Command.CommandText = $"SELECT PLAYER.NAME FROM PLAYER JOIN TM_ASOC JOIN ASOC_PLYR JOIN TEAM on TEAM.ID = TM_ASOC.ID_TEAM and TM_ASOC.ID_ASOC = ASOC_PLYR.ID_ASOC  and ASOC_PLYR.ID_PLYR  = PLAYER.ID where TEAM.ID = {id}";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        public Dictionary<int, ModelPlayer> PopulatePlayer(int i)
        {
            Dictionary<int, ModelPlayer> playertemp = new Dictionary<int, ModelPlayer>();
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
                ModelPlayer u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : ModelPlayer.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }
        public Dictionary<int, ModelPlayer> PopulatePlayer(string s)
        {
            Dictionary<int, ModelPlayer> playertemp = new Dictionary<int, ModelPlayer>();
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
                ModelPlayer u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : ModelPlayer.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }
        public Dictionary<int, ModelPlayer> PopulatePlayerById(int i)
        {
            Dictionary<int, ModelPlayer> playertemp = new Dictionary<int, ModelPlayer>();
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
                ModelPlayer u = playertemp.ContainsKey(int.Parse(row["ID"].ToString())) ? playertemp[int.Parse(row["ID"].ToString())]
                  : ModelPlayer.FromRow(row);
                u.AddIds(row);
                playertemp[int.Parse(row["Id"].ToString())] = u;
            }
            return playertemp;
        }



        public static ModelPlayer FromRow(DataRow r)
        {
            ModelPlayer t = new ModelPlayer();
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

