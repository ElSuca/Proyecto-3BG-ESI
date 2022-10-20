using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class EventControler
    {
        public EventControler()
        {
        }
        public DataTable GetEventDataTable()
        {
            // if(new ModelEvents().HaveFamily()) return new ModelEvents().GetEventDataTableWithFamily();
            // else
            return new ModelEvents().GetEventDataTableWithFamily();
            //return new ModelEvents().GetEventDataTable();
        }

        public static void Alta(string name, string startDate, string endDate, int stageid, int timeNumber, string timeDescription)
        {
            ModelEvents e = new ModelEvents
            {
                Name = name,
                StartDate = startDate,
                EndDate= endDate,
                StageId = stageid,
                TimeDescription = timeDescription,
                TimeNumber = timeNumber
            };
            e.Save();
        }
        public static void Modificar(int id, string name, string startDate, string endDate, int stageid, int timeNumber, string timeDescription)
        {
            ModelEvents e = new ModelEvents(id)
            {
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                StageId = stageid,
                TimeDescription = timeDescription,
                TimeNumber = timeNumber
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelEvents(id).Delete(id);

        public static void AltaParents( int ParentId, string type, string Info)
        {
            ModelEvents e = new ModelEvents
            {
                ParentId = ParentId,
                Type = type,
                Info = Info
            };
            e.SaveParents();
        }
    }
}
