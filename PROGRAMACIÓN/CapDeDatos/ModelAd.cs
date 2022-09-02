using CapaDeDatos;
using System;

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
            this.Name = this.dataReader["AD_Name"].ToString();
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
                   "AD (PATH,CAT,AD_NAME) " +
                   "VALUES (@PATH,@CAT,@AD_NAME)";
                this.command.Parameters.AddWithValue("@PATH", this.Path);
                this.command.Parameters.AddWithValue("@CAT", this.Category);
                this.command.Parameters.AddWithValue("@AD_NAME", this.Name);
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
            this.command.CommandText = "SELECT * FROM AD WHERE Ad_Name = @Ad_Name";
            this.command.Parameters.AddWithValue("@Ad_Name", Name);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["ID_AD"].ToString());
            this.dataReader.Close();
            return Id;
        }
    }
}
