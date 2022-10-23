using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelFamily : Model
    {
        public int Id;
        public string Name { get; set; }
        public string Recurrency { get; set; }
        public string Domain { get; set; }
        public string Type { get; set; }
        public int ParentId { get; set; }
        public string Info { get; set; }



        public ModelFamily(int id) => this.GetFamilyData(id);
        public ModelFamily()
        {
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else insert();
        }
        public void SaveParents()
        {
          InsertParents();
        }

        private void insert()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "FAMILY (NAME,RECURRENCY,DOMAIN,TYPE) " +
                   $"VALUES ('{Name}','{Recurrency}','{Domain}','{Type}')";
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
            this.Command.CommandText = "UPDATE FAMILY SET " +
                 $"NAME = '{Name}'," +
                 $"RECURRENCY = '{Recurrency}'," +
                 $"DOMAIN = '{Domain}'," +
                 $"Type = '{Type}' " +
                 $"WHERE ID = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete PRE_FAMILY.* from PRE_FAMILY where ID_CHILD = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"Delete FAMILY.* from FAMILY where Id= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetFamilyData(int id)
        {
            this.Command.CommandText = $"Select * From FAMILY where ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.Name = this.DataReader["NAME"].ToString();
            this.Recurrency = this.DataReader["RECURRENCY"].ToString();
            this.Domain = this.DataReader["DOMAIN"].ToString();
            this.Type = this.DataReader["TYPE"].ToString();
            this.DataReader.Close();
        }
        public DataTable GetFamilyDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "SELECT FAMILY.*, PRE_FAMILY.ID_PARENT, PRE_FAMILY.TYPE,PRE_FAMILY.INFO FROM FAMILY LEFT JOIN PRE_FAMILY on PRE_FAMILY.ID_CHILD = FAMILY.ID";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        private void InsertParents()
        {
            try
            {
                Command.CommandText = "INSERT " +
                   "PRE_FAMILY (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({Id},{ParentId},'{Type}','{Info}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void UpdateParents()
        {
            this.Command.CommandText = "UPDATE PRE_FAMILY SET " +
                 $"ID_CHILD = {Id}," +
                 $"ID_PARENT = {ParentId}," +
                 $"TYPE = '{Type}'," +
                 $"INFO = '{Info}'" +
                 $"WHERE ID_CHILD = {this.Id} AND ID_PARENT = {ParentId}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();     
        }
        public void DeleteParents(int Id)
        {
            try
            {
                this.Command.CommandText = $"Delete FAMILY.* from PRE_FAMILY where ID_CHILD = {this.Id} AND ID_PARENT = {ParentId}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExistFamily(string name)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM FAMILY WHERE NAME = '{name}'";
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
                this.Command.CommandText = $"SELECT * FROM FAMILY WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["TYPE"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "n") return true;
            else return false;
        }
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM FAMILY WHERE NAME = '{Name}'";
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
    }
}

