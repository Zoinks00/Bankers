using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banker.Models;

namespace Banker
{
   public interface IUserRepository
    {// method to get all users in database
        public IEnumerable<Users> GetAllUsers();

        //method to get Users id
        public Users GetUsers(int id);
    }
}
