using Restolog.Entities;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restolog.DataAccess.Repositories
{
    public class LogRepository
    {
        private readonly RestologContext _context;

        public LogRepository(RestologContext context)
        {
            _context = context;
        }

        public void Add(Log log)
        {
            _context.Logs.Add(log);
            _context.SaveChanges();
        }

        public List<Log> GetAll()
        {
            return _context.Logs.ToList();
        }

        public List<Log> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Logs
                .Where(l => l.Date >= startDate && l.Date <= endDate)
                .ToList();
        }
    }
}