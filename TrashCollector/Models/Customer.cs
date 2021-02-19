using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DayOfWeek RegularPickupDay { get; set; }

        public DateTime SuspendStartDate { get; set; }
        public DateTime SuspendEndDate { get; set; }
        public DateTime OneTimePickupDate { get; set; }


    }
}
