using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;
using NationalAdmissionAgency.Services.IService;
using NationalAdmissionAgency.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Services.Service
{
    public class UserService : IUserService
    {

       private IUserDAO userDAO;

        public UserService()
        {
            userDAO = new UserDAO();
        }

        public Application GetApplication(int id)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetApplication(id, context);
            }
        }
        public University GetUniversity(int id)
        {
            using(var context = new NAAContext())
            {
                return userDAO.GetUniversity(id, context);
            }
        }

        public IList<Application> GetApplications(string id)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetApplications(id, context);
            }
        }

        public IList<University> GetUniversities(string id)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUniversities(id, context);
            }
        }

        public User GetUser(string id)
        {
            using(var context = new NAAContext())
            {
                return userDAO.GetUser(id, context);
            }
        }
        public User GetUserInt(int id)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUserInt(id, context);
            }
        }

        public IList<User> GetUsers()
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUsers(context);
            }
        }
        public void AddUser(User user)
        {
            using(var context = new NAAContext())
            {

                User user1 = new User()
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Address = user.Address,
                    Phone = user.Phone,
                    Applications = user.Applications,
                    Universities = user.Universities,

                };                
                userDAO.AddUser(user1, context);
                
                
            }
        }
       

        public void UpdateUser(User user, string id)
        {
            using (var context = new NAAContext())
            {
                User newUser = new User();
                newUser = userDAO.GetUser(id, context);
                newUser.Name = user.Name;
                newUser.Phone = user.Phone;
                newUser.UserId = user.UserId;
                newUser.Address = user.Address;
                newUser.Applications = user.Applications;
                newUser.Universities = user.Universities;
                userDAO.UpdateUser(newUser, context);
            }
        }
        public void DeleteUser(string id)
        {
            using(var context = new NAAContext())
            {
                userDAO.DeleteUser(id, context);
            }
        }
    }
}
