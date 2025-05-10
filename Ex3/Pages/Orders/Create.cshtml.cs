using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;
using Ex3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ex3.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly IRepository _repository;

        public CreateModel(IRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Order Order { get; set; }
        public IEnumerable<Item>? Items { get; set; }
        public IEnumerable<Agent>? Agents { get; set; }

        public void OnGet()
        {
            Order = new Order { OrderDate = DateTime.Now, OrderDetails = new List<OrderDetail> { new OrderDetail() } };
            Items = _repository.GetAllItems();
            Agents = _repository.GetAllAgents();
        }

        public IActionResult OnPost(string addDetail)
        {
            Items = _repository.GetAllItems();
            Agents = _repository.GetAllAgents();

            if (!string.IsNullOrEmpty(addDetail))
            {
                Order.OrderDetails.Add(new OrderDetail());
                return Page();
            }

            if (ModelState.IsValid)
            {
                _repository.AddOrder(Order);
                return RedirectToPage("/Orders/Report", new { orderId = Order.OrderID });
            }
            return Page();
        }
    }
}