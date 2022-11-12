using CapDeDatos;
using System.Collections.Generic;
using System.Web.Http;

namespace CapaLoogica
{
    public class MainController : ApiController
    {
        [HttpPost]
        public Dictionary<int, MainPageModel> GetMain([FromBody] SafeSystemBuffer r)
        {
            MainPageModel m = new MainPageModel();
            return m.PopulateMainAsScore(r.IdMain, r.SportMain);
        }
        [HttpPost]
        public Dictionary<int, MainPageModel> GetMainAsTimed([FromBody] SafeSystemBuffer r)
        {
            MainPageModel m = new MainPageModel();
            return m.PopulateMainAsTimed(r.IdMain, r.SportMain);
        }
    }
}
