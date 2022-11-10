using CapaDeDatos;

namespace CapDeDatos
{
    public class SafeUserData
    {
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static int PhoneNumber { get; set; }
        public static string LastName { get; set; }
        public static string LastName2 { get; set; }
        public static string Role { get; set; }
        public static string City { get; set; }
        public static string Street { get; set; }
        public static int Num { get; set; }
        public static string State { get; set; }
        public static string Country { get; set; }


        public void getData(string name) => new ModelUser().GetUserDataForUserName(name);
    } 
}
