using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
namespace NewAPIResult
{
    public class PlayerController : ApiController
    {
        [HttpPost]
        public DataTable GetAllPlayer([FromBody] JsonRequest p)
        {
            ModelPlayer model = new ModelPlayer();
            return model.PopulatePlayer((p.PageNumber));
        }
        [HttpPost]
        public DataTable GetNamedPlayer([FromBody] JsonRequest p)
        {
            ModelPlayer model = new ModelPlayer();
            return model.PopulatePlayer((p.SearchBarContent));
        }

    }
}
