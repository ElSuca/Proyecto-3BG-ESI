using CapDeDatos;
using System.Collections.Generic;
using System.Web.Http;
namespace NewAPIResult
{
    public class ApiPlayerController : ApiController
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
