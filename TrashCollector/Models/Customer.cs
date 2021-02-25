using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        
        [NotMapped]
        public ICollection<DateTime> CompletedPickups { get; set; }

        public DayOfWeek RegularPickupDay { get; set; }

        public DateTime? SuspendStartDate { get; set; }
        public DateTime? SuspendEndDate { get; set; }
        public DateTime? OneTimePickupDate { get; set; }

        public DateTime? NextPickupDate { get; set; }
        
        public double Balance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        
    }
}
