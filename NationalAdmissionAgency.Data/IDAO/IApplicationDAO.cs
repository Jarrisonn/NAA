using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Data.IDAO
{
    public interface IApplicationDAO
    {
        IList<Application> GetApplications(NAAContext context);
    }
}
