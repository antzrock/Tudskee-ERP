using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class EmploymentHistory : IEntityBase
    {
        public EmploymentHistory()
        {
            IsActive = true;
        }

        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool IsActive { get; set; }

        public byte[] RowVersion { get; set; }

        //Employment History Fields
        public string CompanyName { get; set; }

        public Address CompanyAddress { get; set; }

        public string Position { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        
    }
}
