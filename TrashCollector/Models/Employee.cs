using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ZipCode { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
