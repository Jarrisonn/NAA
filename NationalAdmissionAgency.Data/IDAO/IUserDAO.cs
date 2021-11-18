using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;

namespace NationalAdmissionAgency.Data.IDAO
{
    public interface IUserDAO
    { 
        IList<User> GetUsers(NAAContext context);

        User GetUser(string id, NAAContext context);

        User GetUserInt(int id, NAAContext context);
        IList<Application> GetApplications(string id, NAAContext context);

        IList<University> GetUniversities(string id, NAAContext context);

        Application GetApplication(int id, NAAContext context);

        University GetUniversity(int id, NAAContext context);

        void AddUser(User user, NAAContext context);

        void UpdateUser(User user, NAAContext context);

        void DeleteUser(string id, NAAContext context);
    }
}
