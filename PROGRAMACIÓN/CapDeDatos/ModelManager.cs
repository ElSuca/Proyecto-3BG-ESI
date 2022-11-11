using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapDeDatos
{
    public class ModelManager : Model
    {
        public int Id;
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int IdAsociation { get; set; }
        public string StartDateAsociation { get; set; }
        public string EndDateAsociation { get; set; }


        public List<int?> Id_Asoc { get; set; }
        public List<string> Times_Asoc { get; set; }
        public List<int?> Id_Team { get; set; }
        public List<int?> Id_Plyr { get; set; }
        public List<int?> Id_Spo { get; set; }

       

        public ModelManager(int id) => this.GetManagerData(id);
        public ModelManager()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else
            {
                insert();
                insertManagerAsociation();
            }

        }
        void insert()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "MANAGER (NAME,LNAME1,LNAME2,STATUS,BIRTHDATE,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName1}','{LastName2}','{Status}','{BirthDate}','{State}','{Country}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void insertManagerAsociation()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "MANA_ASOC (ID_MANA ,ID_ASOC,STARTDATE,ENDDATE) " +
                   $"VALUES ({GetId(Name)},{IdAsociation},'{StartDateAsociation}','{EndDateAsociation}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM MANAGER WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["ID"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string GetNameByTeam(int idTeam)
        {
            this.Command.CommandText = $"SELECT NAME FROM MANAGER join MANA_TEAM on MANAGER.ID = MANA_TEAM.ID_MANA WHERE MANA_TEAM.ID_TEAM  = '{idTeam}'";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Name =this.DataReader["NAME"].ToString();
            this.DataReader.Close();
            return Name;
        }
        private void Update()
        {
            this.Command.CommandText = "UPDATE MANAGER SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastName1}'," +
                 $"LNAME2 = '{LastName2}'," +
                 $"STATUS = '{Status}'," +
                 $"BIRTHDATE = '{BirthDate}'," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}'" +
                 $"WHERE ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete MANA_ASOC.* from MANA_ASOC where ID_MANA= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"Delete MANAGER.* from MANAGER where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetManagerData(int id)
        {
            this.Command.CommandText = $"Select * From MANAGER where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.LastName1 = this.DataReader["LNAME1"].ToString();
            this.LastName2 = this.DataReader["LNAME2"].ToString();
            this.Status = this.DataReader["STATUS"].ToString();
            this.BirthDate = this.DataReader["BIRTHDATE"].ToString();
            this.State = this.DataReader["STATE"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetManagerDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT MANAGER.*,MANA_ASOC.ID_ASOC,MANA_ASOC.STARTDATE,MANA_ASOC.ENDDATE FROM MANAGER LEFT JOIN MANA_ASOC ON MANAGER.ID = MANA_ASOC.ID_MANA";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }
        public bool ExistManager(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM MANAGER WHERE Id = {id}";
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
            string Check;
            try
            {
                this.Command.CommandText = $"SELECT MANAGER.*,MANA_ASOC.ID_ASOC,MANA_ASOC.STARTDATE,MANA_ASOC.ENDDATE FROM MANAGER LEFT JOIN MANA_ASOC ON MANAGER.ID = MANA_ASOC.ID_MANA where MANAGER.ID = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["STATE"].ToString();
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "n") return true;
            else return false;
        }
        public Dictionary<int, ModelManager> PopulateManagerByPage(int i)
        {
            Dictionary<int, ModelManager> manatemp = new Dictionary<int, ModelManager>();
            this.Command.CommandText = "SELECT DISTINCT MANAGER.*, " +
                "CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES ," +
                "MANA_ASOC.ID_ASOC AS ASOC, " +
                "MANA_TEAM.ID_TEAM AS TEAM , " +
                "MANA_PLYR.ID_PLYR AS PLAYER, " +
                "MANA_SPO.ID_SPO AS SPORT " +
                "FROM MANAGER " +
                "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA " +
                "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
                "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
                "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA" +
                " WHERE MANAGER.ID<=@Id AND MANAGER.ID>=@I ";
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
                ModelManager u = manatemp.ContainsKey(int.Parse(row["ID"].ToString())) ? manatemp[int.Parse(row["ID"].ToString())]
                  : ModelManager.FromRow(row);
                u.AddIds(row);
                manatemp[int.Parse(row["Id"].ToString())] = u;
            }
            return manatemp;
        }
        public Dictionary<int, ModelManager> PopulateManagerById(int i)
        {
            Dictionary<int, ModelManager> manatemp = new Dictionary<int, ModelManager>();
            this.Command.CommandText = "SELECT DISTINCT MANAGER.*, " +
                "CONCAT_WS(', ',MANA_ASOC.STARTDATE, MANA_ASOC.ENDDATE) AS DATES , " +
                "MANA_ASOC.ID_ASOC AS ASOC, MANA_TEAM.ID_TEAM AS TEAM ,  " +
                "MANA_PLYR.ID_PLYR AS PLAYER, MANA_SPO.ID_SPO AS SPORT  " +
                "FROM MANAGER  " +
                "LEFT JOIN MANA_ASOC ON MANAGER.ID=MANA_ASOC.ID_MANA  " +
                "LEFT JOIN MANA_PLYR ON MANAGER.ID=MANA_PLYR.ID_MANA  " +
                "LEFT JOIN MANA_TEAM ON MANAGER.ID=MANA_TEAM.ID_MANA  " +
                "LEFT JOIN MANA_SPO ON MANAGER.ID=MANA_SPO.ID_MANA " +
                " WHERE MANAGER.ID=@Id";
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
                ModelManager u = manatemp.ContainsKey(int.Parse(row["ID"].ToString())) ? manatemp[int.Parse(row["ID"].ToString())]
                  : ModelManager.FromRow(row);
                u.AddIds(row);
                manatemp[int.Parse(row["Id"].ToString())] = u;
            }
            return manatemp;
        }


        public static ModelManager FromRow(DataRow r)
        {
            ModelManager t = new ModelManager();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.LastName1 = r["Lname1"].ToString();
            t.LastName2 = r["Lname2"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.Id_Asoc = new List<int?>();
            t.Id_Plyr = new List<int?>();
            t.Id_Spo = new List<int?>();
            t.Id_Team = new List<int?>();
            t.Times_Asoc = new List<string>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Asoc.Add(ParseInt(r["ASOC"].ToString()));
            this.Id_Team.Add(ParseInt(r["TEAM"].ToString()));
            this.Id_Plyr.Add(ParseInt(r["PLAYER"].ToString()));
            this.Id_Spo.Add(ParseInt(r["SPORT"].ToString()));
            this.Times_Asoc.Add((r["Dates"].ToString()));
        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }

    }
}

