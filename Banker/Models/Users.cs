using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banker.Models
{
    public class Users
    {
        public Users()
        {}
    public int IdUser { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
        public int IdBalance { get; set; }
   }
}
