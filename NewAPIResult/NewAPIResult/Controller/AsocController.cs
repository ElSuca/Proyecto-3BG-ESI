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
    public class AsocController : ApiController
    {
       [HttpPost]
       public DataTable GetAsocInfoByPage ([FromBody] PageRequest r)
        {
            AsocModel asoc = new AsocModel();
            return asoc.PopulateAsocByPage(r.PageNumber);
        }
        [HttpPost]
        public DataTable GetAsocInfoById([FromBody] IdRequest r)
        {
            AsocModel asoc = new AsocModel();
            return asoc.PopulateAsocById(r.Id);
        }

    }
}
