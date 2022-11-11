using NewAPIResult.Models;
using System.Data;
using System.Web.Http;

namespace NewAPIResult.Controller
{
    public class EventIdController : ApiController
    {
        [HttpPost]
        public DataTable GetEventIdByDate([FromBody] PageRequest r)
        {
            r.PageNumber = (r.PageNumber - 1) * 5;
            EventIdModel e = new EventIdModel();
            return e.PopulatePlayer(r.SportId, r.PageNumber);
        }
    }
}
