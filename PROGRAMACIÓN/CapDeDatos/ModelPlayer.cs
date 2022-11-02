using CapaDeDatos;
using System;
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
        public int IdAsoc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public ModelPlayer(int id) => this.GetPlayerData(id);
        public ModelPlayer()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else insert();
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
                   $"VALUES ({IdAsoc},{Id},'{StartDate}','{EndDate}')";
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
        public int GetId(string Username)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM PLAYER WHERE NAME = '{Username}'";
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
    }
}

