﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project334.Data;
using Project334.Models;

namespace Project334.Pages.BookAppointments
{
    public class IndexModel : PageModel
    {
        private readonly Project334.Data.Project334Context _context;

        public IndexModel(Project334.Data.Project334Context context)
        {
            _context = context;
        }

        public IList<BookAppointment> BookAppointment { get;set; }

        public async Task OnGetAsync()
        {
            BookAppointment = await _context.BookAppointments
                .Include(s => s.Patient)
                .ToListAsync();
        }
    }
}
