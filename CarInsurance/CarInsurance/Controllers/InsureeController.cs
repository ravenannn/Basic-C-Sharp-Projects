using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,FullCoverage,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                int age = 0;
                age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
                    age = age - 1;


                bool dui = Convert.ToBoolean(insuree.DUI);
                bool coverage = Convert.ToBoolean(insuree.FullCoverage);
                int carYear = Convert.ToInt32(insuree.CarYear);
                int tickets = Convert.ToInt32(insuree.SpeedingTickets);


                decimal total = 50;


                if (age < 25)
                {
                    total = (total + 25);
                }
                if (age < 18)
                {
                    total = (total + 100);
                }
                if (age > 100)
                {
                    total = (total + 25);
                }
                if (carYear < 2000)
                {
                    total = (total + 25);
                }
                if (carYear > 2015)
                {
                    total = (total + 25);
                }
                if (insuree.CarMake == "Porsche")
                {
                    total = (total + 25);
                }
                else if (insuree.CarModel == "911 Carrera")
                {
                    total = (total + 25);
                }

                total = total + tickets * 10;



                if (dui == true)
                {
                    total += (total * .25m);


                }
                if (coverage == true)
                {
                    total += (total * .50m);
                    total = (Decimal)System.Math.Round(total, 2);
                }

                insuree.Quote = total;
                //ViewBag.quote = total;
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return View("Quote", total);

            }

            return View(insuree);

        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,FullCoverage,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

