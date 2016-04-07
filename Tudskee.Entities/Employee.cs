using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public enum EmployeeType
    {
        Regular,
        Contractual,
        OJT
    }

    public class Employee : IEntityBase
    {
        public Employee()
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

        //Employee Fields
        public string EmployeeID { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        
        //Person Reference
        public int PersonID { get; set; }

        public Person PersonDetails { get; set; }
        

    }
}
