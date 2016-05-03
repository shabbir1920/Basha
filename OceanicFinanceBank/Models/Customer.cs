using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OceanicFinanceBank.Models
{
    public class Customer
    {
        public int ID { get; set; }
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
        public virtual ICollection<LoanApplication> LoanApplications { get; set; }
    }
}