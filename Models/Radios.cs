using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRadios.Models
{
    public class radios
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string company { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string type { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Generation { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }

    }
}
