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
                   "event (EventName,Date,PreEvent) " +
                   "VALUES (@EventName,@Date,@PreEvent)";
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
    }
}
