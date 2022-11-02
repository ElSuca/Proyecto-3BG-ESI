using ApiResults;
using System;
using System.Data;

namespace ApiResults
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
                command.CommandText = "INSERT " +
                   "FAMILY (NAME,RECURRENCY,DOMAIN,TYPE) " +
                   $"VALUES ('{Name}','{Recurrency}','{Domain}','{Type}')";
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
            this.command.CommandText = "UPDATE FAMILY SET " +
                 $"NAME = '{Name}'," +
                 $"RECURRENCY = '{Recurrency}'," +
                 $"DOMAIN = '{Domain}'," +
                 $"Type = '{Type}'," +
                 $"WHERE ID = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"Delete PRE_FAMILY.* from FAMILY where ID_CHILD = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
                this.command.CommandText = $"Delete FAMILY.* from FAMILY where Id= {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetFamilyData(int id)
        {
            this.command.CommandText = $"Select * From FAMILY LEFT JOIN PRE_FAMILY ON (FAMILY.ID = PRE_FAMILY.ID_CHILD OR FAMILY.ID = PRE_FAMILY.ID_PARENT) where ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["NAME"].ToString();
            this.Recurrency = this.dataReader["RECURRENCY"].ToString();
            this.Domain = this.dataReader["DOMAIN"].ToString();
            this.Type = this.dataReader["TYPE"].ToString();
            this.dataReader.Close();
        }
        public DataTable GetFamilyDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT FAMILY.*, PRE_FAMILY.ID_PARENT, PRE_FAMILY.TYPE,PRE_FAMILY.INFO FROM FAMILY LEFT JOIN PRE_FAMILY on PRE_FAMILY.ID_CHILD = FAMILY.ID";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }


        private void InsertParents()
        {
            try
            {
                command.CommandText = "INSERT " +
                   "PRE_FAMILY (ID_CHILD,ID_PARENT ,TYPE ,INFO ) " +
                   $"VALUES ({Id},{ParentId},'{Type}','{Info}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void UpdateParents()
        {
            this.command.CommandText = "UPDATE PRE_FAMILY SET " +
                 $"ID_CHILD = {Id}," +
                 $"ID_PARENT = {ParentId}," +
                 $"TYPE = '{Type}'," +
                 $"INFO = '{Info}'" +
                 $"WHERE ID_CHILD = {this.Id} AND ID_PARENT = {ParentId}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();     
        }
        public void DeleteParents(int Id)
        {
            try
            {
                this.command.CommandText = $"Delete FAMILY.* from PRE_FAMILY where ID_CHILD = {this.Id} AND ID_PARENT = {ParentId}";
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

