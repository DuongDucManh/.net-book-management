using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementContext _context;

        public List<UserAccount> GetUserAccounts()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }

        //Offer a method to return an account instead of all account

        public UserAccount GetUserAccount(string email)
        {
            //if user types correct email -> return an Account 
            //if user types wrong email -> return null
            _context = new();
            return _context.UserAccounts.FirstOrDefault(x => x.Email == email);
        }
        
    }
}
