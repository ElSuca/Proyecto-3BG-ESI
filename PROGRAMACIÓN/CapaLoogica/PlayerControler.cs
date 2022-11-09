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
        public static void Modificar(int id, string name, string lastname1, string lastname2, string status, string birthDate, string city, string state, string country)
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
        public static void Eliminar(int id) => new ModelPlayer(id).Delete(id);


        public static void AltaParents(int id, int idAsoc, string startDate, string endDate)
        {
            ModelPlayer e = new ModelPlayer
            {
                Id = id,
                IdAsoc =  idAsoc,
                StartDate = startDate,
                EndDate = endDate
            };
            e.InsertAsociation();
        }
        public bool ExistPlayer(int id) => new ModelPlayer().ExistPlayer(id);
        public int GetId(string Name) => new ModelPlayer().GetId(Name);
        public bool HaveChange(int id) => new ModelPlayer().HaveChange(id);
        public DataTable GetUserNameByTeam(string name) => new ModelPlayer().GetNameByTeam(name);
        //  public List<ModelPlayer> GetAllPlayer() => new ApiPlayerController().GetAllPlayer();
    }
}
