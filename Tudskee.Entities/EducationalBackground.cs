using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public enum EducationLevel
    {
        Elementary,
        HighSchool,
        College,
        Masters,
        Doctorate
    }

    public class EducationalBackground : IEntityBase
    {
        public EducationalBackground()
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

        //Educational Background Fields
        public string Schoolname { get; set; }

        public Address SchoolAddress { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string AwardsAndRecognition { get; set; }

        public EducationLevel EducationLevel { get; set; }

        //Person reference
        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}
