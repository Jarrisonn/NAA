using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;
using NationalAdmissionAgency.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Services.Service
{
    public class ApplicationService : IApplicationService
    {
        private IApplicationDAO applicationDAO;

        public ApplicationService()
        {
            applicationDAO= new ApplicationDAO();
        }
        public IList<Application> GetApplications()
        {
            using (var context = new NAAContext())
            {
                return applicationDAO.GetApplications(context);
            }
        }
    }
}
