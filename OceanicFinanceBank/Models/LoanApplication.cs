using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OceanicFinanceBank.Models
{

  public enum LoanType
    {
        Personal=0,
        Business=1
    }

    public enum Status
    {
        Applied,
        Approved,
        Pending,
        Denied
    }

    public class LoanApplicationViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int CreditScore { get; set; }
        public double AnnualIncome { get; set; }
       // public int ApplicantId { get; set; }
        public LoanType LoanApplicationType { get; set; }
       // public DateTime ApplicationDate { get; set; }
        public double LoanAmount { get; set; }
        //public String ApplicationStatus { get; set; }
        
    }

    public class LoanApplication
    {
        public int ID { get; set; }
        public int ApplicantId { get; set; }
        public LoanType LoanApplicationType { get; set; }
        public DateTime ApplicationDate { get; set; }
        public double LoanAmount { get; set; }
        public Status ApplicationStatus { get; set; }
        public virtual Customer Applicant { get; set; }
    }
}