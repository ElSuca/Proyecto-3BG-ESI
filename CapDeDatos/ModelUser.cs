using CapaDeDatos;
using System;
using System.Collections.Generic;

namespace CapaDeDatos
{
    public class ModelUser : Model
    {
        public int Id;
        public string Name;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Password;

        public ModelUser(int id)
        {
            this.GetUserData(id);
        }
        public ModelUser()
        {   
        }
        #region getUserData
        public void GetUserData(int id)
        {
            this.command.CommandText = "SELECT * FROM Usuario WHERE id = @Id";
            this.command.Parameters.AddWithValue("@Id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();

            this.Id = int.Parse(this.dataReader["Id"].ToString());
            this.Name = this.dataReader["Nombre"].ToString();
            this.LastName = this.dataReader["Apellido"].ToString();
            this.PhoneNumber = this.dataReader["Telefono"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.Password = this.dataReader["Password"].ToString();
        }
        public void GetId(int id)
        {
            if(!dataReader.IsClosed) dataReader.Close();
            this.command.CommandText = "SELECT * FROM Usuario WHERE id = @Id";
            this.command.Parameters.AddWithValue("@Id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();

            this.Id = int.Parse(this.dataReader["Id"].ToString());
        }
        public List<ModelUser> GetUserDataID(int id)
        {
            List<ModelUser> users = new List<ModelUser>();
            this.command.CommandText = "SELECT * FROM Usuario WHERE id = @Id";
            this.command.Parameters.AddWithValue("@Id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();

            this.Id = int.Parse(this.dataReader["Id"].ToString());
            this.Name = this.dataReader["Nombre"].ToString();
            this.LastName = this.dataReader["Apellido"].ToString();
            this.PhoneNumber = this.dataReader["Telefono"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.Password = this.dataReader["Password"].ToString();
            return users;
        }

        public List<ModelUser> GetUserData()
        {
            List<ModelUser> users = new List<ModelUser>();
            this.command.CommandText = "SELECT * FROM Usuario";
            this.dataReader = this.command.ExecuteReader();

            while (this.dataReader.Read())
            {
                ModelUser p = new ModelUser();
                p.Id = Int32.Parse(dataReader["Id"].ToString());
                p.Name = dataReader["Nombre"].ToString();
                p.LastName = dataReader["Apellido"].ToString();
                p.PhoneNumber = dataReader["Telefono"].ToString();
                p.Email = dataReader["Email"].ToString();
                p.Password = dataReader["password"].ToString();

                users.Add(p);
            }
            return users;

        }
        public string GetUserDataLogging(string Nombre,string type)
        {
            this.command.CommandText = "SELECT * FROM Usuario WHERE Nombre = @Nombre";
            this.command.Parameters.AddWithValue("@Nombre", Nombre);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Name = this.dataReader["Nombre"].ToString();
            this.Password = this.dataReader["password"].ToString();
            this.dataReader.Close();

            if(type == "Password") return Password;
            else if (type == "Name") return Name;
            return null;
        }
        
        #endregion
        public void Save()
        {
            if (this.Id.ToString() != "") Update();
            else Insertar();
        }
        private void Insertar()
        {
            this.dataReader.Close();
            command.CommandText = "INSERT INTO " +
               "Usuario (nombre, apellido, telefono, email, password) " +
               "VALUES (@Nombre,@Apellido,@Telefono,@Email, @Password)";
            this.command.Parameters.AddWithValue("@Nombre", this.Name);
            this.command.Parameters.AddWithValue("@Apellido", this.LastName);
            this.command.Parameters.AddWithValue("@Email", this.Email);
            this.command.Parameters.AddWithValue("@Telefono", this.PhoneNumber);
            this.command.Parameters.AddWithValue("@Password", this.Password);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }

        private void Update()
        {
            this.dataReader.Close();
            this.command.CommandText = "UPDATE Usuario SET " +
                "nombre = @Nombre," +
                "apellido = @Apellido," +
                "telefono = @Telefono," +
                "email = @Email," +
                "password = @Password," +
                "WHERE Id = @Id";

            this.command.Parameters.AddWithValue("@Nombre", this.Name);
            this.command.Parameters.AddWithValue("@Apellido", this.LastName);
            this.command.Parameters.AddWithValue("@Telefono", this.PhoneNumber);
            this.command.Parameters.AddWithValue("@Email", this.Email);
            this.command.Parameters.AddWithValue("@Password", this.Password);            
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        public void Delete(int Id)
        {
            this.dataReader.Close();
            this.command.CommandText = "DELETE FROM Usuario WHERE Id = @Id";
            this.command.Parameters.AddWithValue("@Id", this.Id);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }

        
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

