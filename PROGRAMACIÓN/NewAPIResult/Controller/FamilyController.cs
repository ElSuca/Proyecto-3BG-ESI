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
    public class FamilyController : ApiController
    {
        [HttpPost]
        public Dictionary<int, FamTemp> GetFamilyByPage([FromBody] PageRequest r)
        {
            FamilyModel @event = new FamilyModel();
            return @event.PopulateFamilyByPage(r.PageNumber);
        }
        [HttpPost]
        public Dictionary<int, FamTemp> GetFamilyById([FromBody] IdRequest r)
        {
            FamilyModel @event = new FamilyModel();
            return @event.PopulateFamilyById(r.Id);
        }
    }
}
