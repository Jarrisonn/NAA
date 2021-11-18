using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Services.IService;
using NationalAdmissionAgency.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NationalAdmissionsAgency.Controllers
{
    public class Helper
    {
        private IUserService userService;
        private IApplicationService applicationService;
        
        public Helper()
        {
            userService = new UserService();
            applicationService = new ApplicationService();
        }

        public List<MultiSelectList> GetMultiApplication()
        {
            List<MultiSelectList> applications = new List<MultiSelectList>();
            IList<Application> applications1 = applicationService.GetApplications();


            applications.Add(new MultiSelectList(applications1));

            return applications;
           

                

           


        }
    }
}