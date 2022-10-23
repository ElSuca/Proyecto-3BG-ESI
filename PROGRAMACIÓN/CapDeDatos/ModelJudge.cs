using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelJudge : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastaName1 { get; set; }
        public string LastaName2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public ModelJudge() { }
        public ModelJudge(int id) => this.GetJudgeData(id);

        public void GetJudgeData(int id)
        {
            this.Command.CommandText = $"Select JUDGE.* FROM JUDGE WHERE ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["ID"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.LastaName1 = this.DataReader["LNAME1"].ToString();
            this.LastaName2 = this.DataReader["LNAME2"].ToString();
            this.Country = this.DataReader["COUNTRY"].ToString();
            this.State = this.DataReader["STATE"].ToString();
            this.City = this.DataReader["CITY"].ToString();
            this.DataReader.Close();
        }

        public DataTable GetJudgeDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT * FROM JUDGE";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else insertJudge();
            
        }








        void insertJudge()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "JUDGE (NAME,LNAME1,LNAME2,COUNTRY,STATE,CITY) " +
                   $"VALUES ('{Name}','{LastaName1}','{LastaName2}','{Country}','{State}','{City}')";
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
            this.Command.CommandText = "UPDATE JUDGE SET " +
                 $"NAME = '{Name}'," +
                 $"LNAME1 = '{LastaName1}'," +
                 $"LNAME2 = '{LastaName2}'," +
                 $"COUNTRY = '{Country}'," +
                 $"STATE = '{State}'," +
                 $"CITY = '{City}'" +
                 $"WHERE ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE JUDGE.* FROM JUDGE WHERE ID = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExistJudge(string name)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM JUDGE WHERE NAME = '{name}'";
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
                this.Command.CommandText = $"SELECT * FROM JUDGE WHERE Id = {id}";
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
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM JUDGE WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["ID"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
