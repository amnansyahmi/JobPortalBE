using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using JobPortal.Shares;
using JobPortal.Models;

//using AMLP.Query;
//using AdminQueryManager;
using AdminQueryManager;
using JobPortal.Repositories;

namespace JobPortal.Repositories
{
    public class JobPortalManager : Manager
    {
        public JobPortalManager(JobPortalContext context) : base(context)
        {
            //enf
        }

        //TESTCOMMENT

        public JobPortalManager() : base()
        {
        }

        public List<JobList> GetJobList(Int32 SQLCase)
        {
            switch (SQLCase)
            {
                case 1:
                    return _context.Database.SqlQuery<JobList>(AdminQuery.GetJobList(SQLCase)).ToList();

                default:
                    return _context.Database.SqlQuery<JobList>(AdminQuery.GetJobList(SQLCase)).ToList();
            }
        }
    }
}