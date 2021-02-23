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

        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int CompletedPickups { get; set; }

        public DayOfWeek RegularPickupDay { get; set; }

        public DateTime? SuspendStartDate { get; set; }
        public DateTime? SuspendEndDate { get; set; }
        public DateTime? OneTimePickupDate { get; set; }

        public DateTime? NextPickupDate()
        {
            
            //Picked up on regular pickup day
            if(DateTime.Today.DayOfWeek==RegularPickupDay)
            {
           
                if(OneTimePickupDate>DateTime.Today.AddDays(7)||OneTimePickupDate==null)
                {
                    if (DateTime.Today.AddDays(7) <= SuspendStartDate||SuspendStartDate==null)
                    {
                        return DateTime.Today.AddDays(7);
                    }
                    else if (DateTime.Today.AddDays(7)<=SuspendEndDate)
                    {
                        if(OneTimePickupDate)
                    }
                    
                }
                else
                {
                    if (OneTimePickupDate >= SuspendStartDate && OneTimePickupDate <= SuspendEndDate)
                    {
                        return DateTime.Today.AddDays(7);
                    }
                }
            }
            else if(DateTime.Today==OneTimePickupDate)
            {

            }
        }
        public double Balance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        
    }
}
