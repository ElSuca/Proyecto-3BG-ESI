using CapDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLoogica
{
    public class JudgeControler
    {
        public DataTable GetJudgeDataTable() => new ModelJudge().GetJudgeDataTable();

        public static void Alta(string name, string lastName1, string lastName2, string city, string state, string country)
        {
            ModelJudge e = new ModelJudge
            {
                Name = name,
                LastaName1 = lastName1,
                LastaName2 = lastName2,
                City = city,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Modify(int id, string name, string lastaName1, string lastaName2, string city, string state, string country)
        {
            ModelJudge e = new ModelJudge(id)
            {
                Name = name,
                LastaName1 = lastaName1,
                LastaName2 = lastaName2,
                City = city,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelJudge(id).Delete(id);

        public bool ExistJudge(string name) => new ModelJudge().ExistJudge(name);
        public int GetId(string Name) => new ModelJudge().GetId(Name);
        public bool HaveChange(int id) => new ModelJudge().HaveChange(id);
    }
}
