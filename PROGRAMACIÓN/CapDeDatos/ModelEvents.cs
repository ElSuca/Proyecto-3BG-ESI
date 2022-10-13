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
        public int EventNum;

        public ModelEvents()
        {
        }
        public ModelEvents(int id) => this.GetEventData(id);


        public void GetEventData(int id)
        {
            this.command.CommandText = $"Select * FROM event ID={id}";
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
                   "event (Name,Date) " +
                   $"VALUES ('{EventName}','{EventDate}')";
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
         /*   this.command.CommandText = "UPDATE user SET " +
                "EventName = @EventName," +
                "Date = @Date," +
                "PreEvent = @PreEvent," +
                 "WHERE ID = @ID";
            this.command.Parameters.AddWithValue("@EventName", this.EventName);
            this.command.Parameters.AddWithValue("@Date", this.Date);
            this.command.Parameters.AddWithValue("@PreEvent", this.PreEvent);
            this.command.Prepare();
            this.command.ExecuteNonQuery();*/

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"delete * from EVENT where Id= {Id}";
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
