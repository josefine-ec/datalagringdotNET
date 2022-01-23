using EntityFramework_WPF.Data;
using EntityFramework_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Services
{
    internal interface IUserService
    {
        bool Create(string firstname, string lastname, string email, int mobile, string address, int zipcode, string city, string country);
        IEnumerable<User> GetAll();
    }

    internal class UserService : IUserService
    {
        private readonly SqlContext _context = new();
        public bool Create(string firstname, string lastname, string email, int mobile, string address, int zipcode, string city, string country)
        {
            var user = _context.Users.Where(x => x.Email == email).FirstOrDefault();
            if(user == null)
            {
                _context.Users.Add(new User
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    Mobile = mobile,
                    Address = address,
                    ZipCode = zipcode,
                    City = city,
                    Country = country
                });
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}
