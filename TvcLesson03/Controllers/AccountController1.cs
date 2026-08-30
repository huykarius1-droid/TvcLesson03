using Microsoft.AspNetCore.Mvc;
using MyAppMVC.Models;

namespace TvcLesson03.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Index()
        {
            using System;
            using System.Collections.Generic;
            using Microsoft.AspNetCore.Mvc;
            using MyAppMVC.Models;

namespace MyAppMVC.Controllers
    {
        public class AccountController : Controller
        {
            public IActionResult Index()
            {
                List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1, Name = "Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/02.jfif"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 2, Name = "Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.jfif"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3, Name = "Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/04.jfif"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
            };

                ViewBag.Accounts = accounts;
                return View();
            }
        }
    }