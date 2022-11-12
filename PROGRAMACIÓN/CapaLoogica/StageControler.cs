using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class StageControler
    {
        public DataTable GetStageDataTable() => new ModelStage().GetStageDataTable();

        public static void Alta(string name, string city, string street, int num, string state,string country)
        {
            ModelStage e = new ModelStage
            {
                Name = name,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Modify(int id, string name, string city, string street, int num, string state, string country)
        {
            ModelStage e = new ModelStage(id)
            {
                Name = name,
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelStage(id).Delete(id);
        public bool ExistStage(int id) => new ModelStage().ExistStage(id);
        public int GetId(string Name) => new ModelStage().GetId(Name);
        public bool HaveChange(int id) => new ModelStage().HaveChange(id);
    }
}
