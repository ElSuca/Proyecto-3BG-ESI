using CapaDeDatos;
using CapDeDatos;
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
            try
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
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GetId(int id)
        {
            try
            {
                this.CheckDataReaderActive();
                this.command.CommandText = "SELECT * FROM Usuario WHERE id = @id";
                this.command.Parameters.AddWithValue("@id", id);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
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
                this.CheckDataReaderActive();
                this.command.CommandText = "SELECT * FROM Usuario WHERE Name = @Nombre";
                this.command.Parameters.AddWithValue("@Nombre", Name);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                return Id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<ModelUser> GetUserDataID(int id)
        {
            List<ModelUser> users = new List<ModelUser>();
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ModelUser> GetUserData()
        {
            List<ModelUser> users = new List<ModelUser>();
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<ModelUser> GetUserData(string Username)
        {
            List<ModelUser> users = new List<ModelUser>();
            try
            {
                this.command.CommandText = "SELECT * FROM Usuario WHERE Nombre = @Nombre";
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
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetUserDataLogging(string Nombre, string type)
        {
            try
            {
                this.command.CommandText = "SELECT * FROM Usuario WHERE Nombre = @Nombre";
                this.command.Parameters.AddWithValue("@Nombre", Nombre);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Name = this.dataReader["Nombre"].ToString();
                this.Password = this.dataReader["password"].ToString();
                this.dataReader.Close();

                if (type == "Password") return Password;
                else if (type == "Name") return Name;
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
        public void Save()
        {
            if (this.Id.ToString() != "0") Update();
            else Insertar();
        }
        private void Insertar()
        {
            try
            {
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
            catch (Exception e)
            {
                throw e;
            }
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
            try
            {
                this.CheckDataReaderActive();
                this.command.CommandText = "DELETE FROM Usuario WHERE id = @id";
                this.command.Parameters.AddWithValue("@id", this.Id);
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Autenticar(string passwordEntrada)
        {
            this.ObtenerCredencialesPorNombre();
            if (this.Name == "") return false;
            if (this.Password == hashearPassword(passwordEntrada)) return true;
            return false;
        }
        public void ObtenerCredencialesPorNombre()
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
        public void GetUserDataForUserName(string name)
        {

            this.command.CommandText = "SELECT nombre,password,Apellido,Email,Telefono FROM usuario WHERE Nombre = @Nombre";
            this.command.Parameters.AddWithValue("@Nombre", name);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            if (!this.dataReader.HasRows) return;
            this.dataReader.Read();
            this.Name = this.dataReader["Nombre"].ToString();
            this.LastName = this.dataReader["Apellido"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.PhoneNumber = this.dataReader["Telefono"].ToString();
            this.Password = this.dataReader["Password"].ToString();

            SetAllStaticUserData(Name, LastName, Email, Int32.Parse(PhoneNumber));
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
        public void SetAllStaticUserData(string Username,string LastName, string Email, int PhoneNumber)
        {
            SetUsernameStatic(Username);
            SetLastNameStatic(LastName);
            SetEmailStatic(Email);
            SetPhoneNumberStatic(PhoneNumber);
        }
        public void setUsername(string Username)
        {
            Name = Username;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getUserName()
        {
            return Name;
        }
        #region Set static
        public void SetUsernameStatic(string name)
        {
            SafeUserData ud = new SafeUserData();
            ud.SetUsername(name);
        } 
        public void SetLastNameStatic(string lastname)
        {
            SafeUserData ud = new SafeUserData();
            ud.SetLastName(lastname);
        }
        public void SetEmailStatic(string email)
        {
            SafeUserData ud = new SafeUserData();
            ud.SetEmail(email);
        }
        public void SetPhoneNumberStatic(int phonenumber)
        {
            SafeUserData ud = new SafeUserData();
            ud.SetPhoneNumber(phonenumber);
        }
        public void SetPasswordStatic(string password)
        {
            SafeUserData ud = new SafeUserData();
            ud.SetPassword(password);
        }
        #endregion
        #region getStatic
        public string GetUsernameStatic()
        {
            SafeUserData ud = new SafeUserData();
            return ud.GetUsername();
        }
        public string GetLastNameStatic()
        {
            SafeUserData ud = new SafeUserData();
            return ud.GetLastName();
        }
        public string GetEmailStatic()
        {
            SafeUserData ud = new SafeUserData();
            return ud.GetEmail();
        }
        public int GetPhoneNumberStatic()
        {
            SafeUserData ud = new SafeUserData();
            return ud.GetPhoneNumber();
        }
        public string GetPasswordStatic()
        {
            SafeUserData ud = new SafeUserData();
            return ud.GetPassword();
        }
        #endregion
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

