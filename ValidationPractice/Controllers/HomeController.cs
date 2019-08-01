using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationPractice.Models;

namespace ValidationPractice.Controllers
{
    public class HomeController : Controller
    {
        private List<FormViewModel> _list = new List<FormViewModel>{
            new FormViewModel
                {
                    Age = 10,
                    BestMovie = "test",
                    DaysWithoutSleep = 11,
                    Email = "test@test.com",
                    EndDate = new DateTime(2019,1,1),
                    FamilyName = "Test",
                    GivenName = "bob",
                    HeightInInches = 12,
                    Id = 1,
                    IsBlakeBetterThanBrian = true,
                    PhoneNumber = "(504) 295-1766",
                    StartDate = new DateTime    (2019,2,2),
                    UserName = "btest",
                    Weight = 200
                },
                new FormViewModel
                {
                     Age = 10,
                    BestMovie = "test",
                    DaysWithoutSleep = 11,
                    Email = "test@test.com",
                    EndDate = new DateTime(2019,1,1),
                    FamilyName = "Test",
                    GivenName = "bob",
                    HeightInInches = 12,
                    Id = 1,
                    IsBlakeBetterThanBrian = true,
                    PhoneNumber = "(504) 295-1766",
                    StartDate = new DateTime    (2019,2,2),
                    UserName = "btest",
                    Weight = 200
                },
                new FormViewModel
                {
                     Age = 10,
                    BestMovie = "test",
                    DaysWithoutSleep = 11,
                    Email = "test@test.com",
                    EndDate = new DateTime(2019,1,1),
                    FamilyName = "Test",
                    GivenName = "bob",
                    HeightInInches = 12,
                    Id = 1,
                    IsBlakeBetterThanBrian = true,
                    PhoneNumber = "(504) 295-1766",
                    StartDate = new DateTime    (2019,2,2),
                    UserName = "btest",
                    Weight = 200
                }
            };
        public IActionResult Index()
        {
            ViewBag.data = _list;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormViewModel vm)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_list.Where(x =>x.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Edit(FormViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var oldVM = _list.Where(x => x.Id == vm.Id).FirstOrDefault();
                var index = _list.IndexOf(oldVM);
                if(index != -1)
                {
                    _list[index] = vm;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
