using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OceanicFinanceBank.DAL;
using OceanicFinanceBank.Models;

namespace OceanicFinanceBank.Controllers
{
    public class LoanApplicationsController : Controller
    {
        private OceanicContext db = new OceanicContext();

        // GET: LoanApplications
        public ActionResult Index()
        {
            var loanApplications = db.LoanApplications.Include(l => l.Applicant);
            return View(loanApplications.ToList());
        }

        // GET: LoanApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplication loanApplication = db.LoanApplications.Find(id);
            if (loanApplication == null)
            {
                return HttpNotFound();
            }
            return View(loanApplication);
        }

        // GET: LoanApplications/Create
        public ActionResult Create()
        {
            ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName");
            return View();
        }

        // POST: LoanApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ApplicantId,LoanApplicationType,ApplicationDate,LoanAmount,ApplicationStatus")] LoanApplication loanApplication)
        {
            if (ModelState.IsValid)
            {
                db.LoanApplications.Add(loanApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName", loanApplication.ApplicantId);
            return View(loanApplication);
        }


        [HttpPost]       
        public ActionResult Apply( LoanApplicationViewModel loanApplication)
        {
            if (loanApplication.CreditScore>0)
            {
                if (ModelState.IsValid)
                {

                  


                    var customer = new Customer()
                    {
                        FirstName = loanApplication.FirstName,
                        LastName = loanApplication.LastName,
                        SSN = loanApplication.SSN,
                        BirthDate = loanApplication.BirthDate,
                        Address = loanApplication.Address,
                        City = loanApplication.City,
                        Country = loanApplication.Country,
                        Zip = loanApplication.Zip,
                        Email = loanApplication.Email,
                        Gender = loanApplication.Gender,
                        CreditScore = loanApplication.CreditScore,
                        AnnualIncome = loanApplication.AnnualIncome,
                        
                    };

                   
                    db.Customers.Add(customer);
                    db.SaveChanges();

                    var loanApp = new LoanApplication()
                    {

                        LoanApplicationType = loanApplication.LoanApplicationType,
                        ApplicationDate = DateTime.Now,
                        LoanAmount = loanApplication.LoanAmount,
                        Applicant = customer

                    };

                    if (loanApplication.CreditScore > 675 && loanApplication.AnnualIncome >= 55000)
                    {
                        loanApp.ApplicationStatus = Status.Approved;

                    }
                    else
                    {
                        loanApp.ApplicationStatus = Status.Denied;
                    }

                    db.LoanApplications.Add(loanApp);
                    db.SaveChanges();

                    //            public int ApplicantId { get; set; }
                    //public LoanType LoanApplicationType { get; set; }
                    //public DateTime ApplicationDate { get; set; }
                    //public double LoanAmount { get; set; }
                    //public Status ApplicationStatus { get; set; }
                    //public virtual Customer Applicant { get; set; }

                    //db.LoanApplications.Add(loanApplication);
                    //db.SaveChanges();
                    // return RedirectToAction("Index");
                }

            }

          

            //ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName", loanApplication.ApplicantId);
            loanApplication.IsFromGetQuote = false;
            return View();
        }


        [HttpPost]
        public ActionResult ApplyCommit(GetQuoteMvcModel loanApplication)
        {
            if (ModelState.IsValid)
            {
                //db.LoanApplications.Add(loanApplication);
                //db.SaveChanges();
                // return RedirectToAction("Index");
            }

            //ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName", loanApplication.ApplicantId);
            
            return View();
        }



        // GET: LoanApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplication loanApplication = db.LoanApplications.Find(id);
            if (loanApplication == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName", loanApplication.ApplicantId);
            return View(loanApplication);
        }

        // POST: LoanApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ApplicantId,LoanApplicationType,ApplicationDate,LoanAmount,ApplicationStatus")] LoanApplication loanApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicantId = new SelectList(db.Customers, "ID", "FirstName", loanApplication.ApplicantId);
            return View(loanApplication);
        }

        // GET: LoanApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanApplication loanApplication = db.LoanApplications.Find(id);
            if (loanApplication == null)
            {
                return HttpNotFound();
            }
            return View(loanApplication);
        }

        // POST: LoanApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanApplication loanApplication = db.LoanApplications.Find(id);
            db.LoanApplications.Remove(loanApplication);
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
