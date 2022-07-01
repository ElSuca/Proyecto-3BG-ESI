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
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.Name = this.dataReader["Nombre"].ToString();
            this.LastName = this.dataReader["Apellido"].ToString();
            this.PhoneNumber = this.dataReader["Telefono"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.Password = this.dataReader["Password"].ToString();
        }
        public void GetId(int id)
        {
            this.CheckDataReaderActive();
            this.command.CommandText = "SELECT * FROM Usuario WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
        }
        public List<ModelUser> GetUserDataID(int id)
        {
            List<ModelUser> users = new List<ModelUser>();
            this.command.CommandText = "SELECT * FROM Usuario WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
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
            if (this.Id.ToString() != "0") Update();
            else Insertar();
        }
        private void Insertar()
        {
            //this.CheckDataReaderActive();
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
            this.CheckDataReaderActive();
            this.command.CommandText = "UPDATE usuario SET " +
               "Nombre = @Nombre," +
               "Apellido = @Apellido," +
               "Telefono = @Telefono," +
               "Email = @Email," +
               "Password = @Password" +
               " WHERE id = @id";
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
            this.CheckDataReaderActive();
            this.command.CommandText = "DELETE FROM Usuario WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", this.Id);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
        }

        public bool Autenticar(string passwordEntrada)
        {

            this.ObtenerPorNombre();
            if (this.Name == "") return false;
            if (this.Password == hashearPassword(passwordEntrada)) return true;
            return false;
        }
        public void ObtenerPorNombre()
        {
            this.command.CommandText = "SELECT nombre,password FROM usuario WHERE Nombre = @Nombre";
            this.command.Parameters.AddWithValue("@Nombre", this.Name);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            if (!this.dataReader.HasRows) return;
            this.dataReader.Read();
            this.Name = this.dataReader["Nombre"].ToString();
            this.Password = this.dataReader["Password"].ToString();
        }
        private void crearArrayDePersonas(List<ModelUser> usuarios)
        {
            while (this.dataReader.Read())
            {
                ModelUser u = new ModelUser();
                u.Id = Int32.Parse(dataReader["id"].ToString());
                u.Name = dataReader["Nombre"].ToString();

                usuarios.Add(u);
            }
        }
        private List<ModelUser> obtenerTodasLasFilas()
        {
            List<ModelUser> usuarios = new List<ModelUser>();
            this.command.CommandText = "SELECT id,Nombre FROM usuario";
            this.dataReader = this.command.ExecuteReader();
            return usuarios;
        }
        private string hashearPassword(string password)
        {
            return MD5Hash.Hash.Content(password);
        }

        public void CheckDataReaderActive()
        {
            if (!dataReader.IsClosed && dataReader != null) dataReader.Close();
            else if (dataReader == null) Console.WriteLine("error");
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

