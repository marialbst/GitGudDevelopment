﻿using System.Collections.Generic;
using System.Linq;
using GitGud.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace GitGud.Controllers.Web
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IGitGudRepository _repository;
        //here to add everything that an admin can do
        //create categories, manage users etc.
        //first to find out how a user can take role=admin???

        public AdminController(IGitGudRepository repository)
        {
            _repository = repository;
        }

        public IActionResult AllUsers()
        {
            List<User> allUsers = _repository.GetAllUsers().ToList();
            return View(allUsers);
        }

        public IActionResult DeleteUser(string userId)
        {
            _repository.DeleteUser(userId);
            return RedirectToAction("AllUsers");
        }
    }
}
