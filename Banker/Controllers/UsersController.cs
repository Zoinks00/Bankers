using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banker.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository repo;

        public UsersController(IUserRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var users = repo.GetAllUsers();

            return View(users);
        }

        public IActionResult ViewUser(int id)
        {
            var users = repo.GetUsers(id);

            return View(users);
        }
    }
}
