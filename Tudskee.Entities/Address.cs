using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class Address
    {
        public string UnitNo { get; set; }

        public string BuildingName { get; set; }

        public string Street { get; set; }

        public string Subdivision { get; set; }

        public string Barangay { get; set; }

        public Boolean IsCity { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Province { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

    }
}
