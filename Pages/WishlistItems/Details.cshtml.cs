using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wishlist.Core;
using Wishlist.Data.Context;

namespace Wishlist.Pages.WishlistItems
{
    public class DetailsModel : PageModel
    {
        private readonly Wishlist.Data.Context.WishlistDbContext _context;

        public DetailsModel(Wishlist.Data.Context.WishlistDbContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Items.FirstOrDefaultAsync(m => m.Id == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
