using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class EventControler
    {
        public EventControler()
        {
        }
        public DataTable GetEventDataTable() => new ModelEvents().GetEventDataTable();

        public static void Alta(string name, string startDate, string endDate, int stageid)
        {
            ModelEvents e = new ModelEvents
            {
                Name = name,
                StartDate = startDate,
                EndDate= endDate,
                StageId = stageid
            };
            e.Save();
        }
        public static void Modificar(int id, string name, string startDate, string endDate, int stageid)
        {
            ModelEvents e = new ModelEvents(id)
            {
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                StageId = stageid
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelEvents(id).Delete(id);

        public static void AltaParents(int Id, int ParentId, string type, string Info)
        {
            ModelEvents e = new ModelEvents
            {
                ID = Id,
                ParentId = ParentId,
                Type = type,
                Info = Info
            };
            e.InsertParents();
        }
    }
}
