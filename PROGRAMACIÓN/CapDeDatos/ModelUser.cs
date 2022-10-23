﻿using CapDeDatos;
using System;
using System.Collections.Generic;
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
            this.PhoneNumber = Int32.Parse(this.dataReader["NUM"].ToString());
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
                this.command.CommandText = $"SELECT ID FROM USER WHERE UNAME = '{Username}'";
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
                        PhoneNumber = Int32.Parse(dataReader["Telefono"].ToString()),
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
        public bool ExistUser(string Username)
        {
            bool exist;
            try
            {
                this.command.CommandText = $"SELECT * FROM USER WHERE UNAME = '{Username}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                exist = this.dataReader.HasRows;
                this.dataReader.Close();
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
                this.command.CommandText = $"SELECT * FROM USER WHERE UNAME = '{Username}'";
                this.command.Prepare();
                this.dataReader = this.command.ExecuteReader();
                this.dataReader.Read();
                Name = this.dataReader["NAME"].ToString();
                this.dataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            if (Name == "n") return true;
            else return false;
        }
        public string GetUserDataLogging(string Nombre, string type)
        {
            try
            {
                this.command.CommandText = "SELECT * FROM USER WHERE UNAME = @username";
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
            try
            {
                command.CommandText = "INSERT INTO " +
                   "USER (NAME,LNAME1,LNAME2,EMAIL,UNAME,PASS,ROLE,CITY,STREET,NUM,STATE,COUNTRY) " +
                   $"VALUES ('{Name}','{LastName}','{LastName2}','{Email}','{UserName}','{Password}','{UserRole}','{City}','{Street}',{Num},'{State}','{Country}')";
                this.command.Prepare();
                this.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        private void InsertPhone()
        {
            commanditou.CommandText = "INSERT INTO " +
               "PHONES (id_user,num) " +
               $"VALUES ({GetId(UserName)},{this.PhoneNumber})";
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
                $"CITY = '{this.City}',"+
                $"STREET = '{this.Street}',"+
                $"USER.NUM = '{this.Num}',"+
                $"STATE = '{this.State}',"+
                $"COUNTRY = '{this.Country} '"+ 
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
                this.command.CommandText = $"DELETE USER.* from USER where ID= {Id}";
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
            GetUserDataForUserName(SafeUserData.Username);
           
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
                this.PhoneNumber = Int32.Parse(this.dataReader["Num"].ToString());
                this.City = this.dataReader["CITY"].ToString();
                this.Street = this.dataReader["STREET"].ToString();
                this.Num = Int32.Parse(this.dataReader["NUM"].ToString());
                this.State = this.dataReader["STATE"].ToString();
                this.Country = this.dataReader["COUNTRY"].ToString();
                conection.Close();
                SetAllStaticUserData(UserName, Name, LastName, LastName2, Email, PhoneNumber, Password, UserRole,City,Street,Num,State,Country);
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
            command.CommandText = "Select USER.*, PHONES.NUM From USER LEFT JOIN PHONES on USER.ID = PHONES.ID_USER";
            tabla.Load(command.ExecuteReader());
            conection.Close();
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
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

