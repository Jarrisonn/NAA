﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Data.Models.Domain
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

        public virtual ICollection<University> Universities { get; set; }
    }
}
