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
    public class MainController : ApiController
        {
        [HttpPost]
        public DataTable GetMain([FromBody] MainRequest r)
        {
            MainPageModel m = new MainPageModel();
            return m.PopulateMainAsScore(r.Id, r.Sport);
        }
        [HttpPost]
        public DataTable GetMainAsTimed([FromBody] MainRequest r)
        {
            MainPageModel m = new MainPageModel();
            return m.PopulateMainAsTimed(r.Id, r.Sport);
        }
    }
}
