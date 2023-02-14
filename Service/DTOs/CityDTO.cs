using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class CityDTO
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public long CountryId { get; set; }
        public CountryDTO Country { get; set; }
    }
}
