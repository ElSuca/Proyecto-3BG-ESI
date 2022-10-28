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
            try
            {
                this.Command.CommandText = $"Select EVENT.* FROM EVENT WHERE ID={id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["ID"].ToString());
                this.Name = this.DataReader["NAME"].ToString();
                this.StartDate = this.DataReader["STARTDATE"].ToString();
                this.EndDate = this.DataReader["ENDDATE"].ToString();
                this.StageId = Int32.Parse(this.DataReader["STAGE"].ToString());
                this.DataReader.Close();
            }
            catch(Exception e)
            {

            }
        }
        public DataTable GetEventDataTable()
        {
            try
            {
                DataTable tabla = new DataTable();

                Command.CommandText = "SELECT EVENT.*," +
                    "TIME.ID,TIME.NUM," +
                    "TIME.DESCR " +
                    "FROM EVENT JOIN TIME " +
                    "on EVENT.ID = TIME.ID_EVENT";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                RenameTableEvent(tabla);
                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public DataTable GetEventDataTableWithFamily()
        {
            try
            {
                DataTable tabla = new DataTable();

                Command.CommandText = "SELECT EVENT.*," +
                    "PRE_EVENT.ID_CHILD," +
                    " PRE_EVENT.TYPE," +
                    "PRE_EVENT.INFO," +
                    "TIME.ID,TIME.NUM," +
                    "TIME.DESCR " +
                    "FROM EVENT JOIN PRE_EVENT JOIN TIME " +
                    "on PRE_EVENT.ID_PARENT = EVENT.ID and EVENT.ID = TIME.ID_EVENT";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                RenameTableEventFamily(tabla);

                return tabla;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void Save()
        {
            if (this.ID.ToString() != "0") Update();
            else
            {
                insert();
                InsertTime();
                
            }
        }
        public void SaveParents()
        {
            if (this.ID.ToString() != "0") Update();
            else InsertParents();
        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "EVENT (NAME,STARTDATE,ENDDATE,STAGE) " +
                   $"VALUES ('{Name}','{StartDate}','{EndDate}',{StageId})";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
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
                Command.CommandText = "INSERT INTO " +
                   "PRE_EVENT (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({GetId(Name)},{ParentId},'{Type}','{Info}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertTime()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "TIME (ID_EVENT,NUM,DESCR) " +
                   $"VALUES ('{GetId(Name)}',{TimeNumber},'{TimeDescription}')";
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
                this.Command.CommandText = "UPDATE EVENT SET " +
                     $"NAME = '{Name}'," +
                     $"STARTDATE = '{StartDate}'," +
                     $"ENDDATE = '{EndDate}'," +
                     $"STAGE = {StageId} " +
                     $"WHERE ID = {this.ID}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch(Exception e)
            {

            }
        }
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM EVENT WHERE NAME = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
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
                this.Command.CommandText = $"DELETE PRE_EVENT.* FROM PRE_EVENT WHERE ID_PARENT = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE TIME.* FROM TIME WHERE ID_EVENT = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE EVENT.* FROM EVENT WHERE ID = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable RenameTableEvent(DataTable t)
        {
            t.Columns[1].ColumnName = "Name";
            t.Columns[2].ColumnName = "Start Date";
            t.Columns[3].ColumnName = "End Date";
            t.Columns[4].ColumnName = "Stage";
            t.Columns[5].ColumnName = "Time ID";
            t.Columns[6].ColumnName = "Time Number";
            t.Columns[7].ColumnName = "Time Description";
            return t;
        }
        public DataTable RenameTableEventFamily(DataTable t)
        {
            t.Columns[0].ColumnName = "ID";
            t.Columns[1].ColumnName = "Name";
            t.Columns[2].ColumnName = "Start Date";
            t.Columns[3].ColumnName = "End Date";
            t.Columns[4].ColumnName = "Stage";
            t.Columns[5].ColumnName = "Time ID";
            t.Columns[6].ColumnName = "Time Number";
            t.Columns[7].ColumnName = "Time Description";
            t.Columns[8].ColumnName = "ID Chirld";
            t.Columns[9].ColumnName = "Number";
            t.Columns[10].ColumnName = "Description";
            return t;
        }
        public int GetIdTime(int num)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM TIME WHERE num = '{num}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.ID = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public bool ExistEvent(string name)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM EVENT WHERE NAME = '{name}'";
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
            string Check;
            try
            {
                this.Command.CommandText = $"SELECT * FROM EVENT WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["STARTDATE"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "27/10/2022 0:00:00") return true;
            else return false;
        }    
        public void GetEventBySport(string sport)
        {

        }
    }
}
