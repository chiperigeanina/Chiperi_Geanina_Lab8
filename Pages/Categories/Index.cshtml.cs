﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chiperi_Geanina_Lab8.Data;
using Chiperi_Geanina_Lab8.Models;

namespace Chiperi_Geanina_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Chiperi_Geanina_Lab8.Data.Chiperi_Geanina_Lab8Context _context;

        public IndexModel(Chiperi_Geanina_Lab8.Data.Chiperi_Geanina_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
