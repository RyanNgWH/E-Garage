﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSD_Assignment.Models;
using System;
using System.Threading.Tasks;

namespace SSD_Assignment.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public CreateModel(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ApplicationRole.CreatedDate = DateTime.UtcNow;
            IdentityResult roleRuslt = await _roleManager.CreateAsync(ApplicationRole);
            return RedirectToPage("Index");
        }
    }
}