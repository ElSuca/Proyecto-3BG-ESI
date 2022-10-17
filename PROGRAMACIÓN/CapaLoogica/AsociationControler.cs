using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class AsociationControler
    {
        public AsociationControler()
        {
        }
        public DataTable GetAsociationDataTable() => new ModelAsociation().GetAsociationDataTable();

        public static void Alta(string name,string status,string city, string street, int num, string state, string country, string startDate,string endDate, int sport,string category,int quantity)
        {
            ModelAsociation e = new ModelAsociation
            {
                Name = name,
                Status = status,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country,
                StartDate = startDate,
                EndDate = endDate,
                Sport = sport,
                Category = category,
                Quantity = quantity
            };
            e.Save();
        }
        public static void Modificar(int id, string name, string status, string city, string street, int num, string state, string country)
        {
            ModelAsociation e = new ModelAsociation(id)
            {
                Name = name,
                Status = status,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelAsociation(id).Delete(id);
    }
}
