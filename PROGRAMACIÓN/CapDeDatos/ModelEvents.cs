using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelEvents : Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int StageId { get; set; }
        public string Type { get; set; }
        public int ParentId { get; set; }
        public string Info { get; set; }

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
            this.Name = this.dataReader["NAME"].ToString();
            this.StartDate = this.dataReader["STARTDATE"].ToString();
            this.EndDate = this.dataReader["ENDDATE"].ToString();
            this.StageId = Int32.Parse(this.dataReader["STAGE"].ToString());
            this.dataReader.Close();
        }
        public DataTable GetEventDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT EVENT.*,PRE_EVENT.ID_PARENT, PRE_EVENT.TYPE,PRE_EVENT.INFO FROM EVENT LEFT JOIN PRE_EVENT on PRE_EVENT.ID_CHILD = EVENT.ID"; 
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
                   "EVENT (NAME,STARTDATE,ENDDATE,STAGE) " +
                   $"VALUES ('{Name}','{StartDate}','{EndDate}',{StageId})";
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
           this.command.CommandText = "UPDATE EVENT SET " +
                $"NAME = '{Name}'," +
                $"STARTDATE = '{StartDate}'," +
                $"ENDDATE = '{EndDate}'," +
                $"STAGE = {StageId}" +
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

        public void InsertParents()
        {
            try
            {
                command.CommandText = "INSERT " +
                   "PRE_EVENT (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({ID},{ParentId},'{Type}','{Info}')";
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
