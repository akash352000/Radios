using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcRadios.Models
{
    public class radios
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string company { get; set; }
        public decimal Price { get; set; }
        public string type { get; set; }
        public decimal Generation { get; set; }

    }
}
