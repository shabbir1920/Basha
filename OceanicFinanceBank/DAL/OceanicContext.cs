using OceanicFinanceBank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OceanicFinanceBank.DAL
{
    public class OceanicContext:DbContext
    {
        public OceanicContext():base("OceanicContext") {  }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<OceanicFinanceBank.Models.GetQuoteMvcModel> GetQuoteMvcModels { get; set; }

        public System.Data.Entity.DbSet<OceanicFinanceBank.Models.LoanApplicationViewModel> LoanApplicationViewModels { get; set; }
    }
}
