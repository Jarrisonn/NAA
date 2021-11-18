using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Data.DAO
{
    public class ApplicationDAO : IApplicationDAO
    {
        public IList<Application> GetApplications(NAAContext context)
        {
            return context.Applications.ToList();
        }
    }
}
