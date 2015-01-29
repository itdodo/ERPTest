using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP.BLL;
using ERP.Model;

namespace ERP.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Employee model)
        {
            return View();
        }
    }
}