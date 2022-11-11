using NewAPIResult.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web.Http;

namespace NewAPIResult.Controller
{
    public class EventIdController : ApiController
    {
        [HttpPost]
        public HashSet<int?> GetEventIdByDate([FromBody] PageRequest r)
        {
            r.PageNumber = (r.PageNumber - 1) * 5;
            EventIdModel e = new EventIdModel();
            return e.PopulatePlayer(r.SportId, r.PageNumber);
        }
    }
}
