using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country : Base<long>
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public string Name { get; set; }
        public long Population { get; set; }

        public IEnumerable<City> Cities { get; set; }
    }
}
