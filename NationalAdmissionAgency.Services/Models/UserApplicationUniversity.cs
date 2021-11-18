using NationalAdmissionAgency.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Services.Models
{
    public class UserApplicationUniversity
    {
        [Key]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public IList<Application> applications { get; set; }

        public IList<University> universities { get; set; }
    }
}
