using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiResults.Models
{
    public class JsonRequest
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string SearchBarContent { get; set; }

    }
}