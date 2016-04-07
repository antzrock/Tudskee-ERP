using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    //Enumerations
    public enum DependentRelationship
    {
        Spouse,
        Son,
        Daughter,
        Mother,
        Father
    }       

    public class PersonDependents : IEntityBase
    {
        public PersonDependents()
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

        //Person Reference
        public int PersonID { get; set; }

        public Person Person { get; set; }

        //Person dependent fields
        public string Lastname { get; set; }
        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string NameSuffix { get; set; }

        public DateTime Birthday { get; set; }

        public Sex Sex { get; set; }

        public bool WithPermanentDisability { get; set; }

        public DependentRelationship Relationship { get; set; }
    }
}
