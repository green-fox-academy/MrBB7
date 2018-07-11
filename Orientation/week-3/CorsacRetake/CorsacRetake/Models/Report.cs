using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacRetake.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
