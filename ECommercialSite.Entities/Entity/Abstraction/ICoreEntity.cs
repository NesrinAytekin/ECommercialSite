﻿using ECommercialSite.Entities.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.Entities.Entity.Abstraction
{
    public interface ICoreEntity
    {
         int Id { get; set; }
         DateTime CreateDate { get; set; }
         DateTime? UpdateDate { get; set; }
         DateTime? DeleteDate { get; set; }
         Status Status { get; set; }


    }
}
