﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wba.Films.Web.Data;
using Wba.Films.Web.Models;


namespace Wba.Films.Web.Pages.Film
{
    public class DetailsModel : PageModel
    {
        private readonly Wba.Films.Web.Data.WbaFilmsWebContext _context;

        public DetailsModel(Wba.Films.Web.Data.WbaFilmsWebContext context)
        {
            _context = context;
        }

        public Wba.Films.Web.Models.Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FirstOrDefaultAsync(m => m.ID == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
