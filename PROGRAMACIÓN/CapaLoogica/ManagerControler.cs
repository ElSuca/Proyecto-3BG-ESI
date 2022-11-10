using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class ManagerControler
    {
        public DataTable GetManagerDataTable() => new ModelManager().GetManagerDataTable();

        public static void Alta(string name, string lastname1, string lastname2, string status, string birthDate, string state, string country,int idAsociation,string startDate,string endDate)
        {
            ModelManager e = new ModelManager
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,
                State = state,
                Country = country,
                IdAsociation = idAsociation,
                StartDateAsociation = startDate,
                EndDateAsociation = endDate
            };
            e.Save();
        }
        public static void Modify(int id, string name, string lastname1, string lastname2, string status, string birthDate, string state, string country)
        {
            ModelManager e = new ModelManager(id)
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,  
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelManager(id).Delete(id);
        public bool ExistManager(int id) => new ModelManager().ExistManager(id);
        public int GetId(string Name) => new ModelManager().GetId(Name);
        public bool HaveChange(int id) => new ModelManager().HaveChange(id);

    }
}

