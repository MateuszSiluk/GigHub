﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigHub.Repo
{
    public class ApplicationUser : IdentityUser
    {
        public virtual string Id { get; set; } // example, not necessary
    }
}
