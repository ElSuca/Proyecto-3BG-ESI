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
            this.command.CommandText = "SELECT * FROM usuario WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();

            this.Id = Int32.Parse(this.dataReader["Id"].ToString());
            this.Name = this.dataReader["Nombre"].ToString();
            this.LastName = this.dataReader["Apellido"].ToString();
            this.PhoneNumber = this.dataReader["Telefono"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.Password = this.dataReader["Password"].ToString();
        }

        public List<ModelUser> GetUserData()
        {
            List<ModelUser> users = new List<ModelUser>();
            this.command.CommandText = "SELECT * FROM usuario";
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
        public string GetUserPassword(string Nombre)
        {
            this.command.CommandText = "SELECT * FROM usuario WHERE Nombre = @nombre";
            this.command.Parameters.AddWithValue("@nombre", Nombre);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Name = this.dataReader["Nombre"].ToString();
            this.Password = this.dataReader["Password"].ToString();
            this.dataReader.Close();
            return Password;
        }
        public string GetUserName(string Nombre)
        {
            this.command.CommandText = "SELECT * FROM usuario WHERE Nombre = @nombre";
            this.command.Parameters.AddWithValue("@nombre", Nombre);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Name = this.dataReader["Nombre"].ToString();
            this.Password = this.dataReader["Password"].ToString();
            this.dataReader.Close();
            return Name;
        }
        #endregion
        public void Save()
        {
            if (this.Id.ToString() != "") Update();
            else Insertar();
        }
        private void Insertar()
        {
            this.command.CommandText = "INSERT INTO usuario VALUES (@id, @nombre,@apellido,@email,@telefono,@password)";
            this.command.Parameters.AddWithValue("@id", this.Id.ToString());
            this.command.Parameters.AddWithValue("@nombre", this.Name);
            this.command.Parameters.AddWithValue("@apellido", this.LastName);
            this.command.Parameters.AddWithValue("@telefono", this.PhoneNumber);
            this.command.Parameters.AddWithValue("@email", this.Email);
            this.command.Parameters.AddWithValue("@password", this.Password);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }

        private void Update()
        {
            this.command.CommandText = "UPDATE usuario SET " +
                "nombre = @nombre," +
                "apellido = @apellido," +
                "telefono = @telefono," +
                "email = @email" +
                "password = @password" +
                "WHERE id = @id";

            this.command.Parameters.AddWithValue("@nombre", this.Name);
            this.command.Parameters.AddWithValue("@apellido", this.LastName);
            this.command.Parameters.AddWithValue("@telefono", this.PhoneNumber);
            this.command.Parameters.AddWithValue("@email", this.Email);
            this.command.Parameters.AddWithValue("@password", this.Password);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }
        public void Delete()
        {
            this.command.CommandText = "DELETE FROM usuario WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", this.Id);
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

