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
            this.command.CommandText = "SELECT * FROM AD WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["Name"].ToString();
            this.Category = this.dataReader["CAT"].ToString();
            this.Path = this.dataReader["PATH"].ToString();
            this.dataReader.Close();
        }

        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else Insert();
        }

        private void Update()
        {
            this.command.CommandText = "UPDATE AD SET " +
                "PATH = @PATH," +
                "CAT = @CAT " +
                "AD_NAME = @AD_NAME " +
                 "WHERE id = @id";

            this.command.Parameters.AddWithValue("@PATH", this.Path);
            this.command.Parameters.AddWithValue("@CAT", this.Category);
            this.command.Parameters.AddWithValue("@AD_NAME", this.Name);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        private void Insert()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "AD (PATH,CAT,NAME) " +
                   "VALUES (@PATH,@CAT,@NAME)";
                this.command.Parameters.AddWithValue("@PATH", this.Path);
                this.command.Parameters.AddWithValue("@CAT", this.Category);
                this.command.Parameters.AddWithValue("@NAME", this.Name);
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Delete(int Id)
        {
            this.command.CommandText = "DELETE FROM AD WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", this.Id);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        public int GetId(string Name)
        {
            this.command.CommandText = "SELECT * FROM AD WHERE Name = @Name";
            this.command.Parameters.AddWithValue("@Name", Name);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["ID"].ToString());
            this.dataReader.Close();
            return Id;
        }

        public DataTable GetAdDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "SELECT * FROM AD";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }
    }
}
