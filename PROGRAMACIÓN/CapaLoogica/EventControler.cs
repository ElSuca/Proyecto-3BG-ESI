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
            return new ModelEvents().GetEventDataTable();
        }
        public DataTable GetEventFamilyDataTable()
        {
            return new ModelEvents().GetEventDataTableWithFamily();
        }

        public static void Alta(string name, string startDate, string endDate, int stageid, int timeNumber, string timeDescription)
        {
            ModelEvents e = new ModelEvents
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

        public static void AltaParents(int ParentId, string type, string Info, string Name)
        {
            ModelEvents e = new ModelEvents
            {
                ParentId = ParentId,
                Type = type,
                Info = Info,
                Name = Name
            };
            e.SaveParents();
        }
        public static void AltaTime(int EventId, int num, string Description)
        {
            ModelEvents e = new ModelEvents
            {
                ID = EventId,
                TimeNumber = num,
                TimeDescription = Description
            };
            e.InsertTime();
        }
        public bool ExistEvent(string name) => new ModelEvents().ExistEvent(name);
        public int GetId(string Name) => new ModelEvents().GetId(Name);
        public int GetIdTime(int num) => new ModelEvents().GetIdTime(num);
        public bool HaveChange(int id) => new ModelEvents().HaveChange(id);
    }
}
