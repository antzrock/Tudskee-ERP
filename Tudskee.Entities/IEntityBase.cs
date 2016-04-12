﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Entities
{
    public interface IEntityBase
    {
        int Id { get; set; }

        int CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        int? UpdatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        bool IsActive { get; set; }

        byte[] RowVersion { get; set; }
    }
}
