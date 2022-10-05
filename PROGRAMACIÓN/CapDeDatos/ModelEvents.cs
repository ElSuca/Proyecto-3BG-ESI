using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelEvents : Model
    {
        public int ID;
        public string EventName;
        public string Date;
        public string PreEvent;

        public ModelEvents()
        {
        }
        public ModelEvents(int id) => this.GetEventData(id);


        public void GetEventData(int id)
        {
            this.command.CommandText = $"Select * FROM event where event.ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = int.Parse(this.dataReader["ID"].ToString());
            this.EventName = this.dataReader["NAME"].ToString();
            this.Date = this.dataReader["DATE"].ToString();
            this.PreEvent = this.dataReader["PRE_EVENT"].ToString();
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
            else Insert();
        }

        private void Insert()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "event (Name,Date,Pre_Event) " +
                   $"VALUES (@EventName,@Date,@PreEvent)";
                this.command.Parameters.AddWithValue("@EventName", this.EventName);
                this.command.Parameters.AddWithValue("@Date", this.Date);
                this.command.Parameters.AddWithValue("@PreEvent", this.PreEvent);
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
            this.command.CommandText = "UPDATE user SET " +
                "EventName = @EventName," +
                "Date = @Date," +
                "PreEvent = @PreEvent," +
                 "WHERE ID = @ID";
            this.command.Parameters.AddWithValue("@EventName", this.EventName);
            this.command.Parameters.AddWithValue("@Date", this.Date);
            this.command.Parameters.AddWithValue("@PreEvent", this.PreEvent);
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"delete event.* from event where Id= {Id}";
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
