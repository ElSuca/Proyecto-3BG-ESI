using CapaDeDatos;
using System;
using System.Data;

namespace CapDeDatos
{
    public class ModelAd : Model
    {
        public int Id;
        public string Name;
        public string Category;
        public string Path;

        public ModelAd(int id) => this.GetUserData(id);
        public ModelAd() { }


        public void GetUserData(int id)
        {
            try
            {
                this.Command.CommandText = $"SELECT * FROM AD WHERE id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.Name = this.DataReader["Name"].ToString();
                this.Category = this.DataReader["CAT"].ToString();
                this.Path = this.DataReader["PATH"].ToString();
                this.DataReader.Close();
            }
            catch (Exception e)
            {

            }
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else Insert();
        }

        private void Update()
        {
            try
            {
                this.Command.CommandText = "UPDATE AD SET " +
                    $"PATH = '{this.Path}'," +
                    $"CAT = '{this.Category}'," +
                    $"NAME = '{this.Name}' " +
                    $"WHERE id = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        } 
        private void Insert()
        {
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "AD (PATH,CAT,NAME) " +
                   $"VALUES ('{this.Path}','{this.Category}','{this.Category}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE FROM AD WHERE id = {this.Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }  
            catch (Exception e)
            {
                throw e;
            }
}
        public int GetId(string Name)
        {
            try
            {
                this.Command.CommandText = $"SELECT * FROM AD WHERE Name = '{Name}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["ID"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetAdDataTable()
        {
            try
            {
                DataTable tabla = new DataTable();
                Command.CommandText = "SELECT * FROM AD";
                tabla.Load(Command.ExecuteReader());
                Conection.Close();
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExistAd(string Name)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM AD WHERE NAME = '{Name}'";
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
                this.Command.CommandText = $"SELECT * FROM AD WHERE Id = {id}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Check = this.DataReader["PATH"].ToString();
                this.DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Check == "n") return true;
            else return false;
        }
    }
}
