using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using NewAPIResult.Models;

namespace NewAPIResult
{
    public class PlayerController : ApiController
    {
        [HttpPost]
        public Dictionary<int, PlayerTemp> GetAllPlayer([FromBody] JsonRequest p)
        {
            ModelPlayer model = new ModelPlayer();
            return model.PopulatePlayer((p.PageNumber));
        }
        [HttpPost]
        public Dictionary<int, PlayerTemp> GetNamedPlayer([FromBody] JsonRequest p)
        {
            ModelPlayer model = new ModelPlayer();
            return model.PopulatePlayer((p.SearchBarContent));
        }
        [HttpPost]
        public Dictionary<int, PlayerTemp> GetPlayerById([FromBody] IdRequest r)
        {
            ModelPlayer model = new ModelPlayer();
            return model.PopulatePlayerById(r.Id);
        }
    }
}
