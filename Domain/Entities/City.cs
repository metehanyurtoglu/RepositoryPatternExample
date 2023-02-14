using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : Base<long>
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public long CountryId { get; set; }
        public Country Country { get; set; }
    }
}
