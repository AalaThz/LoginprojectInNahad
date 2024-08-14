using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Models
{
    public class HostInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Decimal? Price{ get; set; }
        public long? BandWidth { get; set; }
        public int? OnlineSpace { get; set; }
        public bool Support { get; set; } 
    }
}
