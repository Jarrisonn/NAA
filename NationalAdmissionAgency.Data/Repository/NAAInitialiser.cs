using NationalAdmissionAgency.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Data.Repository
{
   public class NAAInitialiser:
        System.Data.Entity.DropCreateDatabaseIfModelChanges<NAAContext>
    {
        protected override void Seed(NAAContext context)
        {
            User user1 = new User()
            {
                UserId = "1",
                Name = "Test",
                Address = "Test",
                Phone = "Test",

            };
            University university1 = new University()
            {
                UniversityId = 1,
                Name = "Test University",
            };
            Application application1 = new Application()
            {
                ApplicationId = 1,
                Course = "Test",
                Firm = false,
                Offer = "Test",
                Statement = "Test statement",
                TeacherContact = "test",
                TeacherReference = "test"
            };
            context.Applications.Add(application1);
            context.Universities.Add(university1);
            context.Users.Add(user1);
            context.SaveChanges();
        }
    }
}
