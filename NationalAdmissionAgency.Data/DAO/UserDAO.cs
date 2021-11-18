using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NationalAdmissionAgency.Data.DAO
{
    public class UserDAO : IUserDAO
    {
        private NAAContext context;
        public Application application;
        public UserDAO()
        {
            context = new NAAContext();
        }

        public IList<Application> GetApplications(string id, NAAContext context)
        {
            context.Users.Include(g => g.Applications).ToList();

            User user = context.Users.Find(id);

            return user.Applications.ToList();

        }

        public User GetUser(string id, NAAContext context)
        {
            context.Users.Include(g => g.Applications).ToList();
            context.Users.Include(g => g.Universities).ToList();

            return context.Users.Find(id);
        }

        public User GetUserInt(int id, NAAContext context)
        {
            context.Users.Include(g => g.Applications).ToList();
            context.Users.Include(g => g.Universities).ToList();

            return context.Users.Find(id);
        }

        public IList<User> GetUsers(NAAContext context)
        {
            return context.Users.ToList();
        }

        public IList<University> GetUniversities(string id, NAAContext context)
        {
            context.Users.Include(g => g.Universities).ToList();
            User user = context.Users.Find(id);
            return user.Universities.ToList();


        }

        public Application GetApplication(int id, NAAContext context)
        {
            Application application = context.Applications.Find(id);

            return application;
        }
        public University GetUniversity(int id, NAAContext context)
        {
            University university = context.Universities.Find(id);

            return university;
        }

        public void AddUser(User user, NAAContext context)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user, NAAContext context)
        {
            User userToUpdate = GetUser(user.UserId, context);
            context.Entry(userToUpdate).CurrentValues.SetValues(user);
            context.SaveChanges();
        }

        public void DeleteUser(string id, NAAContext context)
        {
            User user = GetUser(id, context);
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
