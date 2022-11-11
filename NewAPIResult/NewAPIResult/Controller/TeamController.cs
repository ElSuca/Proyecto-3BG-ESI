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
    public class TeamController : ApiController
    {
        [HttpPost]
        public DataTable GetTeamInfoByPage([FromBody] PageRequest r)
        {
            TeamModel team = new TeamModel();
            return team.PopulateTeamByPage(r.PageNumber);
        }
        [HttpPost]
        public DataTable GetTeamInfoById([FromBody] IdRequest r)
        {
            TeamModel team = new TeamModel();
            return team.PopulateTeamById(r.Id);
        }
    }
}
