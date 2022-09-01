using CapaDeDatos;
using CapDeDatos;
using MySql.Data.MySqlClient;
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
            this.command.CommandText = "SELECT * FROM user WHERE id = @id";
            this.command.Parameters.AddWithValue("@id", id);
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
            this.dataReader.Close();
           this.GetPhoneById(id);
        }
        public void GetPhoneById(int id)
        {
            this.command.CommandText = "SELECT * FROM phones WHERE id_user = @id";
            this.command.Parameters.AddWithValue("@id", id);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            this.PhoneNumber = this.dataReader["telefono"].ToString();
            this.dataReader.Close();
        }
        public void GetId(int UserName)
        {
            try
            {
                this.command.CommandText = "SELECT * FROM User WHERE UNAME = @UNAME";
                this.command.Parameters.AddWithValue("@UNAME", UserName);
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
        public int GetId(string Name)
        {
            try
            {
                this.command.CommandText = "SELECT * FROM User WHERE Name = @Nombre";
                this.command.Parameters.AddWithValue("@Nombre", Name);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                this.dataReader.Close();
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
                this.command.CommandText = "SELECT * FROM User WHERE id = @id";
                this.command.Parameters.AddWithValue("@id", id);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                this.Id = int.Parse(this.dataReader["id"].ToString());
                this.UserName = this.dataReader["username"].ToString();
                this.Name = this.dataReader["nombre"].ToString();
                this.LastName = this.dataReader["apellido"].ToString();
                this.LastName2 = this.dataReader["apellido2"].ToString();
                this.Email = this.dataReader["email"].ToString();
                this.Password = this.dataReader["password"].ToString();

                this.command.CommandText = "SELECT * FROM Telefonos WHERE id = @id";
                this.command.Parameters.AddWithValue("@id", id);
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.PhoneNumber = this.dataReader["telefono"].ToString();
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
                this.command.CommandText = "SELECT * FROM User";
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
                this.command.CommandText = "SELECT * FROM User WHERE Nombre = @Nombre";
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
                this.command.CommandText = "SELECT * FROM User WHERE username = @username";
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
            else Insert();
        }
        private void Insert()
        {
            try
            {
                command.CommandText = "INSERT INTO " +
                   "User (NAME,LNAME1,LNAME2,EMAIL,UNAME,PASS,ROLE) " +
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

              
                commanditou.CommandText = "INSERT INTO " +
                   "phones (id_user,num) " +
                   "VALUES (@id_user,@Num)";
                this.commanditou.Parameters.AddWithValue("@id_user", GetId(UserName));
                this.commanditou.Parameters.AddWithValue("@Num", this.PhoneNumber);
                this.commanditou.Prepare();
                this.commanditou.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void Update()
        {
            this.command.CommandText = "UPDATE user SET " +
                "NAME = @Name," +
                "LNAME1 = @Lastname1," +
                "LNAME2 = @Lastname2," +
                "EMAIL = @Email," +
                "UNAME = @Username," +
                "PASS = @Password," +
                "ROLE = @UserRole " +
                 "WHERE id = @id";
            this.command.Parameters.AddWithValue("@Name", this.Name);
            this.command.Parameters.AddWithValue("@Lastname1", this.LastName);
            this.command.Parameters.AddWithValue("@Lastname2", this.LastName2);
            this.command.Parameters.AddWithValue("@EMAIL", this.Email);
            this.command.Parameters.AddWithValue("@Username", this.UserName);
            this.command.Parameters.AddWithValue("@Password", this.Password);
            this.command.Parameters.AddWithValue("@UserRole", this.UserRole);
            this.command.Prepare();
            this.command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.command.CommandText = "DELETE FROM user WHERE id = @id";
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
            SafeUserData b = new SafeUserData();
            string n = b.GetUsername();
            GetUserDataForUserName(n);
            if (this.UserName == "") return false;
            if (this.Password == hashearPassword(passwordEntrada)) return true;
            return false;
        }
        public void ObtenerCredencialesPorNombre()
        {
            this.command.CommandText = "SELECT UNAME,PASS FROM user WHERE UNAME = @UserName";
            this.command.Parameters.AddWithValue("@UserName", this.UserName);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            if (!this.dataReader.HasRows) return;
            this.dataReader.Read();
            this.UserName = this.dataReader["UNAME"].ToString();
            this.Password = this.dataReader["PASS"].ToString();

        }
        public void GetUserDataForUserName(string UserName)
        {

            
            this.command.CommandText = "SELECT NAME,LNAME1,LNAME2,EMAIL,UNAME,PASS,ROLE FROM user WHERE UNAME = @UNAME";
            this.command.Parameters.AddWithValue("@UNAME", UserName);
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
            conection.Close();
          //  GetPhoneNumber(UserName);
            PhoneNumber = "12345678";
            SetAllStaticUserData(UserName, Name, LastName, LastName2, Email, Int32.Parse(PhoneNumber),Password,UserRole);
        }
        public string GetPhoneNumber(string Username)
        {
            conection.Open();
            dataReader.Close();
            busquedasql("SELECT ID_USER,NUM FROM phones WHERE ID_USER = @ID_USER", "ID_USER", UserName);
            this.PhoneNumber = this.dataReader["NUM"].ToString();
            conection.Close();
            return PhoneNumber;
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
            this.command.CommandText = "SELECT id,UserName FROM User";
            this.dataReader = this.command.ExecuteReader();
            return new List<ModelUser>();
        }
        private string hashearPassword(string password) => MD5Hash.Hash.Content(password);

        public MySqlDataReader busquedasql(string path,string condition,string condition2)
        {
            checkconection();
            checkedatareader();
            this.command.CommandText = path;
            this.command.Parameters.AddWithValue("@"+condition, condition2);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            return dataReader;
            
        }
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
            ConnectionState state = conection.State;
            if (state != ConnectionState.Open) conection.Open();
            else conection.Close();
        }
       
        public void SetAllStaticUserData(string Username, string Name ,string LastName, string LastName2, string Email, int PhoneNumber, string password, string role)
        {
            SetUsernameBuffer(Username);
            SetLastNameBuffer(LastName);
            SetEmailBuffer(Email);
            SetPhoneNumberBuffer(PhoneNumber);
        }
        public void setUsername(string un) => UserName = un;
        public string getEmail() => Email;
        public string getUserName() => UserName;
        #region Set static
        public void SetUsernameBuffer(string UserName) => new SafeUserData().SetUsername(UserName);
        public void SetNameStaticBuffer(string Name) => new SafeUserData().SetName(Name);
        public void SetLastNameBuffer(string lastname) => new SafeUserData().SetLastName(lastname);
        public void SetLastName2Buffer(string lastname2) => new SafeUserData().SetLastName(lastname2);
        public void SetEmailBuffer(string email) => new SafeUserData().SetEmail(email);
        public void SetPhoneNumberBuffer(int phonenumber) => new SafeUserData().SetPhoneNumber(phonenumber);
        public void SetPasswordBuffer(string password) => new SafeUserData().SetPassword(password);
        public void SetRoleBuffer(string role) => new SafeUserData().SetEmail(role);
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

