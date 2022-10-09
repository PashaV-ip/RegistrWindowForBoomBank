using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrWindowForBoomBank.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Password  { get; set; }
        public string BankCard { get; set; }
        public Roles Role { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + Role;
        }
    }
}
