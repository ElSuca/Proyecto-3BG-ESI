using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDeDatos
{
    public class ModelUser : Model
    {
        public int Id;
        public string UserName;
        public string Name;
        public string LastName;
        public string LastName2;
        public string PhoneNumber;
        public string Email;
        public string Password;
        public string UserRole;

        public ModelUser(int id) => this.GetUserData(id);

        public ModelUser()
        {
        }
        #region getUserData
        public void GetUserData(int id)
        {           
            this.command.CommandText = $"Select USER.*, PHONES.Num From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER where USER.ID={id}";
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.Id = int.Parse(this.dataReader["id"].ToString());
            this.UserName = this.dataReader["UNAME"].ToString();
            this.Name = this.dataReader["NAME"].ToString();
            this.LastName = this.dataReader["LNAME1"].ToString();
            this.LastName2 = this.dataReader["LNAME2"].ToString();
            this.Email = this.dataReader["email"].ToString();
            this.Email = this.dataReader["Email"].ToString();
            this.Password = this.dataReader["PASS"].ToString();
            this.UserRole = this.dataReader["ROLE"].ToString();
            this.PhoneNumber = this.dataReader["NUM"].ToString();
            this.dataReader.Close();
        }
        public void GetId(int UserName)
        {
            try
            {
                this.command.CommandText = $"SELECT * FROM USER WHERE UNAME ='{this.UserName}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                this.dataReader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int GetId(string Username)
        {
            try
            {
                this.command.CommandText = $"SELECT ID FROM USER WHERE UNAME = '{this.UserName}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                this.dataReader.Close();
                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<ModelUser> GetUserData()
        {
            List<ModelUser> users = new List<ModelUser>();
            try
            {
                this.command.CommandText = "SELECT * FROM USER";
                this.dataReader = this.command.ExecuteReader();

                while (this.dataReader.Read())
                {
                    ModelUser p = new ModelUser
                    {
                        Id = Int32.Parse(dataReader["Id"].ToString()),
                        Name = dataReader["Nombre"].ToString(),
                        LastName = dataReader["Apellido"].ToString(),
                        PhoneNumber = dataReader["Telefono"].ToString(),
                        Email = dataReader["Email"].ToString(),
                        Password = dataReader["password"].ToString()
                    };

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
                this.command.CommandText = "SELECT * FROM USER WHERE Nombre = @Nombre";
                this.dataReader = this.command.ExecuteReader();
                while (this.dataReader.Read())
                {
                    ModelUser p = new ModelUser
                    {
                        Id = Int32.Parse(dataReader["id"].ToString()),
                        UserName = dataReader["username"].ToString(),
                        Name = dataReader["nombre"].ToString(),
                        LastName = dataReader["apellido"].ToString(),
                        LastName2 = dataReader["apellido2"].ToString(),
                        Email = dataReader["Email"].ToString(),
                        Password = dataReader["password"].ToString()
                    };
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
                this.command.CommandText = "SELECT * FROM USER WHERE username = @username";
                this.command.Parameters.AddWithValue("@Nombre", Nombre);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.UserName = this.dataReader["username"].ToString();
                this.Password = this.dataReader["password"].ToString();
                this.dataReader.Close();

                if (type == "Password") return Password;
                else if (type == "username") return UserName;
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
            else
            {
                Insert();            
                InsertPhone();
            }
        }
        private void Insert()
        {
            command.CommandText = "INSERT INTO " +
               "USER (NAME,LNAME1,LNAME2,EMAIL,UNAME,PASS,ROLE) " +
               "VALUES (@Name,@Lastname1,@Lastname2,@Email,@Username,@Password,@UserRole)";
            this.command.Parameters.AddWithValue("@Name", this.Name);
            this.command.Parameters.AddWithValue("@Lastname1", this.LastName);
            this.command.Parameters.AddWithValue("@Lastname2", this.LastName);
            this.command.Parameters.AddWithValue("@Email", this.Email);
            this.command.Parameters.AddWithValue("@Username", this.UserName);
            this.command.Parameters.AddWithValue("@Password", this.Password);
            this.command.Parameters.AddWithValue("@UserRole", this.UserRole);
            this.command.Prepare();
            this.command.ExecuteNonQuery();
           
        }
        private void InsertPhone()
        {
            commanditou.CommandText = "INSERT INTO " +
               "PHONES (id_user,num) " +
               $"VALUES ({GetId(UserName)},'{this.PhoneNumber}')";
            this.commanditou.Prepare();
            this.commanditou.ExecuteNonQuery();
        }

        private void Update()
        {
            this.command.CommandText = "UPDATE USER,PHONES SET " +
                $"NAME = '{this.Name}'," +
                $"LNAME1 = '{this.LastName}'," +
                $"LNAME2 = '{this.LastName2}'," +
                $"EMAIL = '{this.Email}'," +
                $"UNAME = '{this.UserName}'," +
                $"PASS = '{this.Password}'," +
                $"ROLE = '{this.UserRole}'," +
                $"NUM = {this.PhoneNumber} " +
                $"WHERE USER.id = PHONES.ID_USER and USER.id = {this.Id}";
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = $"DELETE PHONES.* from PHONES where ID_USER = {Id}";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
                this.command.CommandText = $"delete USER.* from USER where ID= {Id}";
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
            GetUserDataForUserName(new SafeUserData().GetUsername());
           
            if (this.UserName == "") return false;
            if (this.Password == hashearPassword(passwordEntrada)) return true;
            return false;
        }
        public void ObtenerCredencialesPorNombre()
        {
            this.command.CommandText = "SELECT UNAME,PASS FROM USER WHERE UNAME = @UserName";
            this.command.Parameters.AddWithValue("@UserName", this.UserName);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            if (!this.dataReader.HasRows) return;
            this.dataReader.Read();
            this.UserName = this.dataReader["UNAME"].ToString();
            this.Password = this.dataReader["PASS"].ToString();
            this.dataReader.Close();
        }
        public void GetUserDataForUserName(string UserName)
        {
            try
            {
                this.command.CommandText = $"SELECT USER.*, PHONES.NUM From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER where ID = {GetId(UserName)}";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                if (!this.dataReader.HasRows) return;
                this.dataReader.Read();
                this.UserName = this.dataReader["UNAME"].ToString();
                this.Name = this.dataReader["NAME"].ToString();
                this.LastName = this.dataReader["LNAME1"].ToString();
                this.LastName2 = this.dataReader["LNAME2"].ToString();
                this.Email = this.dataReader["Email"].ToString();
                this.Password = this.dataReader["PASS"].ToString();
                this.UserRole = this.dataReader["ROLE"].ToString();
                this.PhoneNumber = this.dataReader["Num"].ToString();
                conection.Close();
                SetAllStaticUserData(UserName, Name, LastName, LastName2, Email, Int32.Parse(PhoneNumber), Password, UserRole);
            }
            catch(Exception ex)
            {

            }
        }

        private void crearArrayDePersonas(List<ModelUser> usuarios)
        {
            while (this.dataReader.Read())
            {
                ModelUser u = new ModelUser();
                u.Id = Int32.Parse(dataReader["id"].ToString());
                u.UserName = dataReader["username"].ToString();
                usuarios.Add(u);
            }
        }
        private List<ModelUser> obtenerTodasLasFilas()
        {
            this.command.CommandText = "SELECT ID,USERNAME FROM USER";
            this.dataReader = this.command.ExecuteReader();
            return new List<ModelUser>();
        }
        private string hashearPassword(string password) => MD5Hash.Hash.Content(password);

        public void checkedatareader()
        {
            try
            {
                dataReader.Close();
            }
            catch
            {
            }
        }
        public void checkconection()
        {
            if (conection.State != ConnectionState.Open) conection.Open();
            else conection.Close();
        }
       
        public void SetAllStaticUserData(string Username, string Name ,string LastName, string LastName2, string Email, int PhoneNumber, string password, string role)
        {
            SetUsernameBuffer(Username);
            SetNameStaticBuffer(Name);
            SetLastNameStaticBuffer(LastName);
            SetLastName2StaticBuffer(LastName2);
            SetEmailStaticBuffer(Email);
            SetPhoneNumberStaticBuffer(PhoneNumber);
            SetRoleStaticBuffer(role);
        }

        public DataTable GetUserDataTable()
        {
            DataTable tabla = new DataTable();
            command.CommandText = "Select USER.*, PHONES.NUM From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER";
            tabla.Load(command.ExecuteReader());
            conection.Close();
            return tabla;
        }

        public void setUsername(string un) => UserName = un;
        public string getEmail() => Email;
        public string getUserName() => UserName;
        #region Set static
        public void SetUsernameBuffer(string UserName) => new SafeUserData().SetUsername(UserName);
        public void SetNameStaticBuffer(string Name) => new SafeUserData().SetName(Name);
        public void SetLastNameStaticBuffer(string lastname) => new SafeUserData().SetLastName(lastname);
        public void SetLastName2StaticBuffer(string lastname2) => new SafeUserData().SetLastName2(lastname2);
        public void SetEmailStaticBuffer(string email) => new SafeUserData().SetEmail(email);
        public void SetPhoneNumberStaticBuffer(int phonenumber) => new SafeUserData().SetPhoneNumber(phonenumber);
        public void SetPasswordStaticBuffer(string password) => new SafeUserData().SetPassword(password);
        public void SetRoleStaticBuffer(string role) => new SafeUserData().SetRole(role);
        #endregion
        #region getStatic
        public string GetUsernameBuffer() => new SafeUserData().GetUsername();
        public string GetNameBuffer() => new SafeUserData().GetName();
        public string GetLastNameBuffer() => new SafeUserData().GetLastName();
        public string GetLastName2Buffer() => new SafeUserData().GetLastName2();
        public string GetEmailBuffer() => new SafeUserData().GetEmail();
        public int GetPhoneNumberBuffer() => new SafeUserData().GetPhoneNumber();
        public string GetPasswordBuffer() => new SafeUserData().GetPassword();
        public string GetRoleBuffer() => new SafeUserData().GetRole();
        #endregion
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

