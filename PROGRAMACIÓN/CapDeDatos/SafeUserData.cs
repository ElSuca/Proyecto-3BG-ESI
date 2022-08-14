using CapaDeDatos;

namespace CapDeDatos
{
    public class SafeUserData
    {
        public static string Username;
        public static string Password;
        public static string Email;
        public static int PhoneNumber;
        public static string LastName;
        #region get
        public string GetUsername()
        {
            setData(Username);
            return Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetEmail()
        {
            return Email;
        }
        public int GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetLastName()
        {
            return LastName;
        }
#endregion
        #region set
        public void SetUsername(string u)
        {
            Username = u;
        } 
        public void SetPassword(string u)
        {
            Password = u;
        } 
        public void SetEmail(string u)
        {
            Email = u;
        } 
        public void SetPhoneNumber(int u)
        {
            PhoneNumber = u;
        }
        public void SetLastName(string u)
        {
            LastName = u;
        }
        #endregion

        public void setData(string name)
        {
            ModelUser mu = new ModelUser();
            mu.GetUserDataForUserName(name);
        }
    } 
}
