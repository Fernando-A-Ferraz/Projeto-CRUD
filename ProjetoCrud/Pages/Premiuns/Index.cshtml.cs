using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Data;
using ProjetoCrud.Models;

namespace ProjetoCrud.Pages_Premiuns
{
    public class IndexModel : PageModel
    {
        private readonly ProjetoCrud.Data.ApplicationDbContext _context;

        public IndexModel(ProjetoCrud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Premiuns != null)
            {
                Premium = await _context.Premiuns
                .Include(p => p.student).ToListAsync();
            }
        }
    }
}
