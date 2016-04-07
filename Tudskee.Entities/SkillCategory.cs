﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public class SkillCategory : IEntityBase
    {
        public SkillCategory()
        {
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

        //Skill Category Fields
        public string Name { get; set; }

        public string Description { get; set; }

        //Skill Reference
        public ICollection<Skill> Skills { get; set; }
    }
}
