using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityKullaniciYonetimi.Models
{
    public class ApplicationUser : IdentityUser
    {
       
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }
    }
}
