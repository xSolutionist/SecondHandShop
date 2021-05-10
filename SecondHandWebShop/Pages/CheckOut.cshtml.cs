using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondHandWebShop.Data;
using SecondHandWebShop.Helpers;
using SecondHandWebShop.Models;

namespace SecondHandWebShop.Pages
{

    public class CheckOutModel : PageModel
    {
        private readonly ProductContext _context;

        public CheckOutModel(ProductContext context)
        {
            _context = context;
        }
        public decimal Total { get; set; }

        [BindProperty]
        public Order Order { get; set; }
        public List<Item> OrderItems { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./OrderDetails");
        }
    }
}
