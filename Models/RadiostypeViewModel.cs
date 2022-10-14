using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcRadios.Models
{
    public class RadiostypeViewModel
    {
        public List<radios> Radios { get; set; }
        public SelectList type { get; set; }
        public string Radiotype { get; set; }
        public string SearchString { get; set; }
    }
}
