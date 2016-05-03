using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OceanicFinanceBank.Models
{
    public enum LoanPurpose
    {
        [Display(Name = "Buying a car")]
        BuyingCar,
        [Display(Name = "Consolidation Debt")]
        CosolidateLoan
    }

    public enum CreditQuality
    {
        [Display(Name = "Excellent (700+)")]
        Excellent,
        [Display(Name = "Not Too Bad (550-600)")]
        NotToBad,
        [Display(Name = "Poor (below 500)")]
        Poor
    }

    public class GetQuoteMvcModel
    {
        public int Id { get; set; }
        [DisplayName("Enter The Amount for the Loan")]
        public double LoanAmount { get; set; }

        [DisplayName("Select the Purpose for the Loan")]
        public LoanPurpose LoanPurposeSelection { get; set; }

        [DisplayName("Select Your Credit Quality")]
        public CreditQuality CreditQualitySelection { get; set; }
        
    }
}