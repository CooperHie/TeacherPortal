﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeacherDirectory.Models;
using TeacherDirectory.Services;

namespace TeacherPortal.Pages.V2
{
    public class DetailsModel : PageModel
    {
        private readonly TeacherDirectory.Services.AppDbContext _context;

        public DetailsModel(TeacherDirectory.Services.AppDbContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teachers.FirstOrDefaultAsync(m => m.ID == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}