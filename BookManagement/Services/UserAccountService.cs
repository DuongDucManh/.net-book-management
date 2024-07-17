using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _repo = new();

        public UserAccount CheckLogin(string email, string password) 
        {
            UserAccount acc = _repo.GetUserAccount(email);
            if(acc != null && acc.Password == password)
                return acc;
            


            return null;//wrong password or wrong email
        }
    }
}
