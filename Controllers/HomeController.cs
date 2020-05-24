using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVH.Models;
using Microsoft.AspNetCore.Mvc;

namespace EVH.Controllers
{
    public class HomeController : Controller
    {
        private EVHDBContext evhContext;
        public HomeController(EVHDBContext sc)
        {
            evhContext = sc;
        }

        public IActionResult Index()
        {
            return View(evhContext.HealthRecords);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create_Post(HealthRecords healthRecords)
        {
            if (ModelState.IsValid)
            {
                evhContext.HealthRecords.Add(healthRecords);
                evhContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public IActionResult Update(int id)
        {
            return View(evhContext.HealthRecords.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update_Post(HealthRecords healthRecords)
        {
            evhContext.HealthRecords.Update(healthRecords);
            evhContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var healthRecords = evhContext.HealthRecords.Where(a => a.Id == id).FirstOrDefault();
            evhContext.HealthRecords.Remove(healthRecords);
            evhContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}