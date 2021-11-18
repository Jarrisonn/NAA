using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Services.IService
{
    public interface IUserService
    {
        IList<User> GetUsers();

        User GetUser(string id);

        User GetUserInt(int id);

        IList<Application> GetApplications(string id);

        IList<University> GetUniversities(string id);

        Application GetApplication(int id);

        University GetUniversity(int id);

        void AddUser(User user);

        void UpdateUser(User user, string id);

        void DeleteUser(string id);
    }
}
