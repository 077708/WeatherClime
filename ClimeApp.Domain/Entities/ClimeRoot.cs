using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimeApp.Domain.Entities
{
    public class ClimeRoot
    {
        public Coord Coord { get; set; }
        public Main Main { get; set; }
        public Sys Sys { get; set; }
        public List<weather> weather { get; set; }
        public Wind Wind { get; set; }
    }
}
