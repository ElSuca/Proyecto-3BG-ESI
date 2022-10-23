using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDeDatos
{
    public class ModelAction : Model
    {
        public int Id { get; set; }
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
            this.Id = Int32.Parse(this.dataReader["ID"].ToString());
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
            if (this.Id.ToString() != "0") Update();
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
                 $"Time = '{Time}' " +
                 $"WHERE ID = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE ACTION.* FROM ACTION WHERE ID = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();   
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetId(string Category)
        {
            try
            {
                this.command.CommandText = $"SELECT ID FROM ACTION WHERE CAT = '{Category}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["ID"].ToString());
                this.dataReader.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public bool ExistAction(int id)
        {
            bool exist;
            try
            {
                this.command.CommandText = $"SELECT * FROM ACTION WHERE Id = {id}";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                exist = this.dataReader.HasRows;
                this.dataReader.Close();
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
            string Type;
            try
            {
                this.command.CommandText = $"SELECT* from ACTION where ID = {id}";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                Type = this.dataReader["TYPE"].ToString();
                this.dataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Type == "n") return true;
            else return false;
        }
    }
}
