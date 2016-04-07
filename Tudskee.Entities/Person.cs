using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    //Enumerations
    public enum Sex
    {
        Male,
        Female
    }

    public enum CivilStatus
    {
        Single,
        Married,
        LegallySeparated,
        Widow,
        Widower
    }

    public class Person : IEntityBase
    {
        public Person()
        {
            PermanentAddress = new Address();
            CurrentAddress = new Address();
            Dependents = new List<PersonDependents>();
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

        public bool IsActive { get; set; }

        public byte[] RowVersion { get; set; }

        //Person Fields

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string NameSuffix { get; set; }

        public DateTime Birthday { get; set; }

        public Sex Sex { get; set; }

        //Permanent Address
        public Address PermanentAddress { get; set; }

        //Current Address
        public Address CurrentAddress { get; set; }

        public CivilStatus CivilStatus { get; set; }

        //Contact Information Reference
        public ICollection<ContactInformation> ContactInformation { get; set; }

        //Dependents
        public virtual ICollection<PersonDependents> Dependents { get; set; }
        
        //Government Mandated Information
        public GovernmentMandatedInformation GovernmentMandatedInformation { get; set; }

        //Educational Background
        public virtual ICollection<EducationalBackground> EducationalBackground { get; set; }

        //User Reference
        public int? UserID { get; set; }
        
        public virtual User User { get; set; } 
        
        //Employee Reference
        public int? EmployeeID { get; set; }
        
        public virtual Employee EmployeeDetails { get; set; }  
        
    }
}
