﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSD_Assignment.Models
{
    public class Listing
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z.\-\)\(][\sa-zA-Z0-9.\-\)\(]*$", ErrorMessage = "Please enter an alphanumeric string that starts with an alphabet (Parenthesis are allowed).")]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"^[\sa-zA-Z0-9_@./#&+-]*$", ErrorMessage = "Please enter a valid string.")]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Condition { get; set; }
        public string PhotoPath { get; set; }
        //[Required]
        [NotMapped]
        //[FileExtensions(Extensions =".png,.jpg,.gif", ErrorMessage ="Only .png, .jpg and .gif files are allowed")]
        public IFormFile Photo { get; set; }
        public string UserName { get; set; }
        public DateTime PostedDateTime { get; set; }
        public bool Promoted { get; set; }
    }
}
