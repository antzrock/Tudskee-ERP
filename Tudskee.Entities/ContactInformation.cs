using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    //Enumerations
    public enum ContactInformationType
    {
        Email,
        TelephoneNo,
        CellphoneNo,
        Facebook,
        LinkedIn,
        Website,
        Twitter
    }

    public class ContactInformation
    {
        public string ContactString { get; set; }
        public ContactInformationType ContactInformationType { get; set; }
    }
}
