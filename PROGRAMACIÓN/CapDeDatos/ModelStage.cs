using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelStage : Model
    {
        public int ID;
        public string Name;
        public string City;
        public string Street;
        public int Num;
        public string State;
        public string Country;

        public ModelStage()
        {
        }
        public ModelStage(int id) => this.GetStageData(id);


        public void GetStageData(int id)
        {
            this.Command.CommandText = $"Select STAGE.* FROM STAGE WHERE ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.ID = int.Parse(this.DataReader["ID"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.City = this.DataReader["CITY"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();
            this.Street = this.DataReader["STREET"].ToString();
            this.Num = Int32.Parse(this.DataReader["NUM"].ToString());
            this.State = this.DataReader["STATE"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetStageDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT * FROM STAGE";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        public void Save()
        {
            if (this.ID.ToString() != "0") Update();
            else
            {
                Insert();
            }
        }

        private void Insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                  "STAGE(NAME,CITY,STREET,NUM,STATE,COUNTRY) " +
                  $"VALUES ('{Name}','{City}','{Street}',{Num},'{State}','{Country}')";
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
            this.Command.CommandText = "UPDATE STAGE SET " +
                 $"NAME = '{Name}',"+
                 $"CITY = '{City}'," +
                 $"STREET = '{Street}'," +
                 $"NUM = {Num}," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}'," +
                 $"WHERE ID = {this.ID}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
        }
        public void Delete  (int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE STAGE.* FROM STAGE WHERE ID = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool ExistStage(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM STAGE WHERE Id = {id}";
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
                this.Command.CommandText = $"SELECT * FROM STAGE WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["CITY"].ToString();
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "n") return true;
            else return false;
        }
        public int GetId(string Username)
        {
            int Id;
            try
            {
                this.Command.CommandText = $"SELECT ID FROM STAGE WHERE NAME = '{Username}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Id = int.Parse(this.DataReader["id"].ToString());
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

