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
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
            int carYear, string carMake, string carModel, string DUI, int speedingTickets, string fullCoverageOrLiability)
        {
            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                var quote = new Quote();
                quote.FirstName = firstName;
                quote.LastName = lastName;
                quote.EmailAddress = emailAddress;
                quote.DateOfBirth = dateOfBirth;
                quote.CarYear = carYear;
                quote.CarMake = carMake;
                quote.CarModel = carModel;
                quote.DUI = DUI;
                quote.SpeedingTickets = speedingTickets;
                quote.FullCoverageOrLiability = fullCoverageOrLiability;

                //calculate quote
                quote.QuoteAmount = 50; //Start with a base of $50 / month.

                //get age
                int age = (DateTime.Now.Year - dateOfBirth.Year);
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age -= 1;

                //If the user is under 25, add $25 to the monthly total.
                if (age < 25)
                {
                    quote.QuoteAmount += 25;
                }

                //If the user is under 18, add $100 to the monthly total.
                if (age < 18)
                {
                    quote.QuoteAmount += 100;
                }

                //If the user is over 100, add $25 to the monthly total.
                if (age > 100)
                {
                    quote.QuoteAmount += 25;
                }

                //If the car's year is before 2000, add $25 to the monthly total.
                if (carYear < 2000)
                {
                    quote.QuoteAmount += 25;
                }

                //If the car's year is after 2015, add $25 to the monthly total.
                if (carYear > 2015)
                {
                    quote.QuoteAmount += 25;
                }

                //If the car's Make is a Porsche, add $25 to the price.
                if (carMake == "Porsche")
                {
                    quote.QuoteAmount += 25;
                    if (carModel == "911 Carrera")
                    {
                        quote.QuoteAmount += 25;
                    }
                }

                //Add $10 to the monthly total for every speeding ticket the user has.
                quote.QuoteAmount += speedingTickets * 10;

                //If the user has ever had a DUI, add 25% to the total.
                if (DUI == "Yes")
                {
                    quote.QuoteAmount *= 1.25m;
                }

                //If it's full coverage, add 50% to the total.
                if (fullCoverageOrLiability == "Full Coverage")
                {
                    quote.QuoteAmount *= 1.5m;
                }

                //add to database
                db.Quotes.Add(quote);
                db.SaveChanges();
            }
            return View("Index");
        }





    }
}
//private InsuranceEntities db = new InsuranceEntities();

// GET: Insuree
//public ActionResult Index()
//{
//    return View(db.Insurees.ToList());
//}

// GET: Insuree/Details/5
//public ActionResult Details(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }
//    Insuree insuree = db.Insurees.Find(id);
//    if (insuree == null)
//    {
//        return HttpNotFound();
//    }
//    return View(insuree);
//}

// GET: Insuree/Create
//public ActionResult Create()
//{
//    return View();
//}

// POST: Insuree/Create
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
//{
//    if (ModelState.IsValid)
//    {
//        db.Insurees.Add(insuree);
//        db.SaveChanges();
//        return RedirectToAction("Index");
//    }

//    return View(insuree);
//}

// GET: Insuree/Edit/5
//public ActionResult Edit(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }
//    Insuree insuree = db.Insurees.Find(id);
//    if (insuree == null)
//    {
//        return HttpNotFound();
//    }
//    return View(insuree);
//}

//// POST: Insuree/Edit/5
//// To protect from overposting attacks, enable the specific properties you want to bind to, for 
//// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
//{
//    if (ModelState.IsValid)
//    {
//        db.Entry(insuree).State = EntityState.Modified;
//        db.SaveChanges();
//        return RedirectToAction("Index");
//    }
//    return View(insuree);
//}

//// GET: Insuree/Delete/5
//public ActionResult Delete(int? id)
//{
//    if (id == null)
//    {
//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//    }
//    Insuree insuree = db.Insurees.Find(id);
//    if (insuree == null)
//    {
//        return HttpNotFound();
//    }
//    return View(insuree);
//}

//// POST: Insuree/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public ActionResult DeleteConfirmed(int id)
//{
//    Insuree insuree = db.Insurees.Find(id);
//    db.Insurees.Remove(insuree);
//    db.SaveChanges();
//    return RedirectToAction("Index");
//}

//protected override void Dispose(bool disposing)
//{
//    if (disposing)
//    {
//        db.Dispose();
//    }
//    base.Dispose(disposing);
//}

//        public ActionResult CreateQuote(int Id)
//        {
//            {
//                using (InsuranceEntities db = new InsuranceEntities())
//                {
//                    var insuree = db.Insurees.Find(Id);
//                    decimal baseAmt = 50;

//                    bool is18AndUnder = insuree.DateOfBirth.AddYears(18) <= DateTime.Now;
//                    bool is19To25 = insuree.DateOfBirth.AddYears(25) <= DateTime.Now;

//                    bool isBefore2000 = insuree.CarYear < 2000;
//                    bool isAfter2015 = insuree.CarYear > 2015;

//                    bool isPorsche = insuree.CarMake == "Porsche";
//                    bool isPorscheCarrera = insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera";

//                    bool hasTickets = insuree.SpeedingTickets > 0;

//                    bool hasDUI = insuree.DUI;

//                    bool isFullCoverage = insuree.CoverageType;

//                    foreach (var person in db.Insurees)
//                    {
//                        if (is18AndUnder)
//                        {
//                            baseAmt += 100;
//                        }
//                        else if (is19To25)
//                        {
//                            baseAmt += 50;
//                        }
//                        else
//                        {
//                            baseAmt += 25;
//                        }

//                        if (isBefore2000 || isAfter2015)
//                        {
//                            baseAmt += 25;
//                        }

//                        if (isPorscheCarrera)
//                        {
//                            baseAmt += 50;
//                        }
//                        else if (isPorsche && !isPorscheCarrera)
//                        {
//                            baseAmt += 25;
//                        }

//                        if (hasTickets)
//                        {
//                            int ticketAdd = person.SpeedingTickets * 10;
//                            baseAmt += ticketAdd;
//                        }

//                        if (hasDUI)
//                        {
//                            decimal duiFee = baseAmt * 0.25m;
//                            baseAmt += duiFee;
//                        }

//                        if (isFullCoverage)
//                        {
//                            decimal coverageFee = baseAmt * 0.50m;
//                            baseAmt += coverageFee;
//                        }

//                        insuree.Quote = baseAmt;
//                    }
//                    db.SaveChanges();
//                }
//            }

//            return View();
//        }
//    }
//}
