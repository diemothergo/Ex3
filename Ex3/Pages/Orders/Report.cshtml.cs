using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;
using Ex3.Models;

namespace Ex3.Pages.Orders
{
    public class ReportModel : PageModel
    {
        private readonly IRepository _repository;

        public ReportModel(IRepository repository)
        {
            _repository = repository;
        }

        public Order? Order { get; set; }

        public IActionResult OnGet(int orderId)
        {
            Order = _repository.GetAllOrders().FirstOrDefault(o => o.OrderID == orderId);
            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}