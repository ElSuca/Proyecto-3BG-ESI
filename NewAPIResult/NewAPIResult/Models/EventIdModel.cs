using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class EventIdModel : Model
    {
        public DataTable PopulatePlayer(int s, int p)
        {
            this.command.CommandText = $"SELECT ID FROM EVENT LEFT JOIN (EVENT_SPO) ON (EVENT.ID = EVENT_SPO.ID_EVENT) WHERE EVENT_SPO.ID_SPO=@S ORDER BY EVENT.STARTDATE LIMIT 5 OFFSET @P";
            this.command.Parameters.AddWithValue("@S", s);
            this.command.Parameters.AddWithValue("@P", p);
            this.command.Prepare();
            this.dataReader = this.command.ExecuteReader();
            this.dataReader.Read();
            DataTable t = new DataTable();
            t.Load(this.dataReader);
            return t;
        }
    }
}
