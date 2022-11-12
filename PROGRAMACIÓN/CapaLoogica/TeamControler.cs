using CapDeDatos;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;

namespace CapaLoogica
{
    public class TeamControler : ApiController
    {
        public DataTable GetTeamDataTable() => new ModelTeam().GetTeamDataTable();
        public static void Delete(int id) => new ModelTeam(id).Delete(id);
        public static void Alta(string name,string city,string state, string country)
        {
            ModelTeam p = new ModelTeam
            {
                Name = name,
                City = city,
                State = state,
                Country = country
            };
            p.Save();
        }
        public static void Alta(string name, string city, string state, string country,int idAsoc)
        {
            ModelTeam p = new ModelTeam
            {
                Name = name,
                City = city,
                State = state,
                Country = country,
                IdAsociation = idAsoc
            };
            p.Save();
        }
        public static void Modify(int id,string name, string city, string state, string country)
        {
            ModelTeam p = new ModelTeam(id)
            {
                Name = name,
                City = city,
                State = state,
                Country = country
            };
            p.Save();
        }
        public bool ExistTeam(int id) => new ModelTeam().ExistTeam(id);
        public int GetId(string Name) => new ModelTeam().GetId(Name);
        public string GetName(int id) => new ModelTeam().GetName(id);
        public bool HaveChange(int id) => new ModelTeam().HaveChange(id);



        [HttpPost]
        public Dictionary<int, ModelTeam> GetTeamInfoByPage([FromBody] SafeSystemBuffer r) => new ModelTeam().PopulateTeamByPage(r.PageNumber);
        [HttpPost]
        public Dictionary<int, ModelTeam> GetTeamInfoById([FromBody] SafeSystemBuffer r) => new ModelTeam().PopulateTeamById(r.Id);
    }
    
}
