﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediClinic.Domain.Models.Entities.Membership
{
    public class MediClinicUser : IdentityUser<int>
    {
        public string ImgUrl { get; set; }
    }
}
