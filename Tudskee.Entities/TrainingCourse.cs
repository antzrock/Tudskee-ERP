using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public enum DurationUnit
    {
       second,
       minute,
       hour,
       day,
       week,
       month,
       year
    }

    public class TrainingCourse : IEntityBase
    {
        public TrainingCourse()
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

        //Training Course Fields
        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public DurationUnit DurationUnit { get; set; }


    }
}
