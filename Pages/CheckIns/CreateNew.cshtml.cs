﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project334.Data;
using Project334.Models;

namespace Project334.Pages.CheckIns
{
    public class CreateModelNew : PageModel
    {
        private readonly Project334.Data.Project334Context _context;

        public CreateModelNew(Project334.Data.Project334Context context)
        {
            _context = context;
        }

        [BindProperty]
        public VisitorCheckIn VisitorCheckIn { get; set; }

        //public IActionResult OnGet(/*int id*/)
        public IActionResult OnGet()
        {
            //int activityId = id;

            //VisitorCheckIn = await _context.VisitorsCheckIn.FirstOrDefaultAsync(m => m.ID == id);

            /*VisitorCheckIn.BusinessActivityID = (int)id;
            if (VisitorCheckIn == null)
            {
                return NotFound();
            }*/
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VisitorsCheckIn.Add(VisitorCheckIn);
            await _context.SaveChangesAsync();

            //return RedirectToPage("./Businesses/Details", new { id = VisitorCheckIn.BusinessActivityID });
            return RedirectToPage("/Businesses/Index");
        }
    }
}
