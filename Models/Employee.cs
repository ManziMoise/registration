using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Postion { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public int EmployeeTypeId { get; set; }

        [ForeignKey("EmployeeTypeId")]
        public virtual EmployeeType EmployeeType { get; set; }

    }
}
