﻿using Limak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limak.Areas.Admin.ViewModels
{
    public class AdminIndexViewModel
    {
        public string CurrentUserId { get; set; }
        public List<ApplicationUser> Admins { get; set; }
    }
}
