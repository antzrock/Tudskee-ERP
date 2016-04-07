using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class GovernmentMandatedInformation
    {
        public string SocialSecurityNumber { get; set; }

        public string TaxIdentificationNumber { get; set; }

        public string TaxRDOCode { get; set; }

        public string HealthInsuranceNumber { get; set; }

        public string HousingFundNumber { get; set; }
    }
}
