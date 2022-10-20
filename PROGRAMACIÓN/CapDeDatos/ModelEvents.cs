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
        public int TimeNumber { get; set; }
        public string TimeDescription { get; set; }

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

            command.CommandText = "SELECT EVENT.*," +
                "TIME.ID,TIME.NUM," +
                "TIME.DESCR " +
                "FROM EVENT JOIN TIME " +
                "on EVENT.ID = TIME.ID_EVENT";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
        public DataTable GetEventDataTableWithFamily()
        {
            DataTable tabla = new DataTable();
           
            command.CommandText = "SELECT EVENT.*," +
                "PRE_EVENT.ID_CHILD," +
                " PRE_EVENT.TYPE," +
                "PRE_EVENT.INFO," +
                "TIME.ID,TIME.NUM," +
                "TIME.DESCR " +
                "FROM EVENT JOIN PRE_EVENT JOIN TIME " +
                "on PRE_EVENT.ID_PARENT = EVENT.ID and EVENT.ID = TIME.ID_EVENT"; 
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
                InsertTime();
            }
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
        private void InsertTime()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "TIME (ID_EVENT,NUM,DESCR) " +
                   $"VALUES ('{GetId(Name)}',{TimeNumber},'{TimeDescription}')";
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
        public int GetId(string Name)
        {
            try
            {
                this.command.CommandText = $"SELECT ID FROM EVENT WHERE NAME = '{Name}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.ID = int.Parse(this.dataReader["id"].ToString());
                this.dataReader.Close();
                return ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE TIME.* FROM TIME WHERE ID_EVENT = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
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
                command.CommandText = "INSERT INTO " +
                   "PRE_EVENT (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({GetId(Name)},{ParentId},'{Type}','{Info}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool HaveFamily()
        {
            this.command.CommandText = $"Select EVENT.ID PRE_EVENT.ID_CHILD,PRE_EVENT.TYPE FROM EVENT JOIN PRE_EVENT on EVENT.ID = PRE_EVENT.ID_CHILD WHERE ID={ID}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Type = this.dataReader["TYPE "].ToString();
            this.dataReader.Close();

            if (Type != null) return true;
            return false;
        }
    }
}
