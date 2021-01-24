using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.Insurees;
                var quoteVms = new List<QuoteVm>();
                //loop through & map to a view model
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.Id = quote.Id;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.Quote = quote.Quote;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}

