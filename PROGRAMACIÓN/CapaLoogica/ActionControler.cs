using CapDeDatos;
using System.Data;

namespace CapaLoogica
{
    public class ActionControler
    {
        public ActionControler()
        {
        }
        public DataTable GetActionDataTable() => new ModelAction().GetActionDataTable();

        public static void Alta(int idTeam, int idPlayer, int idTime, int quantity, string type, string context, string time,string category,string playerRole)
        {
            ModelAction e = new ModelAction
            {
                IdTeam = idTeam,
                IdPlayer = idPlayer,
                IdTime = idTime,
                Quantity = quantity,
                Type = type,
                Context = context,
                Category = category,
                Time = time,
                PlayerRole = playerRole
            };
            e.Save();
        }
        public static void Modify(int id, int idTeam, int idPlayer, int idTime, int quantity, string type, string context, string time, string category)
        {
            ModelAction e = new ModelAction(id)
            {
                IdTeam = idTeam,
                IdPlayer = idPlayer,
                IdTime = idTime,
                Quantity = quantity,
                Type = type,
                Context = context,
                Category = category,
                Time = time
            };
            e.Save();
        }
        public static void Delete(int id) => new ModelAction(id).Delete(id);

        public bool ExistAction(int id) => new ModelAction().ExistAction(id);
        public int GetId(string Name) => new ModelAction().GetId(Name);
        public bool HaveChange(int id) => new ModelAction().HaveChange(id);
    }
}

