using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ApiResults.Models;
using System.Data;
namespace ApiResults.Controllers
{
    public class PlayerController : ApiController
    {


        
        [HttpPost]

        public List<ModelPlayer> GetAllPlayer([FromBody] JsonRequest p)
        {
            List<ModelPlayer> players = new List<ModelPlayer>();
            for (int i = 1 + ((p.PageNumber - 1) * 5); i < p.PageNumber * 5; i++)
            {
                ModelPlayer player = new ModelPlayer();
                player.PopulatePlayer(i);
                players.Add(player);
            }
            return players;
        }


    }
}
