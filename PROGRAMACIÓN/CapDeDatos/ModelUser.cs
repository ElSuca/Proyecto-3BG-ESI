using CapDeDatos;
using System;
using System.Data;

namespace CapaDeDatos
{
    public class ModelUser : Model
    {
        public int Id;
        public string UserName { get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public int Num { get; set; }
        public string Country { get; set; }

        public ModelUser(int id) => this.GetUserData(id);

        public ModelUser()
        {
        }
        #region getUserData
        public void GetUserData(int id)
        {           
            this.Command.CommandText = $"Select USER.*, PHONES.Num From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER where USER.ID={id}";
            this.Command.Prepare();
            this.DataReader = this.Command.ExecuteReader();
            this.DataReader.Read();
            this.Id = int.Parse(this.DataReader["id"].ToString());
            this.UserName = this.DataReader["UNAME"].ToString();
            this.Name = this.DataReader["NAME"].ToString();
            this.LastName = this.DataReader["LNAME1"].ToString();
            this.LastName2 = this.DataReader["LNAME2"].ToString();
            this.Email = this.DataReader["email"].ToString();
            this.Email = this.DataReader["Email"].ToString();
            this.Password = this.DataReader["PASS"].ToString();
            this.UserRole = this.DataReader["ROLE"].ToString();
            this.PhoneNumber = Int32.Parse(this.DataReader["NUM"].ToString());
            this.DataReader.Close();
        }
        public int GetId(string Username)
        {
            try
            {
                this.Command.CommandText = $"SELECT ID FROM USER WHERE UNAME = '{Username}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                this.Id = int.Parse(this.DataReader["id"].ToString());
                this.DataReader.Close();
                return Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }  
        public bool ExistUser(string Username)
        {
            bool exist;
            try
            {
                this.Command.CommandText = $"SELECT * FROM USER WHERE UNAME = '{Username}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                exist = this.DataReader.HasRows;
                this.DataReader.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (exist) return true;
            else return false;
        }
        public bool HaveChange(string Username)
        {
            string Name;
            try
            {
                this.Command.CommandText = $"SELECT * FROM USER WHERE UNAME = '{Username}'";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                this.DataReader.Read();
                Name = this.DataReader["NAME"].ToString();
                this.DataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Name == "n") return true;
            else return false;
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
            try
            {
                Command.CommandText = "INSERT INTO " +
                   "USER (NAME,LNAME1,LNAME2,EMAIL,UNAME,PASS,ROLE,CITY,STREET,NUM,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName}','{LastName2}','{Email}','{UserName}','{Password}','{UserRole}','{City}','{Street}',{Num},'{State}','{Country}')";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        private void InsertPhone()
        {
            Commanditou.CommandText = "INSERT INTO " +
               "PHONES (id_user,num) " +
               $"VALUES ({GetId(UserName)},{this.PhoneNumber})";
            this.Commanditou.Prepare();
            this.Commanditou.ExecuteNonQuery();
        }

        private void Update()
        {
            this.Command.CommandText = "UPDATE USER,PHONES SET " +
                $"NAME = '{this.Name}'," +
                $"LNAME1 = '{this.LastName}'," +
                $"LNAME2 = '{this.LastName2}'," +
                $"EMAIL = '{this.Email}'," +
                $"UNAME = '{this.UserName}'," +
                $"PASS = '{this.Password}'," +
                $"ROLE = '{this.UserRole}'," +
                $"CITY = '{this.City}',"+
                $"STREET = '{this.Street}',"+
                $"USER.NUM = '{this.Num}',"+
                $"STATE = '{this.State}',"+
                $"COUNTRY = '{this.Country} '"+ 
                $"WHERE USER.id = PHONES.ID_USER and USER.id = {this.Id}";
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();

        }
        public void Delete(int Id)
        {
            try
            {
                this.Command.CommandText = $"DELETE PHONES.* from PHONES where ID_USER = {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
                this.Command.CommandText = $"DELETE USER.* from USER where ID= {Id}";
                this.Command.Prepare();
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Autenticar(string passwordEntrada)
        {
            GetUserDataForUserName(SafeUserData.Username);
           
            if (this.UserName == "") return false;
            if (this.Password == hashPassword(passwordEntrada)) return true;
            return false;
        }
        public void GetUserDataForUserName(string UserName)
        {
            try
            {
                this.Command.CommandText = $"SELECT USER.*, PHONES.NUM From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER where ID = {GetId(UserName)}";
                this.Command.Prepare();
                this.DataReader = this.Command.ExecuteReader();
                if (!this.DataReader.HasRows) return;
                this.DataReader.Read();
                this.UserName = this.DataReader["UNAME"].ToString();
                this.Name = this.DataReader["NAME"].ToString();
                this.LastName = this.DataReader["LNAME1"].ToString();
                this.LastName2 = this.DataReader["LNAME2"].ToString();
                this.Email = this.DataReader["Email"].ToString();
                this.Password = this.DataReader["PASS"].ToString();
                this.UserRole = this.DataReader["ROLE"].ToString();
                this.PhoneNumber = Int32.Parse(this.DataReader["Num"].ToString());
                this.City = this.DataReader["CITY"].ToString();
                this.Street = this.DataReader["STREET"].ToString();
                this.Num = Int32.Parse(this.DataReader["NUM"].ToString());
                this.State = this.DataReader["STATE"].ToString();
                this.Country = this.DataReader["COUNTRY"].ToString();
                this.DataReader.Close();
                Conection.Close();
                SetAllStaticUserData(UserName, Name, LastName, LastName2, Email, PhoneNumber, Password, UserRole,City,Street,Num,State,Country);
            }
            catch(Exception)
            {

            }
        }
        private string hashPassword(string password) => MD5Hash.Hash.Content(password);

       public int getSubscriptionIndex()
        {
            this.Command.CommandText = $"SELECT COUNT(flag_asis) AS cantidad, dni FROM detalle_asistencia WHERE flag_asis = '1' GROUP BY dni";
            this.Command.Prepare();
           return Int32.Parse(this.Command.ExecuteReader());

        }

        public void SetAllStaticUserData(string Username ,string Name ,string LastName ,string LastName2, string Email, int PhoneNumber, string password, string role,string city,string street,int num,string state,string country)
        {
            SetUsernameBuffer(Username);
            SetNameStaticBuffer(Name);
            SetLastNameStaticBuffer(LastName);
            SetLastName2StaticBuffer(LastName2);
            SetEmailStaticBuffer(Email);
            SetPhoneNumberStaticBuffer(PhoneNumber);
            SetRoleStaticBuffer(role);
            SetCityStaticBuffer(city);
            SetStreetStaticBuffer(street);
            SetNumStaticBuffer(num);
            SetStateStaticBuffer(state);
            SetCountryStaticBuffer(country);
        }
        public DataTable GetUserDataTable()
        {
            DataTable tabla = new DataTable();
            Command.CommandText = "Select USER.*, PHONES.NUM From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER";
            tabla.Load(Command.ExecuteReader());
            Conection.Close();
            return tabla;
        }

        #region Set static
        public void SetUsernameBuffer(string UserName) => SafeUserData.Username = UserName;
        public void SetNameStaticBuffer(string Name) => SafeUserData.Name = Name;
        public void SetLastNameStaticBuffer(string lastname) => SafeUserData.LastName = lastname;
        public void SetLastName2StaticBuffer(string lastname2) => SafeUserData.LastName2 = lastname2;
        public void SetEmailStaticBuffer(string email) => SafeUserData.Email = email;
        public void SetPhoneNumberStaticBuffer(int phonenumber) => SafeUserData.PhoneNumber = phonenumber;
        public void SetPasswordStaticBuffer(string password) => SafeUserData.Password = password;
        public void SetRoleStaticBuffer(string role) => SafeUserData.Role = role;
        public void SetCityStaticBuffer(string city) => SafeUserData.City = city;
        public void SetStreetStaticBuffer(string street) => SafeUserData.Street = street;
        public void SetNumStaticBuffer(int num) => SafeUserData.Num = num;
        public void SetStateStaticBuffer(string state) => SafeUserData.State = state;
        public void SetCountryStaticBuffer(string country) => SafeUserData.Country = country;

        #endregion
        #region getStatic
        public string GetUsernameBuffer() => SafeUserData.Username;
        public string GetNameBuffer() => SafeUserData.Name;
        public string GetLastNameBuffer() => SafeUserData.LastName;
        public string GetLastName2Buffer() => SafeUserData.LastName2;
        public string GetEmailBuffer() => SafeUserData.Email;
        public int GetPhoneNumberBuffer() => SafeUserData.PhoneNumber;
        public string GetPasswordBuffer() => SafeUserData.Password;
        public string GetRoleBuffer() =>  SafeUserData.Role;
        public string GetCityBuffer() => SafeUserData.City;
        public string GetStreetBuffer() => SafeUserData.Street;
        public int GetNumBuffer() => SafeUserData.Num;
        public string GetStateBuffer() => SafeUserData.State;
        public string GetCountryBuffer() => SafeUserData.Country;
        #endregion
    } 
}

