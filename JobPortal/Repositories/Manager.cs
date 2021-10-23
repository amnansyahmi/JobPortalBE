using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobPortal.Shares;

namespace JobPortal.Repositories
{
    public class Manager : IDisposable
    {
        protected JobPortalContext _context;
        private bool disposed = false;

        public Manager(JobPortalContext context)
        {
            _context = context;
        }

        public Manager()
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}