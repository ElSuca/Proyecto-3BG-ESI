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

        public static void Alta(string eventname, string date, string preevent)
        {
            ModelEvents e = new ModelEvents
            {
                EventName = eventname,
                Date = date,
                PreEvent = preevent,
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelEvents(id).Delete(id);
    }
}
