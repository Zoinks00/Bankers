using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banker.Models; //ref models folder
using System.Data;
using Dapper;

namespace Banker
{
    public class UserRepository: IUserRepository
    {
        private readonly IDbConnection _conn;

        //constructor
        public UserRepository(IDbConnection conn)
        {
            //connector
            _conn = conn;
        }

        //call to get all users from database
        public IEnumerable<Users> GetAllUsers()
        {
            return _conn.Query<Users>("Select * FROM USER");
        }

        //method to get users
        public Users GetUsers(int id)
        {
            return _conn.QuerySingle<Users>("SELECT * FROM USER WHERE IDUSER = @id",
               new { id = id });
        }
    }
}
