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
    public class SportController
    {
        [HttpPost]
        public DataTable GetEventByPage([FromBody] PageRequest r)
        {
            SportModel @sport = new SportModel();
            return @sport.PopulateSportByPage(r.PageNumber);
        }
        [HttpPost]
        public DataTable GetEventById([FromBody] IdRequest r)
        {
            SportModel @sport = new SportModel();
            return @sport.PopulateSportById(r.Id);
        }
    }
}
