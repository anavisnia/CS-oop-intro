using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Bank
    {
        // properties
        public string Name { get; set; } = "Default bank";

        public List<Customer> Customers { get; set; }

        public bool Deleted { get; private set; } = false;

        // constructor
        //public Bank()
        //{
        //    Name = "Default Bank";
        //}

        public string GetInformation()
        {
            return Name;
        }

        public void SetDeteled(bool value)
        {
            Deleted = value;
        }
    }
}
