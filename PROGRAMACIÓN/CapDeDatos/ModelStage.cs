using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelStage : Model
    {
        public int ID;
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
            this.command.CommandText = $"Select STAGE.* FROM EVENT WHERE ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = int.Parse(this.dataReader["ID"].ToString());
            this.City = this.dataReader["CITY"].ToString();
            this.Country = this.dataReader["COUNTRY"].ToString();
            this.Street = this.dataReader["STREET"].ToString();
            this.Num = Int32.Parse(this.dataReader["NUM"].ToString());
            this.State = this.dataReader["STATE"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetStageDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM STAGE";
            tabla.Load(command.ExecuteReader());
            conection.Close();
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
                command.CommandText = "INSERT INTO " +
                  "STAGE(CITY,STREET,NUM,STATE,COUNTRY) " +
                  $"VALUES ('{City}','{Street}',{Num},'{State}','{Country}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void Update()
        {
            this.command.CommandText = "UPDATE STAGE SET " +
                 $"CITY = '{City}'," +
                 $"STREET = '{Street}'," +
                 $"NUM = {Num}," +
                 $"STATE = '{State}'," +
                 $"COUNTRY = '{Country}'," +
                 $"WHERE ID = {this.ID}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();


        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE Stage.* FROM Stage WHERE ID = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

