#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Forms
{
    public class DetailsModel : PageModel
    {
        private readonly webapp.Data.ApplicationDbContext _context;

        public DetailsModel(webapp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Form Form { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Form = await _context.Form.FirstOrDefaultAsync(m => m.FormID == id);

            if (Form == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
