using CapaDeDatos;

namespace CapDeDatos
{
    public class SafeUserData
    {
        public static string Username;
        public static string Name;
        public static string Password;
        public static string Email;
        public static int PhoneNumber;
        public static string LastName;
        public static string LastName2;
        public static string Role;
        #region get
        public string GetUsername()
        {
            setData(Username);
            return Username;
        }
        public string GetName() => Name;
        public string GetPassword() => Password;
        public string GetEmail() => Email;
        public int GetPhoneNumber() => PhoneNumber;
        public string GetLastName() => LastName;
        public string GetLastName2() => LastName2;
        public string GetRole() => Role;
        #endregion
        #region set
        public void SetUsername(string u) => Username = u;
        public void SetName(string u) => Name = u;
        public void SetPassword(string u) => Password = u;
        public void SetEmail(string u) => Email = u;
        public void SetPhoneNumber(int u) => PhoneNumber = u;
        public void SetLastName(string u) => LastName = u;
        public void SetLastName2(string u) => LastName2 = u;
        public void SetRole(string u) => Role = u;

        #endregion

        public void setData(string name) => new ModelUser().GetUserDataForUserName(name);
    } 
}
