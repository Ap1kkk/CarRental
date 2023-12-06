using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
  public  class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string PhoneNumber { get; set; }
        public string status { get; set; }
        public string experience { get; set; }
        public string workBegin { get; set; }
        public string workEnd { get; set; }

        public static bool operator !=(Employee left, Employee right)
        {
            if ( (left.PhoneNumber != right.PhoneNumber) ||
                (left.lastName != right.lastName) ||
                (left.firstName != right.firstName)
                )
                return true;
            else return false;
        }
        public static bool operator ==(Employee left, Employee right)
        {
            if ((left.PhoneNumber == right.PhoneNumber) &&
                            (left.lastName == right.lastName) &&
                            (left.firstName == right.firstName)
                            ) return true;
            else return false;
        }
    }
}
