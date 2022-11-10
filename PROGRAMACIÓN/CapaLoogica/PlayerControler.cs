using CapDeDatos;
using NewAPIResult;
using System.Collections.Generic;
using System.Data;

namespace CapaLoogica
{
    public class PlayerControler
    {
        public DataTable GetPlayerDataTable() => new ModelPlayer().GetPlayerDataTable();

        public static void Alta(string name,string lastname1, string lastname2, string status, string birthDate, string city, string state, string country)
        {
            ModelPlayer e = new ModelPlayer
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
        public static void Alta(string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country, int idAsoc, string startDate, string endDate)
        {
            ModelPlayer e = new ModelPlayer
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,
                City = city,
                State = state,
                Country = country,
                IdAsoc = idAsoc,
                StartDate = startDate,
                EndDate = endDate
            };
            e.Save();
        }
        public static void Modify(int id, string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country)
        {
            ModelPlayer e = new ModelPlayer(id)
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
        public static void Modify(int id, string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country, int idAsoc, string startDate, string endDate)
        {
            ModelPlayer e = new ModelPlayer(id)
            {
                Name = name,
                LastName1 = lastname1,
                LastName2 = lastname2,
                Status = status,
                BirthDate = birthDate,
                City = city,
                State = state,
                Country = country,
                IdAsoc = idAsoc,
                StartDate = startDate,
                EndDate = endDate
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelPlayer(id).Delete(id);


        
        public bool ExistPlayer(int id) => new ModelPlayer().ExistPlayer(id);
        public int GetId(string Name) => new ModelPlayer().GetId(Name);
        public bool HaveChange(int id) => new ModelPlayer().HaveChange(id);
        public DataTable GetUserNameByTeam(int id) => new ModelPlayer().GetNameByTeam(id);
        //  public List<ModelPlayer> GetAllPlayer() => new ApiPlayerController().GetAllPlayer();
    }
}
