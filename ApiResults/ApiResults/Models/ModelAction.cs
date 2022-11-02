using ApiResults;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiResults
{
    public class ModelAction : Model
    {
        public int ID { get; set; }
        public int IdTeam { get; set; }
        public int IdTime { get; set; }
        public int IdPlayer { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string Context { get; set; }
        public string Category { get; set; }
        public string Time { get; set; }

        public ModelAction()
        {
        }
        public ModelAction(int id) => this.GetEventData(id);


        public void GetEventData(int id)
        {
            this.command.CommandText = $"Select * FROM ACTION WHERE ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.ID = Int32.Parse(this.dataReader["ID"].ToString());
            this.IdTeam = Int32.Parse(this.dataReader["ID_TM"].ToString());
            this.IdTime = Int32.Parse(this.dataReader["ID_TI"].ToString());
            this.IdPlayer = Int32.Parse(this.dataReader["ID_PLYR"].ToString());
            this.Quantity = Int32.Parse(this.dataReader["QUANTITY"].ToString());
            this.Type = this.dataReader["TYPE"].ToString();
            this.Context = this.dataReader["CONTEXT"].ToString();
            this.Category = this.dataReader["CAT"].ToString();
            this.Time = this.dataReader["Time"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetActionDataTable()
        {
            DataTable tabla = new DataTable();

            command.CommandText = "SELECT * from ACTION";
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
                   "ACTION (ID_TM,ID_TI,ID_PLYR,QUANTITY,TYPE,CONTEXT,CAT,Time) " +
                   $"VALUES ({IdTeam},{IdTime},{IdPlayer},{Quantity},'{Type}','{Context}','{Category}','{Time}')";
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
            this.command.CommandText = "UPDATE ACTION SET " +
                 $"ID_TM = {IdTeam}," +
                 $"ID_TI = {IdTime}," +
                 $"ID_PLYR = {IdPlayer}," +
                 $"QUANTITY = {Quantity}," +
                 $"TYPE = '{Type}'," +
                 $"CONTEXT = '{Context}'," +
                 $"CAT = '{Category}'," +
                 $"Time = '{Time}'" +
                 $"WHERE ID = {this.ID}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE * FROM ACTION WHERE ID = {Id}";
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
