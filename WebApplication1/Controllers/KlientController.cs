using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KlientController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();
        // GET: Klient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult IndexKlient(int id)
        {
            var athr = (from Klient in db.Klients where Klient.IdKlient == id select Klient).ToList();
            return View(athr);
        }

        public ActionResult IndexCar(int id)
        {
            var athr = (from Car in db.Cars where Car.IdCar == id select Car).ToList();
            return View(athr);
        }

        [HttpGet]
        public ActionResult CreateKlient()
        {
            Klient emp = new Klient();
            return View(emp);
        }

        [HttpPost]
        public ActionResult CreateKlient(Klient emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Klients.Add(emp);
                    db.SaveChanges();
      
                    return RedirectToAction("IndexKlient",  new { id = emp.IdKlient} );
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }
        [HttpGet]
        public ActionResult CreateCar()
        {
            Car emp = new Car();
            return View(emp);
        }

        [HttpPost]
        public ActionResult CreateCar(Car emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Cars.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("IndexCar", new { id = emp.IdCar });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(OperandsModel model)
        {
            string result = string.Empty;

            Zakaz zak = new Zakaz();
            var check = (from zakaz1 in db.Zakazs where zakaz1.IdCar == model.Num1 select zakaz1.Status).First();
            //int ch = Convert.ToInt32(check);
            if (check == 1)
            {
                result = "Работы выполнены";
            }
            else
            {
                result = "Работы выполняются";
            }

            ViewBag.Result = result; //result container

            return View();
        }
    }
}