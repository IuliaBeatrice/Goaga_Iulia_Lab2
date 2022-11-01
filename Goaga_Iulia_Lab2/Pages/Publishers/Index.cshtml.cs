using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goaga_Iulia_Lab2.Data;
using Goaga_Iulia_Lab2.Models;

namespace Goaga_Iulia_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Goaga_Iulia_Lab2.Data.Goaga_Iulia_Lab2Context _context;

        public IndexModel(Goaga_Iulia_Lab2.Data.Goaga_Iulia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
