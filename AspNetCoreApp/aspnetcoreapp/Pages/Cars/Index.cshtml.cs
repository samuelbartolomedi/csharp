﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspnetcoreapp.Data;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly aspnetcoreapp.Data.aspnetcoreappContext _context;

        public IndexModel(aspnetcoreapp.Data.aspnetcoreappContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Car != null)
            {
                Car = await _context.Car.ToListAsync();
            }
        }
    }
}
