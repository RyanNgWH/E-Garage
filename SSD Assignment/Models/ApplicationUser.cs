using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSD_Assignment.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [FileExtensions(Extensions = "png", ErrorMessage = "Please upload a valid image file. (Only png file extensions are supported)")]
        public string ProfilePic { get; set; }
    }
}
