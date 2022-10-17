using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class StageControler
    {
        public DataTable GetStageDataTable() => new ModelStage().GetStageDataTable();

        public static void Alta(string city, string street, int num, string state,string country)
        {
            ModelStage e = new ModelStage
            {
                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Modificar(int id, string city, string street, int num, string state, string country)
        {
            ModelStage e = new ModelStage(id)
            {

                City = city,
                Street = street,
                Num = num,
                State = state,
                Country = country
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelFamily(id).Delete(id);
    }
}
