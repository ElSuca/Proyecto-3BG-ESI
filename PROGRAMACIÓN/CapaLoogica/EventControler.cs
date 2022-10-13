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

        public static void Alta(string eventname, string eventdate,string stagename, string stagecity,string stagecountry,string stagestreet, int stagenum)
        {
            ModelEvents e = new ModelEvents
            {
                EventName = eventname,
                EventDate = eventdate,
                StageName = stagename,
                EventCity = stagecity,
                EventCountry = stagecity,
                EventStreet = stagestreet,
                EventNum = stagenum
            };
            e.Save();
        }
        public static void Eliminar(int id) => new ModelEvents(id).Delete(id);
    }
}
