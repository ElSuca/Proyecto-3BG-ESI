using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLoogica
{
    public class TeamControler
    {
        public DataTable GetTeamDataTable() => new ModelTeam().GetTeamDataTable();
        public static void Eliminar(int id) => new ModelTeam(id).Delete(id);
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
        public static void Modificar(int id,string name, string city, string state, string country)
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
    }
}
