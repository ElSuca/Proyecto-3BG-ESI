using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAPIResult.Models
{
    public class MainP
    {
        public List<int> Scores { get; set; }
        public HashSet<int> Teams { get; set; }
        public string Sport { get; set; }
        public string EventName { get; set; }
        public int EventId { get; set; }
        public List<string> Timed { get; set; }
    }
}
