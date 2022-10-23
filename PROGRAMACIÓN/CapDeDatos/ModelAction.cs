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
            try
            {
                this.Command.CommandText = $"Select * FROM ACTION WHERE ID={id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = Int32.Parse(this.DataReader["ID"].ToString());
                this.IdTeam = Int32.Parse(this.DataReader["ID_TM"].ToString());
                this.IdTime = Int32.Parse(this.DataReader["ID_TI"].ToString());
                this.IdPlayer = Int32.Parse(this.DataReader["ID_PLYR"].ToString());
                this.Quantity = Int32.Parse(this.DataReader["QUANTITY"].ToString());
                this.Type = this.DataReader["TYPE"].ToString();
                this.Context = this.DataReader["CONTEXT"].ToString();
                this.Category = this.DataReader["CAT"].ToString();
                this.Time = this.DataReader["Time"].ToString();
                this.DataReader.Close();
            }
            catch (Exception e)
            {

            }
        }
        public DataTable GetActionDataTable()
        {
            try
            {
                DataTable tabla = new DataTable();

                Command.CommandText = "SELECT * from ACTION";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else Insert();
        }
        private void Insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "ACTION (ID_TM,ID_TI,ID_PLYR,QUANTITY,TYPE,CONTEXT,CAT,Time) " +
                   $"VALUES ({IdTeam},{IdTime},{IdPlayer},{Quantity},'{Type}','{Context}','{Category}','{Time}')";
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
            try
            {
                this.Command.CommandText = "UPDATE ACTION SET " +
                     $"ID_TM = {IdTeam}," +
                     $"ID_TI = {IdTime}," +
                     $"ID_PLYR = {IdPlayer}," +
                     $"QUANTITY = {Quantity}," +
                     $"TYPE = '{Type}'," +
                     $"CONTEXT = '{Context}'," +
                     $"CAT = '{Category}'," +
                     $"Time = '{Time}' " +
                     $"WHERE ID = {this.Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE ACTION.* FROM ACTION WHERE ID = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();   
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
                this.Command.CommandText = $"SELECT ID FROM ACTION WHERE CAT = '{Category}'";
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
        public bool ExistAction(int id)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM ACTION WHERE Id = {id}";
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
            string Type;
            try
            {
                this.Command.CommandText = $"SELECT* from ACTION where ID = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Type = this.DataReader["TYPE"].ToString();
                this.DataReader.Close();
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
