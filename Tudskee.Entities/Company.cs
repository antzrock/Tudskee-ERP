using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public enum CompanyType
    {
        Single,
        Parent,
        Branch,
        Affiliate,
        Division,
        Joint_Venture
    }

    public class Company : IEntityBase
    {
        public Company()
        {
            ContactInformation = new List<ContactInformation>();
            GovernmentMandatedInformation = new GovernmentMandatedInformation();
            IsActive = true;
        }

        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }

        public bool IsActive { get; set; }

        //Company Fields
        public string CompanyName { get; set; }
        
        public Address CompanyAddress { get; set; }

        public GeoLocation GeoLocation { get; set; }

        public CompanyType CompanyType { get; set; }

        //Government Mandated
        public GovernmentMandatedInformation GovernmentMandatedInformation { get; set; }
        
        //Contact Information Reference
        public ICollection<ContactInformation> ContactInformation { get; set; }

        //Parent Company
        public int? ParentCompanyID { get; set; }

        public virtual Company ParentCompany { get; set; }

        //Children
        public virtual ICollection<Company> Children { get; set; }
    }
}
