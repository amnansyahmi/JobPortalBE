using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using JobPortal.Models;

namespace JobPortal.Shares
{
    public class JobPortalContext : DbContext
    {
        public JobPortalContext() : base(GlobalVariables.ConnectionString)
        {
            this.Database.CommandTimeout = 180;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<JobPortalContext>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        #region DBSet

        public DbSet<_CONFIG_CODES_DTL> CONFIG_CODES_DTL { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<JobList> JobList { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<CodeConfig> CodeConfig { get; set; }

        #endregion DBSet
    }
}