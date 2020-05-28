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
    public class IndexModel : PageModel
    {
        private readonly Wishlist.Data.Context.WishlistDbContext _context;

        public IndexModel(Wishlist.Data.Context.WishlistDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
