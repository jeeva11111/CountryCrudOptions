using CountryCrudOptions.Data;
using CountryCrudOptions.Models;
using CountryCrudOptions.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Diagnostics.Metrics;

namespace CountryCrudOptions.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public UserController(ApplicationDbcontext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //get country list as SelectListItem
            ViewBag.Country = _context.Countries.ToList().Select(c => new SelectListItem { Value = c.countryId.ToString(), Text = c.countryName }).ToList();
            return View();
        }

        public IActionResult GetStates(int Id)
        {
            var statesList = _context.States.Where(s => s.CountryId == Id).ToList().Select(c => new SelectListItem { Value = c.CountryId.ToString(), Text = c.stateName }).ToList();
            return Json(statesList);
        }

        [HttpPost]
        public IActionResult Index(int? country, int? state, int? city)
        {
            ViewBag.SelectCountry = _context.Countries.Where(x => x.countryId == country).FirstOrDefault().countryName;
            ViewBag.selectState = _context.States.Where(x => x.StateId == state).FirstOrDefault();
            ViewBag.Country = _context.Countries.ToList().Select(x => new SelectListItem { Value = x.countryId.ToString(), Text = x.countryName }).ToList();
            ViewBag.City = _context.Cities.Where(x => x.cityId == city).FirstOrDefault();
            return View();
        }

        public JsonResult GetEmpDeties()
        {
            User userList = new User();
            return Json(userList);
        }

        [HttpGet]

        public ActionResult addUser()
        {

            var store = _context.Users.Include(x => x.City).Include(x => x.Country).ToList();

            return View();
        }

        [HttpPost]
        public ActionResult addUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                return Json("Record is added");
            }
            catch (Exception ex) { return Json("Record is added", ex.Message); }
        }

        [HttpPost]

        public JsonResult Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return Json("Records deleted");
        }

        [HttpPost]

        public JsonResult Edit(int id)
        {
            _context.Users.Where(x => x.Id == id).ToList();
            return Json("Records updated");
        }

        [HttpPost]

        public JsonResult Edit(User user)
        {
            User userClass = new User();
            userClass.Id = user.Id;
            return Json("Record is added");
        }

        [HttpGet]

        public PartialViewResult GetDetails()
        {
            return PartialView("_UserDetails");
        }


        public IActionResult AddAllDetails(User user)
        {
            var store = user.
        }
    }




}

