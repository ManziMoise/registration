using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class CarIn
    {
        public int Id { get; set; }
        public int InternalEmployeeId { get; set; }
        public int ExternalEmployeeId { get; set; }

        public int CarId { get; set; }
        public DateTimeOffset CheckedOutPeriod { get; set; }
        public string Status { get; set; }

        [ForeignKey("InternalEmployeeId")]
        public virtual Employee InternalEmployee { get; set; }
        [ForeignKey("ExternalEmployeeId")]
        public virtual Employee ExternalEmployee { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }



    }
}
