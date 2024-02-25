using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    public abstract class Person
    {
        protected Person()
        {

        }

        protected Person(string firstName, string lastName, string address, string email, string gender)
        {
            Fname = firstName;
            Lname = lastName;
            Address = address;
            Email = email;
            Gender = gender;


        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int contactNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
