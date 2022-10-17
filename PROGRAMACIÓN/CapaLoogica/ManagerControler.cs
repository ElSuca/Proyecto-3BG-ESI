using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class ManagerControler
    {
        public DataTable GetManagerDataTable() => new ModelManager().GetManagerDataTable();

        public static void Alta(string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country)
        {
            ModelManager e = new ModelManager
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,
                City = city,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Modificar(int id, string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country)
        {
            ModelManager e = new ModelManager(id)
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,
                City = city,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelManager(id).Delete(id);


    }
}

