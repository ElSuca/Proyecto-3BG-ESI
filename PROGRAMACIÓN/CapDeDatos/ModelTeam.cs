using CapaDeDatos;
using System;
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
    }
}
