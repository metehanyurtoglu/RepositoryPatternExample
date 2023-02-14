using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class CountryDTO
    {
        public CountryDTO()
        {
            Cities = new List<CityDTO>();
        }

        public string Name { get; set; }
        public long Population { get; set; }

        public IEnumerable<CityDTO> Cities { get; set; }
    }
}
