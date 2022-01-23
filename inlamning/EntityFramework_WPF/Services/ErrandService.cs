using EntityFramework_WPF.Data;
using EntityFramework_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Services
{
    internal interface IErrandService
    {
        bool Create(string errandname, string description, string status, int userid);
        IEnumerable<Errand> GetAll();
    }

    internal class ErrandService : IErrandService
    {
        private readonly SqlContext _context = new();
        public bool Create(string errandname, string description, string status, int userid)
        {
            var errand = _context.Errands.Where(x => x.ErrandName == errandname).FirstOrDefault();
            if (errand == null)
            {
                _context.Errands.Add(new Errand
                {
                    UserId = userid,
                    ErrandName = errandname,
                    Description = description,
                    Status = status,
                    DateTime = DateTime.Now
                });
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Errand> GetAll()
        {
            return _context.Errands;
        }
    }
}
