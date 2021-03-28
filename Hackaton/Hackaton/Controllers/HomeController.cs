using Hackaton.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Person()
        {
            return View();
        }
        public IActionResult RiskStatusCreate()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }

        PersonRepo repo = new PersonRepo();
        public IActionResult RiskStatusShow(int id)
        {            
            List<RiskStatus> status = repo.GetAllRisksByPerson(id);
            return View(status);
        }

        [HttpPost]
        public IActionResult RiskStatusCreate(RiskStatus model, int id)
        {
            if (ModelState.IsValid)
            {
                repo.AddRiskStatusToPerson(model, id);
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult PeopleList()
        {
            return View(repo.GetAllPeople());
        }

        [HttpPost]
        public IActionResult Person(Person model)
        {
            if (ModelState.IsValid)
            {
                repo.CreatePerson(model);
                return RedirectToAction("PeopleList");
            }
            return View(model);
        }


        public IActionResult PeopleDelete(int id)
        {
            return View(repo.GetPersonById(id));
        }
        [HttpPost]
        public IActionResult PeopleDelete(int id, IFormCollection notUsed)
        {
            repo.DeletePerson(id);
            return RedirectToAction("PeopleList");
        }

        public IActionResult RiskDelete(int pId, int rId)
        {
            return View(repo.GetRiskStatusByIdAndPId(pId, rId));
        }
        [HttpPost]
        public IActionResult RiskDelete(int pId, int rId, IFormCollection notUsed)
        {
            repo.DeleteRiskStatusOfPerson(pId, rId);
            return RedirectToAction("PeopleList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
