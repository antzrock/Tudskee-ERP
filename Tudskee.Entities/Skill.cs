using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class Skill: IEntityBase
    {
        public Skill()
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

        //Skill Field
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        //Reference Skill Category
        public int SkillCategoryID { get; set; }

        public SkillCategory Category { get; set; }
                
    }
}
