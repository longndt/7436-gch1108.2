using lab2b.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lab2b.Controllers
{
    public class UserController : Controller
    {
        public IActionResult User()
        {
            //declare objects of User model
            var user = new User
            {
                UserName = "demo 1",
                FullName = "User 1",
                Age = 25
            };

            //pass data to view using model
            return View(user);
        }

        public IActionResult UserList()
        {
            //declare objects of User model
            var user1 = new User
            {
                UserName = "demo 1",
                FullName = "User 1",
                Age = 25
            };
            var user2 = new User
            {
                UserName = "demo 2",
                FullName = "User 2",
                Age = 35
            };
            var user3 = new User
            {
                UserName = "demo 3",
                FullName = "User 3",
                Age = 45
            };
            //create a List of User object
            List<User> userList = new List<User> { user1, user2, user3 };

            //pass data to view using model
            return View(userList);
        }
    }
}
