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
        public ActionResult Apply( GetQuoteMvcModel loanApplication)
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
