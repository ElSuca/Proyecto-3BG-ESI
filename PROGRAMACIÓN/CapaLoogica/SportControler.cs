using System.Data;
using CapDeDatos;

namespace CapaLoogica
{
    public class SportControler
    {
        public SportControler()
        {
        }
        public DataTable GetEventData(string Eventname) => new ModelSport().eventTable(Eventname);
        public DataTable GetSimpifiedEventData() => new ModelSport().GetAllEventDataForTable();
        public DataTable GetPlayerData(string PlayerName) => new ModelSport().playerTable(PlayerName);
    }
}
