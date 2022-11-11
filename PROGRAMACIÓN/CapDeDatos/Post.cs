namespace CapDeDatos
{
    public class PostAut 
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class PostAd
    {
        public string Category { get; set; }
    }
    public class PostResultPageSport
    {
        public int PageNumber { get; set; }
        public int SportId { get; set; }
    }
}
