using NationalAdmissionAgency.Data.Models.Domain;
using NationalAdmissionAgency.Services.IService;
using NationalAdmissionAgency.Services.Models;
using NationalAdmissionAgency.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NationalAdmissionsAgency.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        // GET: User
        public UserController()
        {
            userService = new UserService();
        }
        public ActionResult GetApplication(int id)
        {
            return View(userService.GetApplication(id));
        }
        public ActionResult GetUniversity(int id)
        {
            return View(userService.GetUniversity(id));
        }
        public ActionResult GetUsers()
        {
            return View(userService.GetUsers());
        }
        public ActionResult GetUser(string id)
        {
            return View(userService.GetUser(id));
        }
        public ActionResult GetApplications(string id)
        {
            return View(userService.GetApplications(id));
        }
        public ActionResult GetUniversities(string id)
        {
            return View(userService.GetUniversities(id));
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult AddUser()
        {
            
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            try
            {
                // TODO: Add insert logic here
                userService.AddUser(user);
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult UpdateUser(string id)
        {
            User user = userService.GetUser(id);
            User newUser = new User();
            newUser.Name = user.Name;
            newUser.Phone = user.Phone;
            newUser.UserId = user.UserId;
            newUser.Address = user.Address;
            newUser.Applications = user.Applications;
            newUser.Universities = user.Universities;
            return View(newUser);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, User user)
        {
            try
            {
                // TODO: Add update logic here
                userService.UpdateUser(user, id);
                return RedirectToAction("GetUsers", "User");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult DeleteUser(string id)
        {

            return View(userService.GetUser(id));
        }
















        // POST: User/Delete/5
        [HttpPost]
        public ActionResult DeleteUser(string id, User user)
        {
            try
            {
                // TODO: Add delete logic here
                userService.DeleteUser(id);
                return RedirectToAction("GetUsers", "User");
            }
            catch
            {
                return View();
            }
        }
    }
}
