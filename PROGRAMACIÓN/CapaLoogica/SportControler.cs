using System;
using System.Collections.Generic;
using System.Data;
using CapDeDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLoogica
{
   public class SportControler
    {
        public SportControler()
        {
        }
        public DataTable GetEventData(string Eventname) => new ModelSport().eventTable(Eventname);
        public DataTable GetSimpifiedEventData() => new ModelSport().ejecutarComando();
    }
}
