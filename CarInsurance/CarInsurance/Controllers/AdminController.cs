using CarInsurance.Models;
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
                var insurees = (from c in db.Insurees select c).ToList();

                var insuree_list = new List<Insuree>();
                foreach (var insuree in insurees)
                {
                    var insuree_detail = new Insuree();
                    insuree_detail.Id = insuree.Id;
                    insuree_detail.FirstName = insuree.FirstName;
                    insuree_detail.LastName = insuree.LastName;
                    insuree_detail.EmailAddress = insuree.EmailAddress;
                    insuree_detail.Quote = insuree.Quote;
                    insuree_list.Add(insuree_detail);
                }

                return View(insuree_list);
            }    
        }
    }
}