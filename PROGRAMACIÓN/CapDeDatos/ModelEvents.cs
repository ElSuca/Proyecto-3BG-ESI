using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelEvents : Model
    {
        public int ID;
        public string EventName;
        public string EventDate;
        public string PreEvent;
        public string StageName;
        public string EventCity;
        public string EventCountry;
        public string EventStreet;
        public string EventState;
        public int EventNum;

        public ModelEvents()
        {
        }
        public ModelEvents(int id) => this.GetEventData(id);


        public void GetEventData(int id)
        {
            this.command.CommandText = $"Select EVENT.* FROM EVENT WHERE ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = int.Parse(this.dataReader["ID"].ToString());
            this.EventName = this.dataReader["NAME"].ToString();
            this.EventDate = this.dataReader["DATE"].ToString();
            this.EventCity = this.dataReader["CITY"].ToString();
            this.EventCountry = this.dataReader["COUNTRY"].ToString();
            this.EventStreet = this.dataReader["STREET"].ToString();
            this.EventNum = Int32.Parse(this.dataReader["NUM"].ToString());
            this.EventState = this.dataReader["STATE"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetEventDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM event";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

        public void Save()
        {
            if (this.ID.ToString() != "0") Update();
            else
            {
              //  insertStage();
                insertEvent();
            }
        }

        private void insertEvent()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "EVENT (name,date,city,street,num,state,country) " +
                   $"VALUES ('{EventName}','{EventDate}','{EventCity}','{EventStreet}','{EventNum}','{EventState}','{EventCountry}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
      /*  private void insertStage()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                  "STAGE(name,city,country,street,num) " +
                  $"VALUES ('{StageName}','{EventCity}','{EventCountry}','{EventStreet}',{EventNum})";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }*/
        private void Update()
        {
           this.command.CommandText = "UPDATE EVENT SET " +
                $"NAME = '{EventName}'," +
                $"DATE = '{EventDate}'," +
                $"CITY = '{EventCity}'," +
                $"STREET = '{EventStreet}'," +
                $"NUM = '{EventNum}'," +
                $"STATE = '{EventState}'," +
                $"COUNTRY = '{EventCountry}' " +
                $"WHERE ID = {this.ID}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();
            

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE EVENT.* FROM EVENT WHERE ID = {Id}";
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
