using NationalAdmissionAgency.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Services.IService
{
    public interface IApplicationService
    {
        IList<Application> GetApplications();
    }
}
