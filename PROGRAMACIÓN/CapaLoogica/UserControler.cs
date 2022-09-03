using System;
using System.Collections.Generic;
using System.Data;
using CapaDeDatos;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class UserControler
    {
        #region FuncionesBasicas  
        public static void Alta(string name, string lastName1, string lastName2, string email, string username, string role, string password, string phoneNumber)
        {
            ModelUser p = new ModelUser
            {
                Name = name,
                LastName = lastName1,
                LastName2 = lastName2,
                PhoneNumber = phoneNumber,
                Email = email,
                UserName = username,
                Password = password,
                UserRole = role
            };
            p.Save();
        }

        public static void Modificar(int id, string name, string lastName1, string lastName2, string email, string username, string role, string password, string phoneNumber)
        {
            ModelUser p = new ModelUser(id)
            {
                Name = name,
                LastName = lastName1,
                LastName2 = lastName2,
                PhoneNumber = phoneNumber,
                Email = email,
                UserName = username,
                Password = password,
                UserRole = role
            };
            p.Save();
        }
        public static void Eliminar(int id) => new ModelUser(id).Delete(id);
        #endregion
        #region GetUserData
        public static List<ModelUser> GetUserData(int id) => new ModelUser(id).GetUserData();
        public List<ModelUser> GetUserData(string Username) => new ModelUser().GetUserData(Username);
        #endregion
        #region GetId
        public void GetId(int id) => new ModelUser(id).GetId(id);
        public int GetId(string Name) => new ModelUser().GetId(Name);
        #endregion
        public static DataTable ObtenerTodos()
        {
            List<ModelUser> personitas = new ModelUser().GetUserData();
            return new DataTable();
        }
        public static bool Autenticar(string nombre, string password)
        {
            ModelUser u = new ModelUser();

            u.SetUsernameBuffer(nombre);
            return u.Autenticar(password);
        }
        public DataTable GetUserDataTable() => new ModelUser().GetUserDataTable();
        #region get
        public string GetEmail() => new ModelUser().getEmail();
        public string GetUsername() => new ModelUser().getUserName();
        #endregion
        #region SetStatic
        public void SetStaticUsername(string name) => new ModelUser().SetUsernameBuffer(name);

        public void SetStaticName(string name) => new ModelUser().SetUsernameBuffer(name);

        public void SetStaticLastName(string lastname) => new ModelUser().SetLastNameBuffer(lastname);

        public void SetStaticLastName2(string lastname2) => new ModelUser().SetLastName2Buffer(lastname2);

        public void SetStaticEmail(string email) => new ModelUser().SetEmailBuffer(email);

        public void SetStaticPhoneNumber(int phonenumber) => new ModelUser().SetPhoneNumberBuffer(phonenumber);

        public void SetStaticPassword(string password) => new ModelUser().SetPasswordBuffer(password);

        public void SetStaticRole(string role) => new ModelUser().SetPasswordBuffer(role);
        #endregion
        #region GetStatic
        public string StaticUsername => new ModelUser().GetUsernameBuffer();

        public string StaticName => new ModelUser().GetNameBuffer();

        public string StaticLastName => new ModelUser().GetLastNameBuffer();

        public string StaticLastName2 => new ModelUser().GetLastName2Buffer();

        public string StaticEmail => new ModelUser().GetEmailBuffer();

        public int StaticPhoneNumber => new ModelUser().GetPhoneNumberBuffer();

        public string StaticPassword => new ModelUser().GetPasswordBuffer();

        public string StaticRole => new ModelUser().GetRoleBuffer();
        #endregion



    }
}

