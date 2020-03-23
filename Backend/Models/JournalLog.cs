using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKTrace.Models
{
    public class JournalLog
    {
        public string id { get; set; }
        public string content { get; set; }
        public DateTime date_time { get; set; }
    }
}
