using CapDeDatos;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

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
                Sport_ = sport,
                Category = category,
                Quantity = quantity
            };
            e.Save();
        }
        public static void Modify(int id, string name, string status, string city, string street, int num, string state, string country, string startDate, string endDate, int sport, string category, int quantity)
        {
            ModelAsociation e = new ModelAsociation(id)
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
                Sport_ = sport,
                Category = category,
                Quantity = quantity
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelAsociation(id).Delete(id);
        public bool ExistAsociation(int id) => new ModelAsociation().ExistAsociation(id);
        public int GetId(string Name) => new ModelAsociation().GetId(Name);
        public bool HaveChange(int id) => new ModelAsociation().HaveChange(id);

       
    }
}
