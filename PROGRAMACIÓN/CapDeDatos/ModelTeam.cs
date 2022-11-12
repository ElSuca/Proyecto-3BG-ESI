using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapDeDatos
{
    public class ModelTeam : Model
    {
        public int Id;
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int IdAsociation { get; set;}

        public List<int?> Id_Asoc { get; set; }
        public List<int?> Id_Time { get; set; }
        public List<int?> Id_Plyr { get; set; }
        public List<int?> Id_Mana { get; set; }
        public List<int?> Id_Spo { get; set; }

        public ModelTeam(int id) => this.GetTeamData(id);
        public ModelTeam()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else
            {
                if (IdAsociation == 0) insert();
                else
                {
                    insert();
                    insertWithAsociation();
                }
            }
        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "TEAM (Name,City,Country,State) " +
                   $"VALUES ('{Name}','{City}','{Country}','{State}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void insertWithAsociation()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "TM_ASOC (ID_TEAM ,ID_ASOC) " +
                   $"VALUES ({GetId(Name)},{IdAsociation})";
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
                this.Command.CommandText = "UPDATE TEAM SET " +
                     $"NAME = '{Name}'," +
                     $"CITY = '{City}'," +
                     $"COUNTRY = '{Country}'," +
                     $"STATE = '{State}'" +
                     $"WHERE ID = {this.Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete TEAM.* from TEAM where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetTeamData(int id)
        {
            this.Command.CommandText = $"Select * From TEAM where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.City = this.DataReader["CITY"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();
            this.State = this.DataReader["STATE"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetTeamDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT * FROM TEAM LEFT JOIN TM_ASOC ON TEAM.ID = TM_ASOC.ID_TEAM;";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }
        public bool ExistTeam(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM TEAM WHERE Id = {id}";
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
            string City;
            try
            {
                this.Command.CommandText = $"SELECT * FROM TEAM WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                City = this.DataReader["CITY"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (City == "n") return true;
            else return false;
        }
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM TEAM WHERE NAME = '{Name}'";
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
        public string GetName(int id)
        {
            try
            {
                this.Command.CommandText = $"SELECT NAME FROM TEAM WHERE ID = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Name = this.DataReader["NAME"].ToString();
                this.DataReader.Close();
                return Name;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public Dictionary<int, ModelTeam> PopulateTeamByPage(int i)
        {
            Dictionary<int, ModelTeam> teamtemp = new Dictionary<int, ModelTeam>();
            this.Command.CommandText = "SELECT DISTINCT TEAM.*, " +
 "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
 "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO " +
 "FROM TEAM LEFT JOIN PLYR_TI ON PLYR_TI.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_ASOC ON TEAM.ID=TM_ASOC.ID_ASOC " +
 "LEFT JOIN MANA_TEAM ON MANA_TEAM.ID_TEAM=TEAM.ID " +
 "LEFT JOIN TM_SPO ON TM_SPO.ID_TEAM=TEAM.ID " +
 " WHERE TEAM.ID<=@Id AND TEAM.ID>=@I ";
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
                ModelTeam u = teamtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? teamtemp[int.Parse(row["ID"].ToString())] : ModelTeam.FromRow(row);
                u.AddIds(row);
                teamtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return teamtemp;
        }
        public Dictionary<int, ModelTeam> PopulateTeamById(int i)
        {
            Dictionary<int, ModelTeam> teamtemp = new Dictionary<int, ModelTeam>();

            this.Command.CommandText = "SELECT DISTINCT TEAM.*, " +
                "TM_ASOC.ID_ASOC, PLYR_TI.ID_TIME, PLYR_TI.ID_PLYR, " +
                "MANA_TEAM.ID_MANA, TM_SPO.ID_SPO " +
                "FROM TEAM LEFT JOIN PLYR_TI ON PLYR_TI.ID_TEAM=TEAM.ID " +
                "LEFT JOIN TM_ASOC ON TEAM.ID=TM_ASOC.ID_ASOC " +
                "LEFT JOIN MANA_TEAM ON MANA_TEAM.ID_TEAM=TEAM.ID " +
                "LEFT JOIN TM_SPO ON TM_SPO.ID_TEAM=TEAM.ID " +
                "  WHERE TEAM.ID=@Id";
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
                ModelTeam u = teamtemp.ContainsKey(int.Parse(row["ID"].ToString())) ? teamtemp[int.Parse(row["ID"].ToString())]
                  : ModelTeam.FromRow(row);
                u.AddIds(row);
                teamtemp[int.Parse(row["Id"].ToString())] = u;
            }
            return teamtemp;
        }
        public static ModelTeam FromRow(DataRow r)
        {
            ModelTeam t = new ModelTeam();
            t.Id = int.Parse(r["Id"].ToString());
            t.Name = r["Name"].ToString();
            t.City = r["City"].ToString();
            t.State = r["State"].ToString();
            t.Country = r["Country"].ToString();
            t.Id_Asoc = new List<int?>();
            t.Id_Time = new List<int?>();
            t.Id_Plyr = new List<int?>();
            t.Id_Mana = new List<int?>();
            t.Id_Spo = new List<int?>();
            t.AddIds(r);
            return t;
        }
        public void AddIds(DataRow r)
        {
            this.Id_Asoc.Add(ParseInt(r["Id_Asoc"].ToString()));
            this.Id_Time.Add(ParseInt(r["Id_Time"].ToString()));
            this.Id_Plyr.Add(ParseInt(r["Id_Plyr"].ToString()));
            this.Id_Mana.Add(ParseInt(r["Id_Mana"].ToString()));
            this.Id_Spo.Add(ParseInt(r["Id_Spo"].ToString()));

        }
        static int? ParseInt(string s)
        {
            if (int.TryParse(s, out int res)) return res;
            return null;
        }
    }
}
