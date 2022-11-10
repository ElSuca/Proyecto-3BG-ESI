using System.Data;
using CapaDeDatos;
using CapaLoogica;

namespace CapaLogica
{
    public class UserControler
    {
        #region FuncionesBasicas  
        public static void Alta(string name,string lastName1,string lastName2,string email,string username,string role,string password,int phoneNumber,string city,string street,int num,string state,string country)
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
                UserRole = role,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            p.Save();
        }

        public static void Modify(int id, string name, string lastName1, string lastName2, string email, string username, string role, string password, int phoneNumber, string city, string street, int num, string state, string country)
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
                UserRole = role,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            p.Save();
        }
        public static void Delete(int id) => new ModelUser(id).Delete(id);
        #endregion
        public bool ExistUser(string Username) => new ModelUser().ExistUser(Username);
        public bool HaveChange(string Username) => new ModelUser().HaveChange(Username);
        #region GetId
        public int GetId(string Name) => new ModelUser().GetId(Name);
        #endregion
        public static bool Autenticar(string nombre, string password)
        {
            ModelUser u = new ModelUser();
            u.SetUsernameBuffer(nombre);
            return u.Autenticar(password);
        }
        public DataTable GetUserDataTable() => new ModelUser().GetUserDataTable();
        #region get
        public string GetEmail() => new ModelUser().Email;

        public string GetUsername() => new ModelUser().UserName;

        public DataTable getSubscriptionIndex(int id) => new ModelUser().GetSubscriptionIndex(id);

        public void SetFamilySubscription(string FamilyName, int UserId) => new ModelUser().InsertFamilySubscription(new FamilyControler().GetId(FamilyName), UserId);
        #endregion
        #region SetStatic
        public void SetStaticUserData(string name) => new ModelUser().GetUserDataForUserName(name);

        public void SetStaticUsername(string name) => new ModelUser().SetUsernameBuffer(name);

        public void SetStaticName(string name) => new ModelUser().SetUsernameBuffer(name);

        public void SetStaticLastName(string lastname) => new ModelUser().SetLastNameStaticBuffer(lastname);

        public void SetStaticLastName2(string lastname2) => new ModelUser().SetLastName2StaticBuffer(lastname2);

        public void SetStaticEmail(string email) => new ModelUser().SetEmailStaticBuffer(email);

        public void SetStaticPhoneNumber(int phonenumber) => new ModelUser().SetPhoneNumberStaticBuffer(phonenumber);

        public void SetStaticPassword(string password) => new ModelUser().SetPasswordStaticBuffer(password);

        public void SetStaticRole(string role) => new ModelUser().SetRoleStaticBuffer(role);

        public void SetStaticCity(string city) => new ModelUser().SetCityStaticBuffer(city);

        public void SetStaticStreet(string street) => new ModelUser().SetStreetStaticBuffer(street);

        public void SetStaticNum(int num) => new ModelUser().SetNumStaticBuffer(num);

        public void SetStaticState(string state) => new ModelUser().SetStateStaticBuffer(state);

        public void SetStaticCountry(string country) => new ModelUser().SetCountryStaticBuffer(country);
        #endregion
        #region GetStatic
        public string GetStaticUsername => new ModelUser().GetUsernameBuffer();

        public string GetStaticName => new ModelUser().GetNameBuffer();

        public string GetStaticLastName => new ModelUser().GetLastNameBuffer();

        public string GetStaticLastName2 => new ModelUser().GetLastName2Buffer();

        public string GetStaticEmail => new ModelUser().GetEmailBuffer();

        public int GetStaticPhoneNumber => new ModelUser().GetPhoneNumberBuffer();

        public string GetStaticPassword => new ModelUser().GetPasswordBuffer();

        public string GetStaticRole => new ModelUser().GetRoleBuffer();

        public string GetStaticCity => new ModelUser().GetCityBuffer();

        public string GetStaticStreet => new ModelUser().GetStreetBuffer();

        public int GetStaticNum => new ModelUser().GetNumBuffer();

        public string GetStaticState => new ModelUser().GetStateBuffer();

        public string GetStaticCountry => new ModelUser().GetCountryBuffer();
        #endregion
    }
}

