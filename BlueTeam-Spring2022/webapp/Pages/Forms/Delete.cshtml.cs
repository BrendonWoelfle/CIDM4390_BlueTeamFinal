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
    public class DeleteModel : PageModel
    {
        private readonly webapp.Data.ApplicationDbContext _context;

        public DeleteModel(webapp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Form = await _context.Form.FindAsync(id);

            if (Form != null)
            {
                _context.Form.Remove(Form);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
