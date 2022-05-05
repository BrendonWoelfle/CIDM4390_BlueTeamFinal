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
    public class IndexModel : PageModel
    {
        private readonly webapp.Data.ApplicationDbContext _context;

        public IndexModel(webapp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Form> Form { get;set; }

        public async Task OnGetAsync()
        {
            Form = await _context.Form.ToListAsync();
        }
    }
}
