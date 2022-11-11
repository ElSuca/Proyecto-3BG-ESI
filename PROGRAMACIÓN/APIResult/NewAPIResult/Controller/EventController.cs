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
    public class EventController : ApiController
    {
        [HttpPost]
        public DataTable GetEventByPage([FromBody] PageRequest r)
        {
            EventModel @event = new EventModel();
            return @event.PopulateEventByPage(r.PageNumber);
        }
        [HttpPost]
        public DataTable GetEventById([FromBody] IdRequest r)
        {
            EventModel @event = new EventModel();
            return @event.PopulateEventById(r.Id);
        }
        
    }
}
