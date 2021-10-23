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

        public DbSet<_ACCOUNT> ACCOUNT { get; set; }
        public DbSet<_CUSTOMER> CUSTOMER { get; set; }
        public DbSet<_CUSTOMER_HIST> CUSTOMER_HIST { get; set; }
        public DbSet<_PARAM_LICENSE> PARAM_LICENSE { get; set; }
        public DbSet<_STAFF> STAFF { get; set; }
        public DbSet<_PARAM_STAFF> PARAM_STAFF { get; set; }
        public DbSet<_PARAM_ROUTE> PARAM_ROUTE { get; set; }
        public DbSet<_RF_CASE> RF_CASE { get; set; }
        public DbSet<_RF_TM> RF_TM { get; set; }
        public DbSet<_ES_ACCESS_TOKEN> ES_ACCESS_TOKEN { get; set; }
        public DbSet<_CONFIG_WF_TMHDR> CONFIG_WF_TMHDR { get; set; }
        public DbSet<_CONFIG_WF_TMDTL> CONFIG_WF_TMDTL { get; set; }
        public DbSet<_CONFIG_WF_FILTER> CONFIG_WF_FILTER { get; set; }
        public DbSet<_CONFIG_CODES_HDR> CONFIG_CODES_HDR { get; set; }
        public DbSet<_CONFIG_CODES_DTL> CONFIG_CODES_DTL { get; set; }
        public DbSet<_PARAM_ERROR> PARAM_ERROR { get; set; }
        public DbSet<_CONFIG_WEB> CONFIG_WEB { get; set; }
        public DbSet<_PARAM_MAPPING_HDR> PARAM_MAPPING_HDR { get; set; }
        public DbSet<_PARAM_MAPPING_DTL> PARAM_MAPPING_DTL { get; set; }
        public DbSet<_PARAM_SMSEMAIL> PARAM_SMSEMAIL { get; set; }
        public DbSet<_PARAM_USER> PARAM_USER { get; set; }
        public DbSet<_RULE_WM_HDR> RULE_WM_HDR { get; set; }
        public DbSet<_RF_WMDTL> RF_WMDTL { get; set; }
        public DbSet<_RF_WM> RF_WM { get; set; }
        public DbSet<_RF_PORTFOLIO> RF_PORTFOLIO { get; set; }
        public DbSet<_RF_WM_ACT> RF_WM_ACT { get; set; }
        public DbSet<_RULE_WM_DTL> RULE_WM_DTL { get; set; }
        public DbSet<_CONFIG_FILTER> CONFIG_FILTER { get; set; }
        public DbSet<_CONFIG_WF_DTL> CONFIG_WF_DTL { get; set; }
        public DbSet<_CONFIG_WF_HDR> CONFIG_WF_HDR { get; set; }
        public DbSet<_CONFIG_JOB> CONFIG_JOB { get; set; }
        public DbSet<_CONFIG_JOB_STEP> CONFIG_JOB_STEP { get; set; }
        public DbSet<_CONFIGMISCTABLEDATALIST> CONFIGMISCTABLEDATALIST { get; set; }
        public DbSet<_WATCHLISTCOUNTRYRISK> WATCHLISTCOUNTRYRISK { get; set; }
        public DbSet<_WATCHLISTALGORITHM> WATCHLISTALGORITHM { get; set; }
        public DbSet<_WATCHLISTALGORITHMDTL> WATCHLISTALGORITHMDTL { get; set; }
        public DbSet<_WL_BATCHLOG> WL_BATCHLOG { get; set; }
        public DbSet<_WL_BATCHDTL> WL_BATCHDTL { get; set; }
        public DbSet<_RF_WMCOMPARISON> RF_WMCOMPARISON { get; set; }
        public DbSet<_AUDIT_MASTER> AUDIT_MASTER { get; set; }
        public DbSet<_PARAM_STR_HDR> PARAM_STR_HDR { get; set; }
        public DbSet<_PARAM_STR_DTL> PARAM_STR_DTL { get; set; }
        public DbSet<_RPT_STR_HDR> RPT_STR_HDR { get; set; }
        public DbSet<_RPT_STR_DTL> RPT_STR_DTL { get; set; }

        //Onboard Monitoring
        public DbSet<_RF_OMDTL> RF_OMDTL { get; set; }

        public DbSet<_RF_OM> RF_OM { get; set; }
        public DbSet<_RF_OM_ACT> RF_OM_ACT { get; set; }
        public DbSet<_RF_WM_ATTACH> RF_WM_ATTACH { get; set; }
        public DbSet<_RF_OM_ATTACH> RF_OM_ATTACH { get; set; }
        public DbSet<_RF_OMCOMPARISON> RF_OMCOMPARISON { get; set; }
        public DbSet<_WATCHLISTALGORITHMCAT> WATCHLISTALGORITHMCAT { get; set; }
        public DbSet<_CUSTOMER_WHITELIST> CUSTOMER_WHITELIST { get; set; }

        #endregion DBSet

        public System.Data.Entity.DbSet<JobPortal.Models.cor_code> cor_code { get; set; }
    }
}