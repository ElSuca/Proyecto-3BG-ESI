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
    public class ManagerController : ApiController
    {
        [HttpPost]
        public DataTable GetAsocInfoByPage([FromBody] PageRequest r)
        {
            ManagerModel asoc = new ManagerModel();
            return asoc.PopulateManagerByPage(r.PageNumber);
        }
        [HttpPost]
        public DataTable GetAsocInfoById([FromBody] IdRequest r)
        {
            ManagerModel asoc = new ManagerModel();
            return asoc.PopulateManagerById(r.Id);
        }
    }
}
