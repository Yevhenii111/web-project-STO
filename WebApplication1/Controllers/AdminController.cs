using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

      
        public ActionResult Index()
        {
            var athr = (from Admins in db.Admins select Admins).ToList();
            return View(athr);
        }

        public ActionResult IndexMaster()
        {
            var athr = (from Masters in db.Masters select Masters).ToList();
            return View(athr);
        }

        public ActionResult IndexKlient()
        {
            var athr = (from Klients in db.Klients select Klients).ToList();
            return View(athr);
        }

        public ActionResult IndexCar()
        {
            var athr = (from Cars in db.Cars select Cars).ToList();
            return View(athr);
        }

        public ActionResult Details(int id)
        {
            var athr = (from zakaz in db.Zakazs where zakaz.IdAdmin == id select zakaz).ToList();
            return View(athr);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Admin emp = new Admin();
            return View(emp);
        }

        [HttpPost]
        public ActionResult Create(Admin emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Admins.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult CreateMaster()
        {
            Master emp = new Master();
            return View(emp);
        }

        [HttpPost]
        public ActionResult CreateMaster(Master emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Masters.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("IndexMaster");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult CreateZakaz()
        {
            Zakaz emp = new Zakaz();
            return View(emp);
        }

        [HttpPost]
        public ActionResult CreateZakaz(Zakaz emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Zakazs.Add(emp);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
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
                    return RedirectToAction("IndexKlient");
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
                    return RedirectToAction("IndexCar");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(emp);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var empEdit = (from emp in db.Admins where emp.IdAdmin == id select emp).First();
            return View(empEdit);

        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Admins where emp.IdAdmin == id select emp).First();
            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View(empEdit);
            }
        }

        [HttpGet]

        public ActionResult EditMaster(int id)
        {
            var empEdit = (from emp in db.Masters where emp.IdMaster == id select emp).First();
            return View(empEdit);

        }

        [HttpPost]
        public ActionResult EditMaster(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Masters where emp.IdMaster == id select emp).First();
            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("IndexMaster");

            }
            catch
            {
                return View(empEdit);
            }
        }

        [HttpGet]
        public ActionResult EditZakaz(int id)
        {
            var empEdit = (from emp in db.Zakazs where emp.IdZakaz == id select emp).First();
            return View(empEdit);

        }

        [HttpPost]
        public ActionResult EditZakaz(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Zakazs where emp.IdZakaz == id select emp).First();
            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View(empEdit);
            }
        }

        [HttpGet]
        public ActionResult EditKlient(int id)
        {
            var empEdit = (from emp in db.Klients where emp.IdKlient == id select emp).First();
            return View(empEdit);

        }

        [HttpPost]
        public ActionResult EditKlient(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Klients where emp.IdKlient == id select emp).First();
            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("IndexKlient");

            }
            catch
            {
                return View(empEdit);
            }
        }

        [HttpGet]
        public ActionResult EditCar(int id)
        {
            var empEdit = (from emp in db.Cars where emp.IdCar == id select emp).First();
            return View(empEdit);

        }

        [HttpPost]
        public ActionResult EditCar(int id, FormCollection collection)
        {
            var empEdit = (from emp in db.Cars where emp.IdCar == id select emp).First();
            try
            {
                UpdateModel(empEdit);
                db.SaveChanges();
                return RedirectToAction("IndexCar");

            }
            catch
            {
                return View(empEdit);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empDelete = (from emp in db.Admins where emp.IdAdmin == id select emp).First();
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Admins where emp.IdAdmin == id select emp).First();
            try
            {
                db.Admins.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(empDelete);
            }
        }

        [HttpGet]
        public ActionResult DeleteMaster(int id)
        {
            var empDelete = (from emp in db.Masters where emp.IdMaster == id select emp).First();
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult DeleteMaster(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Masters where emp.IdMaster == id select emp).First();
            try
            {
                db.Masters.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("IndexMaster");
            }
            catch
            {
                return View(empDelete);
            }
        }

        [HttpGet]
        public ActionResult DeleteZakaz(int id)
        {
            var empDelete = (from emp in db.Zakazs where emp.IdZakaz == id select emp).First();
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult DeleteZakaz(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Zakazs where emp.IdZakaz == id select emp).First();
            try
            {
                db.Zakazs.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(empDelete);
            }
        }


        [HttpGet]
        public ActionResult DeleteKlient(int id)
        {
            var empDelete = (from emp in db.Klients where emp.IdKlient == id select emp).First();
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult DeleteKlient(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Klients where emp.IdKlient == id select emp).First();
            try
            {
                db.Klients.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("IndexKlient");
            }
            catch
            {
                return View(empDelete);
            }
        }

        [HttpGet]
        public ActionResult DeleteCar(int id)
        {
            var empDelete = (from emp in db.Cars where emp.IdCar == id select emp).First();
            return View(empDelete);
        }
        [HttpPost]
        public ActionResult DeleteCar(int id, FormCollection collection)
        {
            var empDelete = (from emp in db.Cars where emp.IdCar == id select emp).First();
            try
            {
                db.Cars.Remove(empDelete);
                db.SaveChanges();
                return RedirectToAction("IndexCar");
            }
            catch
            {
                return View(empDelete);
            }
        }
    }
}